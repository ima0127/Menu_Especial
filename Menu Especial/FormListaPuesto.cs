using Menu_Especial.clases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;

namespace Menu_Especial
{
    public partial class FormListaPuesto : Form
    {
        ConexionBD conexion = new ConexionBD();

        public FormListaPuesto()
        {
            InitializeComponent();

            btnBuscar.Click += BtnBuscar_Click;
            btnCancelar.Click += BtnCancelar_Click;
            btnSalir.Click += BtnSalir_Click;

            btnExportar.Click += BtnExportar_Click;

            this.Load += FormListaPuesto_Load;
        }

        private void FormListaPuesto_Load(object sender, EventArgs e)
        {
            CargarPuestos();

            // Agregamos opciones al ComboBox
            comboExportar.Items.Add("Texto (.txt)");
            comboExportar.Items.Add("Excel (.csv)");
            comboExportar.Items.Add("HTML (.html)");
            comboExportar.Items.Add("JSON (.json)");
            comboExportar.Items.Add("XML (.xml)");

            comboExportar.SelectedIndex = 0;
        }

        // ================================
        //   CARGAR PUESTOS
        // ================================
        private void CargarPuestos()
        {
            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = "SELECT idPuesto, nombre FROM Puesto";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        // ================================
        //   BUSCAR
        // ================================
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();

            if (texto == "")
            {
                MessageBox.Show("Ingrese un nombre para buscar.");
                return;
            }

            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = "SELECT idPuesto, nombre FROM Puesto WHERE nombre LIKE @buscar";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@buscar", "%" + texto + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la búsqueda: " + ex.Message);
            }
        }

        // ================================
        //   CANCELAR
        // ================================
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarPuestos();
        }

        // ================================
        //   SALIR
        // ================================
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ===========================================================
        //   BOTÓN EXPORTAR (EL PRINCIPAL)
        // ===========================================================
        private void BtnExportar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            string opcion = comboExportar.SelectedItem.ToString();

            if (opcion.Contains("Texto")) ExportarTXT();
            else if (opcion.Contains("Excel")) ExportarCSV();
            else if (opcion.Contains("HTML")) ExportarHTML();
            else if (opcion.Contains("JSON")) ExportarJSON();
            else if (opcion.Contains("XML")) ExportarXML();
        }

        // ===========================================================
        //  EXPORTAR A TXT
        // ===========================================================
        private void ExportarTXT()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivo de texto (*.txt)|*.txt";
            save.FileName = "puestos.txt";

            if (save.ShowDialog() != DialogResult.OK) return;

            StringBuilder sb = new StringBuilder();

            foreach (DataGridViewColumn col in dataGridView1.Columns)
                sb.Append(col.HeaderText + "\t");

            sb.AppendLine();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cel in row.Cells)
                        sb.Append((cel.Value ?? "").ToString() + "\t");

                    sb.AppendLine();
                }
            }

            File.WriteAllText(save.FileName, sb.ToString(), Encoding.UTF8);
            AbrirArchivo(save.FileName);
        }

        // ===========================================================
        //  EXPORTAR A CSV
        // ===========================================================
        private void ExportarCSV()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivo CSV (*.csv)|*.csv";
            save.FileName = "puestos.csv";

            if (save.ShowDialog() != DialogResult.OK) return;

            StringBuilder sb = new StringBuilder();

            foreach (DataGridViewColumn col in dataGridView1.Columns)
                sb.Append(col.HeaderText + ",");

            sb.AppendLine();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cel in row.Cells)
                    {
                        string texto = (cel.Value ?? "").ToString().Replace(",", " ");
                        sb.Append(texto + ",");
                    }
                    sb.AppendLine();
                }
            }

            File.WriteAllText(save.FileName, sb.ToString(), Encoding.UTF8);
            AbrirArchivo(save.FileName);
        }

        // ===========================================================
        //  EXPORTAR HTML
        // ===========================================================
        private void ExportarHTML()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivo HTML (*.html)|*.html";
            save.FileName = "puestos.html";

            if (save.ShowDialog() != DialogResult.OK) return;

            StringBuilder sb = new StringBuilder();

            sb.Append("<html><body>");
            sb.Append("<h2>Lista de Puestos</h2>");
            sb.Append("<table border='1' cellpadding='5'>");

            sb.Append("<tr>");
            foreach (DataGridViewColumn col in dataGridView1.Columns)
                sb.Append("<th>" + col.HeaderText + "</th>");
            sb.Append("</tr>");

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    sb.Append("<tr>");
                    foreach (DataGridViewCell cel in row.Cells)
                        sb.Append("<td>" + (cel.Value ?? "") + "</td>");
                    sb.Append("</tr>");
                }
            }

            sb.Append("</table></body></html>");

            File.WriteAllText(save.FileName, sb.ToString(), Encoding.UTF8);
            AbrirArchivo(save.FileName);
        }

        // ===========================================================
        //  EXPORTAR JSON
        // ===========================================================
        private void ExportarJSON()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivo JSON (*.json)|*.json";
            save.FileName = "puestos.json";

            if (save.ShowDialog() != DialogResult.OK) return;

            List<Dictionary<string, object>> lista = new List<Dictionary<string, object>>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    Dictionary<string, object> obj = new Dictionary<string, object>();

                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                        obj[col.HeaderText] = row.Cells[col.Index].Value ?? "";

                    lista.Add(obj);
                }
            }

            string json = JsonConvert.SerializeObject(lista, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(save.FileName, json, Encoding.UTF8);

            AbrirArchivo(save.FileName);
        }

        // ===========================================================
        //  EXPORTAR XML
        // ===========================================================
        private void ExportarXML()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivo XML (*.xml)|*.xml";
            save.FileName = "puestos.xml";

            if (save.ShowDialog() != DialogResult.OK) return;

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.Encoding = Encoding.UTF8;

            using (XmlWriter writer = XmlWriter.Create(save.FileName, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Puestos");

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        writer.WriteStartElement("Puesto");
                        writer.WriteElementString("idPuesto", row.Cells[0].Value.ToString());
                        writer.WriteElementString("nombre", row.Cells[1].Value.ToString());
                        writer.WriteEndElement();
                    }
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }

            AbrirArchivo(save.FileName);
        }

        // ===========================================================
        //  ABRIR ARCHIVO AUTOMÁTICAMENTE
        // ===========================================================
        private void AbrirArchivo(string ruta)
        {
            try
            {
                Process.Start(new ProcessStartInfo()
                {
                    FileName = ruta,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Archivo creado, pero no se pudo abrir automáticamente. " + ex.Message);
            }
        }

        private void FormListaPuesto_Load_1(object sender, EventArgs e)
        {

        }
    }
}
