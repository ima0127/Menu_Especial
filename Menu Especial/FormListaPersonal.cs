using Menu_Especial.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Menu_Especial
{
    public partial class FormListaPersonal : Form
    {
        ConexionBD conexion = new ConexionBD();

        public FormListaPersonal()
        {
            InitializeComponent();
        }

        private void FormListaPersonal_Load(object sender, EventArgs e)
        {
            CargarPersonal();

            // Bloquear escritura en el ComboBox
            cmbExportar.DropDownStyle = ComboBoxStyle.DropDownList;

            // Cargar opciones sin duplicarse
            cmbExportar.Items.Clear();
            cmbExportar.Items.Add("Texto (.txt)");
            cmbExportar.Items.Add("Excel (.csv)");
            cmbExportar.Items.Add("HTML (.html)");
            cmbExportar.Items.Add("JSON (.json)");
            cmbExportar.Items.Add("XML (.xml)");
            cmbExportar.SelectedIndex = 0;
        }

        // =====================================================
        // Cargar Personal
        // =====================================================
        private void CargarPersonal()
        {
            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = "SELECT idPersonal, nombre, idPuesto FROM Personal";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar personal: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
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
                    string query = "SELECT idPersonal, nombre, idPuesto FROM Personal WHERE nombre LIKE @buscar";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@buscar", "%" + texto + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarPersonal();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            switch (cmbExportar.SelectedItem.ToString())
            {
                case "Texto (.txt)": ExportarTXT(); break;
                case "Excel (.csv)": ExportarCSV(); break;
                case "HTML (.html)": ExportarHTML(); break;
                case "JSON (.json)": ExportarJSON(); break;
                case "XML (.xml)": ExportarXML(); break;
            }
        }

        // ---------------------------- EXPORTAR TXT ----------------------------
        private void ExportarTXT()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Texto|*.txt";
            save.FileName = "ListaPersonal.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(save.FileName))
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            sw.WriteLine(
                                $"ID: {row.Cells["idPersonal"].Value} | " +
                                $"Nombre: {row.Cells["nombre"].Value} | " +
                                $"ID Puesto: {row.Cells["idPuesto"].Value}"
                            );
                        }
                    }
                }

                Process.Start(new ProcessStartInfo(save.FileName) { UseShellExecute = true });
            }
        }

        // ---------------------------- CSV ----------------------------
        private void ExportarCSV()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "CSV|*.csv";
            save.FileName = "ListaPersonal.csv";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(save.FileName))
                {
                    sw.WriteLine("idPersonal,nombre,idPuesto");

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            sw.WriteLine(
                                $"{row.Cells["idPersonal"].Value}," +
                                $"{row.Cells["nombre"].Value}," +
                                $"{row.Cells["idPuesto"].Value}"
                            );
                        }
                    }
                }

                Process.Start(new ProcessStartInfo(save.FileName) { UseShellExecute = true });
            }
        }

        // ---------------------------- HTML ----------------------------
        private void ExportarHTML()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "HTML|*.html";
            save.FileName = "ListaPersonal.html";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StringBuilder html = new StringBuilder();
                html.Append("<html><body><h2>Lista de Personal</h2><table border='1'>");
                html.Append("<tr><th>ID</th><th>Nombre</th><th>ID Puesto</th></tr>");

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        html.Append("<tr>");
                        html.Append($"<td>{row.Cells["idPersonal"].Value}</td>");
                        html.Append($"<td>{row.Cells["nombre"].Value}</td>");
                        html.Append($"<td>{row.Cells["idPuesto"].Value}</td>");
                        html.Append("</tr>");
                    }
                }

                html.Append("</table></body></html>");
                File.WriteAllText(save.FileName, html.ToString());

                Process.Start(new ProcessStartInfo(save.FileName) { UseShellExecute = true });
            }
        }

        // ---------------------------- JSON ----------------------------
        private void ExportarJSON()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JSON|*.json";
            save.FileName = "ListaPersonal.json";

            if (save.ShowDialog() == DialogResult.OK)
            {
                List<object> lista = new List<object>();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        lista.Add(new
                        {
                            idPersonal = row.Cells["idPersonal"].Value,
                            nombre = row.Cells["nombre"].Value,
                            idPuesto = row.Cells["idPuesto"].Value
                        });
                    }
                }

                string json = JsonConvert.SerializeObject(lista, Formatting.Indented);
                File.WriteAllText(save.FileName, json);

                Process.Start(new ProcessStartInfo(save.FileName) { UseShellExecute = true });
            }
        }

        // ---------------------------- XML ----------------------------
        private void ExportarXML()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "XML|*.xml";
            save.FileName = "ListaPersonal.xml";

            if (save.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = (DataTable)dataGridView1.DataSource;
                dt.TableName = "Personal";

                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                ds.WriteXml(save.FileName);

                Process.Start(new ProcessStartInfo(save.FileName) { UseShellExecute = true });
            }
        }
    }
}
