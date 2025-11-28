using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Menu_Especial
{
    public partial class FormListaPaciente : Form
    {
        public FormListaPaciente()
        {
            InitializeComponent();
        }

        // =====================================================
        // LOAD DEL FORMULARIO
        // =====================================================
        private void FormListaPaciente_Load(object sender, EventArgs e)
        {
            CargarPacientes();

            // Opciones del ComboBox sin duplicados
            cmbExportar.Items.Clear();
            cmbExportar.Items.Add("Texto (.txt)");
            cmbExportar.Items.Add("HTML (.html)");
            cmbExportar.Items.Add("Excel (.csv)");
            cmbExportar.Items.Add("JSON (.json)");
            cmbExportar.Items.Add("XML (.xml)");

            cmbExportar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbExportar.SelectedIndex = 0;
        }

        // =====================================================
        // CARGA DE PACIENTES (DATOS DE PRUEBA)
        // =====================================================
        private void CargarPacientes()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("ID");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellido");
            tabla.Columns.Add("Telefono");
            tabla.Columns.Add("Direccion");

            tabla.Rows.Add("1", "George", "Ramos", "809-555-1234", "Santo Domingo");
            tabla.Rows.Add("2", "Lucia", "Martinez", "809-555-8923", "Santiago");
            tabla.Rows.Add("3", "Luis", "Perez", "809-555-4444", "La Vega");

            dataGridView1.DataSource = tabla;
        }

        // =====================================================
        // BOTÓN BUSCAR
        // =====================================================
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(texto))
            {
                CargarPacientes();
                return;
            }

            DataTable tabla = (DataTable)dataGridView1.DataSource;
            DataView dv = tabla.DefaultView;
            dv.RowFilter =
                $"Nombre LIKE '%{texto}%' OR Apellido LIKE '%{texto}%' OR Telefono LIKE '%{texto}%'";

            dataGridView1.DataSource = dv.ToTable();
        }

        // =====================================================
        // BOTÓN CANCELAR
        // =====================================================
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            CargarPacientes();
        }

        // =====================================================
        // BOTÓN SALIR
        // =====================================================
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // =====================================================
        // EXPORTACIÓN
        // =====================================================
        private void btnExportar_Click(object sender, EventArgs e)
        {
            string opcion = cmbExportar.SelectedItem.ToString();

            switch (opcion)
            {
                case "Texto (.txt)": ExportarTXT(); break;
                case "HTML (.html)": ExportarHTML(); break;
                case "Excel (.csv)": ExportarCSV(); break;
                case "JSON (.json)": ExportarJSON(); break;
                case "XML (.xml)": ExportarXML(); break;
            }
        }

        // =====================================================
        // EXPORTAR TXT
        // =====================================================
        private void ExportarTXT()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo TXT|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using StreamWriter sw = new StreamWriter(sfd.FileName);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        sw.WriteLine(
                            $"{row.Cells["ID"].Value} | " +
                            $"{row.Cells["Nombre"].Value} | " +
                            $"{row.Cells["Apellido"].Value} | " +
                            $"{row.Cells["Telefono"].Value} | " +
                            $"{row.Cells["Direccion"].Value}"
                        );
                    }
                }

                MessageBox.Show("Exportado correctamente a TXT.");
                AbrirArchivo(sfd.FileName);
            }
        }

        // =====================================================
        // EXPORTAR HTML
        // =====================================================
        private void ExportarHTML()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo HTML|*.html";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StringBuilder html = new StringBuilder();
                html.Append("<html><body><h2>Listado de Pacientes</h2>");
                html.Append("<table border='1'>");

                html.Append("<tr>");
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                    html.Append($"<th>{col.HeaderText}</th>");
                html.Append("</tr>");

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        html.Append("<tr>");
                        foreach (DataGridViewCell cell in row.Cells)
                            html.Append($"<td>{cell.Value}</td>");
                        html.Append("</tr>");
                    }
                }

                html.Append("</table></body></html>");
                File.WriteAllText(sfd.FileName, html.ToString());

                MessageBox.Show("Exportado correctamente a HTML.");
                AbrirArchivo(sfd.FileName);
            }
        }

        // =====================================================
        // EXPORTAR CSV (EXCEL)
        // =====================================================
        private void ExportarCSV()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel CSV|*.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StringBuilder csv = new();

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    csv.Append(dataGridView1.Columns[i].HeaderText);
                    if (i < dataGridView1.Columns.Count - 1)
                        csv.Append(",");
                }
                csv.AppendLine();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            csv.Append(row.Cells[i].Value);
                            if (i < row.Cells.Count - 1)
                                csv.Append(",");
                        }
                        csv.AppendLine();
                    }
                }

                File.WriteAllText(sfd.FileName, csv.ToString());
                MessageBox.Show("Exportado correctamente a CSV.");
                AbrirArchivo(sfd.FileName);
            }
        }

        // =====================================================
        // EXPORTAR JSON
        // =====================================================
        private void ExportarJSON()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo JSON|*.json";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                DataTable tabla = (DataTable)dataGridView1.DataSource;
                string json = JsonConvert.SerializeObject(tabla, Formatting.Indented);
                File.WriteAllText(sfd.FileName, json);

                MessageBox.Show("Exportado correctamente a JSON.");
                AbrirArchivo(sfd.FileName);
            }
        }

        // =====================================================
        // EXPORTAR XML
        // =====================================================
        private void ExportarXML()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo XML|*.xml";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                DataTable tabla = (DataTable)dataGridView1.DataSource;
                tabla.TableName = "Pacientes";
                tabla.WriteXml(sfd.FileName);

                MessageBox.Show("Exportado correctamente a XML.");
                AbrirArchivo(sfd.FileName);
            }
        }

        // =====================================================
        // FUNCIÓN PARA ABRIR ARCHIVO
        // =====================================================
        private void AbrirArchivo(string ruta)
        {
            try
            {
                var psi = new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = ruta,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el archivo: " + ex.Message);
            }
        }
    }
}
