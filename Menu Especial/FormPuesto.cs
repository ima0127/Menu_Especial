using Menu_Especial.clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Menu_Especial
{
    public partial class FormPuesto : Form
    {
        ConexionBD conexion = new ConexionBD();
        int idSeleccionado = 0; // Guardará el ID del puesto seleccionado

        public FormPuesto()
        {
            InitializeComponent();

            // Eventos
            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
            btnBuscar.Click += btnBuscar_Click;
            btnModificar.Click += btnModificar_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void FormPuesto_Load(object sender, EventArgs e)
        {
            CargarPuestos();
        }

        // --------------------------------------------------------------------
        // CARGAR TODOS LOS PUESTOS EN EL DATAGRID
        // --------------------------------------------------------------------
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
                MessageBox.Show("Error al cargar puestos: " + ex.Message);
            }
        }

        // --------------------------------------------------------------------
        // GUARDAR UN NUEVO PUESTO
        // --------------------------------------------------------------------
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            if (nombre == "")
            {
                MessageBox.Show("Debe escribir un nombre para el puesto.");
                return;
            }

            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = "INSERT INTO Puesto (nombre) VALUES (@Nombre)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Puesto guardado correctamente.");
                LimpiarCampos();
                CargarPuestos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar puesto: " + ex.Message);
            }
        }

        // --------------------------------------------------------------------
        // BUSCAR PUESTO POR NOMBRE
        // --------------------------------------------------------------------
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();

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
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        // --------------------------------------------------------------------
        // SELECCIONAR FILA DEL DATAGRID PARA MODIFICAR
        // --------------------------------------------------------------------
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSeleccionado = Convert.ToInt32(
                    dataGridView1.Rows[e.RowIndex].Cells["idPuesto"].Value
                );

                txtNombre.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            }
        }

        // --------------------------------------------------------------------
        // MODIFICAR UN PUESTO EXISTENTE
        // --------------------------------------------------------------------
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un puesto de la lista.");
                return;
            }

            string nuevoNombre = txtNombre.Text.Trim();

            if (nuevoNombre == "")
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            try
            {
                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string query = "UPDATE Puesto SET nombre = @Nombre WHERE idPuesto = @Id";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Nombre", nuevoNombre);
                    cmd.Parameters.AddWithValue("@Id", idSeleccionado);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Puesto modificado correctamente.");

                LimpiarCampos();
                CargarPuestos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar puesto: " + ex.Message);
            }
        }

        // --------------------------------------------------------------------
        // LIMPIAR CAMPOS
        // --------------------------------------------------------------------
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtBuscar.Clear();
            txtNombre.Focus();
            idSeleccionado = 0;
        }
    }
}
