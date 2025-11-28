using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Menu_Especial.clases;

namespace Menu_Especial
{
    public partial class FormPaciente : Form
    {
        ConexionBD conexion = new ConexionBD();
        private int idSeleccionado = 0; // Guarda el ID del paciente seleccionado

        public FormPaciente()
        {
            InitializeComponent();

            // Asignar eventos
            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click; // ← ahora este método existe
            btnBuscar.Click += btnBuscar_Click;
            btnCancelarBusqueda.Click += btnCancelarBusqueda_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;
            btnModificar.Click += btnModificar_Click;
        }

        private void FormPaciente_Load(object sender, EventArgs e)
        {
            dateFechaNacimiento.MaxDate = DateTime.Today;
            CargarPacientes();
        }

        // ------------------ GUARDAR PACIENTE ------------------
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Debe llenar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dateFechaNacimiento.Value > DateTime.Today)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser futura.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = "INSERT INTO Paciente (Cedula, Nombre, Direccion, FechaNacimiento, Matricula) " +
                                   "VALUES (@Cedula, @Nombre, @Direccion, @FechaNacimiento, @Matricula)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Cedula", txtCedula.Text.Trim());
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text.Trim());
                        cmd.Parameters.AddWithValue("@FechaNacimiento", dateFechaNacimiento.Value);
                        cmd.Parameters.AddWithValue("@Matricula", txtMatricula.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Paciente guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarPacientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ------------------ MODIFICAR PACIENTE ------------------
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un paciente de la lista para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = "UPDATE Paciente SET Cedula = @Cedula, Nombre = @Nombre, Direccion = @Direccion, " +
                                   "FechaNacimiento = @FechaNacimiento, Matricula = @Matricula WHERE idPaciente = @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Cedula", txtCedula.Text.Trim());
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text.Trim());
                        cmd.Parameters.AddWithValue("@FechaNacimiento", dateFechaNacimiento.Value);
                        cmd.Parameters.AddWithValue("@Matricula", txtMatricula.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", idSeleccionado);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Paciente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarPacientes();
                idSeleccionado = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ------------------ CANCELAR / LIMPIAR CAMPOS ------------------
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // ------------------ SELECCIONAR PACIENTE DESDE GRID ------------------
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                idSeleccionado = Convert.ToInt32(fila.Cells["idPaciente"].Value);
                txtCedula.Text = fila.Cells["Cedula"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
                txtMatricula.Text = fila.Cells["Matricula"].Value.ToString();

                if (fila.Cells["FechaNacimiento"].Value != DBNull.Value)
                    dateFechaNacimiento.Value = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value);
            }
        }

        // ------------------ BUSCAR PACIENTE ------------------
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();

            if (texto == "")
            {
                MessageBox.Show("Ingrese un nombre o cédula para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = "SELECT idPaciente, Cedula, Nombre, Direccion, FechaNacimiento, Matricula " +
                                   "FROM Paciente WHERE Nombre LIKE @buscar OR Cedula LIKE @buscar";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@buscar", "%" + texto + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar pacientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ------------------ CANCELAR BÚSQUEDA ------------------
        private void btnCancelarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarPacientes();
        }

        // ------------------ CARGAR TODOS LOS PACIENTES ------------------
        private void CargarPacientes()
        {
            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = "SELECT idPaciente, Cedula, Nombre, Direccion, FechaNacimiento, Matricula FROM Paciente";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pacientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ------------------ LIMPIAR CAMPOS ------------------
        private void LimpiarCampos()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtMatricula.Clear();
            txtBuscar.Clear();
            dateFechaNacimiento.Value = DateTime.Today;
            idSeleccionado = 0;
        }

        // ------------------ OTROS EVENTOS ------------------
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtBuscar_TextChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e)
        {
            btnCancelarBusqueda_Click(sender, e);
        }
    }
}
