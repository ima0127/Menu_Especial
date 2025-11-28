using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json; // usamos JsonConvert y Newtonsoft.Json.Formatting

namespace Menu_Especial
{
    public partial class FormConsulta : Form
    {
        // Ajusta la cadena si tu servidor/DB son diferentes
        private string connectionString = @"Server=.\SQLEXPRESS;Database=menuUsuarios;Trusted_Connection=True;";

        // Para saber qué consulta estamos editando
        private int idConsultaSeleccionada = -1;

        public FormConsulta()
        {
            InitializeComponent();

            // Aseguramos que los handlers estén conectados (si el Designer no los conectó)
            this.Load += FormConsulta_Load;

            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
            btnBuscar.Click += btnBuscar_Click;
            button1.Click += btnCancelarBusqueda_Click; // button1 es "Cancelar" del buscador
            btnModificar.Click += btnModificar_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;

            
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            // Configuraciones iniciales
            comboPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPersonal.DropDownStyle = ComboBoxStyle.DropDownList;
            dateFechaConsulta.MaxDate = DateTime.Today;

            // Llenar controles desde DB
            CargarPacientes();
            CargarPersonal();
            CargarConsultas();

            // Configurar comboExportar si existe
            if (comboExportar != null)
            {
                comboExportar.Items.Clear();
                comboExportar.Items.Add("Texto (.txt)");
                comboExportar.Items.Add("Excel (.csv)");
                comboExportar.Items.Add("HTML (.html)");
                comboExportar.Items.Add("JSON (.json)");
                comboExportar.Items.Add("XML (.xml)");
                comboExportar.DropDownStyle = ComboBoxStyle.DropDownList;
                comboExportar.SelectedIndex = 0;
            }
        }

        // --------------------------
        // CARGAR COMBOS
        // --------------------------
        private void CargarPacientes()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT idPaciente, Nombre FROM Paciente";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboPaciente.DataSource = dt;
                    comboPaciente.DisplayMember = "Nombre";
                    comboPaciente.ValueMember = "idPaciente";
                    comboPaciente.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPersonal()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT idPersonal, Nombre FROM Personal";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboPersonal.DataSource = dt;
                    comboPersonal.DisplayMember = "Nombre";
                    comboPersonal.ValueMember = "idPersonal";
                    comboPersonal.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar personal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --------------------------
        // CARGAR CONSULTAS (LISTADO)
        // --------------------------
        private void CargarConsultas(string filtro = "")
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                        SELECT C.idConsulta,
                               P.Nombre AS Paciente,
                               PE.Nombre AS Personal,
                               C.FechaConsulta,
                               C.Diagnostico,
                               C.Procedimiento
                        FROM Consulta C
                        INNER JOIN Paciente P ON C.idPaciente = P.idPaciente
                        INNER JOIN Personal PE ON C.idPersonal = PE.idPersonal";

