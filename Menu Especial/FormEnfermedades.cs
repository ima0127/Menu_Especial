using Menu_Especial.clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Menu_Especial
{
    public partial class FormEnfermedades : Form
    {
        ConexionBD conexion = new ConexionBD(); // Usamos tu clase de conexión

        public FormEnfermedades()
        {
            InitializeComponent();
            // quitamos la carga desde aquí y la pasamos al Load
        }

        private void FormEnfermedades_Load(object sender, EventArgs e)
        {
            CargarEnfermedades();
            labelID.Text = "";
            dataGridEnfermedades.CellClick += dataGridEnfermedades_CellClick;
            btnGuardar.Click += btnGuardar_Click;
            btnModificar.Click += btnModificar_Click;
            btnCancelar.Click += btnCancelar_Click;
            btnBuscar.Click += btnBuscar_Click;
        }

        private void CargarEnfermedades()
        {
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT idEnfermedad, nombre FROM Enfermedad", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridEnfermedades.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar enfermedades: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtEnfermedad.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, ingresa un nombre de enfermedad.");
                return;
            }

            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Enfermedad (nombre) VALUES (@nombre)", conn);
                    cmd.Parameters.AddWithValue("@nombre", txtEnfermedad.Text.Trim());
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Enfermedad guardada correctamente.");
                txtEnfermedad.Clear();
                CargarEnfermedades();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (labelID.Text == "")
            {
                MessageBox.Show("Selecciona una enfermedad para modificar.");
                return;
            }

            if (txtEnfermedad.Text.Trim() == "")
            {
                MessageBox.Show("El campo de enfermedad no puede estar vacío.");
                return;
            }

            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Enfermedad SET nombre=@nombre WHERE idEnfermedad=@id", conn);
                    cmd.Parameters.AddWithValue("@nombre", txtEnfermedad.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(labelID.Text));
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Enfermedad modificada correctamente.");
                txtEnfermedad.Clear();
                labelID.Text = "";
                CargarEnfermedades();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtEnfermedad.Clear();
            txtBuscar.Clear();
            labelID.Text = "";
            CargarEnfermedades();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT idEnfermedad, nombre FROM Enfermedad WHERE nombre LIKE @busqueda", conn);
                    da.SelectCommand.Parameters.AddWithValue("@busqueda", "%" + txtBuscar.Text.Trim() + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridEnfermedades.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void dataGridEnfermedades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                labelID.Text = dataGridEnfermedades.Rows[e.RowIndex].Cells["idEnfermedad"].Value.ToString();
                txtEnfermedad.Text = dataGridEnfermedades.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            }
        }
    }
}