                    if (!string.IsNullOrWhiteSpace(filtro))
                        query += " WHERE P.Nombre LIKE @buscar";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    if (!string.IsNullOrWhiteSpace(filtro))
                        da.SelectCommand.Parameters.AddWithValue("@buscar", "%" + filtro + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    // ocultar idConsulta al usuario
                    if (dataGridView1.Columns.Contains("idConsulta"))
                        dataGridView1.Columns["idConsulta"].Visible = false;

                    dataGridView1.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar consultas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -------------------------
        // GUARDAR CONSULTA
        // -------------------------
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (comboPaciente.SelectedIndex == -1 ||
                comboPersonal.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtDiagnostico.Text) ||
                string.IsNullOrWhiteSpace(txtProcedimiento.Text))
            {
                MessageBox.Show("Debe completar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPaciente = Convert.ToInt32(comboPaciente.SelectedValue);
            int idPersonal = Convert.ToInt32(comboPersonal.SelectedValue);
            DateTime fecha = dateFechaConsulta.Value.Date;
            string diagnostico = txtDiagnostico.Text.Trim();
            string procedimiento = txtProcedimiento.Text.Trim();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                        INSERT INTO Consulta (idPaciente, idPersonal, FechaConsulta, Diagnostico, Procedimiento)
                        VALUES (@idPaciente, @idPersonal, @Fecha, @Diagnostico, @Procedimiento)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
                        cmd.Parameters.AddWithValue("@idPersonal", idPersonal);
                        cmd.Parameters.AddWithValue("@Fecha", fecha);
                        cmd.Parameters.AddWithValue("@Diagnostico", diagnostico);
                        cmd.Parameters.AddWithValue("@Procedimiento", procedimiento);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Consulta guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarConsultas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -------------------------
        // SELECCIONAR CONSULTA DESDE EL GRID
        // -------------------------
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

            // Intentamos obtener idConsulta de forma segura
            try
            {
                if (dataGridView1.Columns.Contains("idConsulta"))
                    idConsultaSeleccionada = Convert.ToInt32(fila.Cells["idConsulta"].Value);
                else
                    idConsultaSeleccionada = Convert.ToInt32(fila.Cells[0].Value);
            }
            catch
            {
                idConsultaSeleccionada = -1;
            }

            // Rellenar campos (con protecciones por null)
            try { comboPaciente.Text = fila.Cells["Paciente"].Value?.ToString() ?? ""; } catch { }
            try { comboPersonal.Text = fila.Cells["Personal"].Value?.ToString() ?? ""; } catch { }
            try { dateFechaConsulta.Value = Convert.ToDateTime(fila.Cells["FechaConsulta"].Value); } catch { dateFechaConsulta.Value = DateTime.Today; }
            try { txtDiagnostico.Text = fila.Cells["Diagnostico"].Value?.ToString() ?? ""; } catch { txtDiagnostico.Clear(); }
            try { txtProcedimiento.Text = fila.Cells["Procedimiento"].Value?.ToString() ?? ""; } catch { txtProcedimiento.Clear(); }
        }

        // -------------------------
        // MODIFICAR CONSULTA
        // -------------------------
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idConsultaSeleccionada == -1)
            {
                MessageBox.Show("Debe seleccionar una consulta del listado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboPaciente.SelectedIndex == -1 ||
                comboPersonal.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtDiagnostico.Text) ||
                string.IsNullOrWhiteSpace(txtProcedimiento.Text))
            {
                MessageBox.Show("Complete todos los campos antes de modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                        UPDATE Consulta
                        SET idPaciente = @idPaciente,
                            idPersonal = @idPersonal,
                            FechaConsulta = @Fecha,
                            Diagnostico = @Diagnostico,
                            Procedimiento = @Procedimiento
                        WHERE idConsulta = @idConsulta";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@idConsulta", idConsultaSeleccionada);
                        cmd.Parameters.AddWithValue("@idPaciente", comboPaciente.SelectedValue);
                        cmd.Parameters.AddWithValue("@idPersonal", comboPersonal.SelectedValue);
                        cmd.Parameters.AddWithValue("@Fecha", dateFechaConsulta.Value.Date);
                        cmd.Parameters.AddWithValue("@Diagnostico", txtDiagnostico.Text.Trim());
                        cmd.Parameters.AddWithValue("@Procedimiento", txtProcedimiento.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Consulta modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                CargarConsultas();
                idConsultaSeleccionada = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -------------------------
        // BUSCAR CONSULTAS
        // -------------------------
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();
            if (texto == "")
            {
                MessageBox.Show("Ingrese un nombre de paciente para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarConsultas(texto);
        }

        private void btnCancelarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarConsultas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            idConsultaSeleccionada = -1;
        }

        private void LimpiarCampos()
        {
            comboPaciente.SelectedIndex = -1;
            comboPersonal.SelectedIndex = -1;
            dateFechaConsulta.Value = DateTime.Today;
            txtDiagnostico.Clear();
            txtProcedimiento.Clear();
        }

        // Handlers vacíos (si el designer los conectó)
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            // Si quieres búsqueda en tiempo real, descomenta la siguiente línea:
            // CargarConsultas(txtBuscar.Text.Trim());
        }

        private void txtProcedimiento_TextChanged(object sender, EventArgs e)
        {
            // handler vacío para evitar errores si el designer lo registra
        }

        // =====================================================
        // ===========  EXPORTACIÓN (COMBO + BOTÓN) ===========
        // =====================================================

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (comboExportar == null)
            {
                MessageBox.Show("Control comboExportar no encontrado en el diseñador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string opcion = comboExportar.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(opcion))
            {
                MessageBox.Show("Seleccione un formato de exportación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            if (opcion.Contains("Texto"))
                sfd.Filter = "Archivo de texto (*.txt)|*.txt";
            else if (opcion.Contains("Excel"))
                sfd.Filter = "Archivo CSV (*.csv)|*.csv";
            else if (opcion.Contains("HTML"))
                sfd.Filter = "Archivo HTML (*.html)|*.html";
            else if (opcion.Contains("JSON"))
                sfd.Filter = "Archivo JSON (*.json)|*.json";
            else if (opcion.Contains("XML"))
                sfd.Filter = "Archivo XML (*.xml)|*.xml";
            else
                sfd.Filter = "Todos los archivos (*.*)|*.*";

            sfd.FileName = opcion.Contains("Texto") ? "consultas.txt" :
                           opcion.Contains("Excel") ? "consultas.csv" :
                           opcion.Contains("HTML") ? "consultas.html" :
                           opcion.Contains("JSON") ? "consultas.json" :
                           opcion.Contains("XML") ? "consultas.xml" : "consultas";

            if (sfd.ShowDialog() != DialogResult.OK) return;

            string ruta = sfd.FileName;

            try
            {
                if (opcion.Contains("Texto")) ExportarTXT(ruta);
                else if (opcion.Contains("Excel")) ExportarCSV(ruta);
                else if (opcion.Contains("HTML")) ExportarHTML(ruta);
                else if (opcion.Contains("JSON")) ExportarJSON(ruta);
                else if (opcion.Contains("XML")) ExportarXML(ruta);

                // Intentar abrir automáticamente
                AbrirArchivo(ruta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportarTXT(string ruta)
        {
            var sb = new StringBuilder();

            // encabezados
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.Visible)
                    sb.Append(col.HeaderText + "\t");
            }
            sb.AppendLine();

            // filas
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (dataGridView1.Columns[cell.ColumnIndex].Visible)
                            sb.Append((cell.Value ?? "").ToString() + "\t");
                    }
                    sb.AppendLine();
                }
            }

            File.WriteAllText(ruta, sb.ToString(), Encoding.UTF8);
        }

        private void ExportarCSV(string ruta)
        {
            var sb = new StringBuilder();

            // encabezados (solo de columnas visibles)
            bool firstHeader = true;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (!dataGridView1.Columns[i].Visible) continue;
                if (!firstHeader) sb.Append(",");
                sb.Append(dataGridView1.Columns[i].HeaderText);
                firstHeader = false;
            }
            sb.AppendLine();

            // filas
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                bool first = true;
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (!dataGridView1.Columns[i].Visible) continue;
                    if (!first) sb.Append(",");
                    string val = (row.Cells[i].Value ?? "").ToString();
                    val = val.Replace(",", " "); // evitar comas internas
                    sb.Append(val);
                    first = false;
                }
                sb.AppendLine();
            }

            File.WriteAllText(ruta, sb.ToString(), Encoding.UTF8);
        }

        private void ExportarHTML(string ruta)
        {
            var sb = new StringBuilder();
            sb.Append("<html><body>");
            sb.Append("<h2>Listado de Consultas</h2>");
            sb.Append("<table border='1' cellpadding='5'>");

            // encabezados
            sb.Append("<tr>");
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.Visible)
                    sb.Append("<th>" + System.Net.WebUtility.HtmlEncode(col.HeaderText) + "</th>");
            }
            sb.Append("</tr>");

            // filas
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                sb.Append("<tr>");
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (!dataGridView1.Columns[i].Visible) continue;
                    string texto = (row.Cells[i].Value ?? "").ToString();
                    sb.Append("<td>" + System.Net.WebUtility.HtmlEncode(texto) + "</td>");
                }
                sb.Append("</tr>");
            }

            sb.Append("</table></body></html>");

            File.WriteAllText(ruta, sb.ToString(), Encoding.UTF8);
        }

        private void ExportarJSON(string ruta)
        {
            var lista = new List<Dictionary<string, object>>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                var obj = new Dictionary<string, object>();
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    var col = dataGridView1.Columns[i];
                    if (!col.Visible) continue;
                    string header = col.HeaderText;
                    object val = row.Cells[i].Value ?? "";
                    obj[header] = val;
                }
                lista.Add(obj);
            }

            // especificamos Newtonsoft.Json.Formatting para evitar ambigüedad
            string json = JsonConvert.SerializeObject(lista, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(ruta, json, Encoding.UTF8);
        }

        private void ExportarXML(string ruta)
        {
            // Intentamos aprovechar el DataTable fuente si existe
            try
            {
                if (dataGridView1.DataSource is DataTable dtSource)
                {
                    DataTable dtCopy = dtSource.Copy();
                    dtCopy.TableName = "Consultas";
                    dtCopy.WriteXml(ruta, XmlWriteMode.WriteSchema);
                    return;
                }
            }
            catch
            {
                // si falla, generamos manualmente
            }

            var settings = new XmlWriterSettings() { Indent = true, Encoding = Encoding.UTF8 };
            using (XmlWriter writer = XmlWriter.Create(ruta, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Consultas");

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;
                    writer.WriteStartElement("Consulta");
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        var col = dataGridView1.Columns[i];
                        if (!col.Visible) continue;
                        string tag = XmlConvert.EncodeName(col.HeaderText.Replace(" ", "_"));
                        writer.WriteElementString(tag, (row.Cells[i].Value ?? "").ToString());
                    }
                    writer.WriteEndElement(); // Consulta
                }

                writer.WriteEndElement(); // Consultas
                writer.WriteEndDocument();
            }
        }

        private void AbrirArchivo(string ruta)
        {
            try
            {
                Process.Start(new ProcessStartInfo(ruta) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Archivo exportado, pero no se pudo abrir automáticamente. " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
