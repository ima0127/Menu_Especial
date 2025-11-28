using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Menu_Especial
{
    public partial class FormPersonal : Form
    {
        // Variable para guardar el ID del registro seleccionado
        private int idSeleccionado = 0;

        public FormPersonal()
        {
            InitializeComponent();

            comboPuesto.DropDownStyle = ComboBoxStyle.DropDownList;

            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
            btnModificar.Click += btnModificar_Click;
            btnBuscar.Click += btnBuscar_Click;
            btnCancelarBusqueda.Click += btnCancelarBusqueda_Click;
            this.Load += FormPersonal_Load;
        }

        // ===================== CARGA INICIAL =====================

        private void FormPersonal_Load(object sender, EventArgs e)
        {
            CargarPuestos();
            CargarPersonal();
        }

        private void CargarPuestos()
        {
            string conexion = @"Server=.\SQLEXPRESS;Database=menuUsuarios;Trusted_Connection=True;";

            using (SqlConnection con = new SqlConnection(conexion))
            {
                try
                {
                    con.Open();
                    string query = "SELECT idPuesto, nombre FROM Puesto";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboPuesto.DataSource = dt;
                    comboPuesto.DisplayMember = "nombre";
                    comboPuesto.ValueMember = "idPuesto";
                    comboPuesto.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar puestos: " + ex.Message);
                }
            }
        }

        private void CargarPersonal()
        {
            string conexion = @"Server=.\SQLEXPRESS;Database=menuUsuarios;Trusted_Connection=True;";

            using (SqlConnection con = new SqlConnection(conexion))
            {
                try
                {
                    con.Open();
                    string query = "SELECT idPersonal, nombre, cedula, direccion, idPuesto FROM Personal";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar personal: " + ex.Message);
                }
            }
        }

        // ===================== GUARDAR NUEVO =====================

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string cedula = txtCedula.Text.Trim();
            string direccion = txtDireccion.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(cedula) ||
                string.IsNullOrWhiteSpace(direccion) ||
                comboPuesto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe llenar todos los campos y seleccionar un puesto.");
                return;
            }

            int idPuesto = Convert.ToInt32(comboPuesto.SelectedValue);
            string conexion = @"Server=.\SQLEXPRESS;Database=menuUsuarios;Trusted_Connection=True;";

            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    string query = "INSERT INTO Personal (nombre, cedula, direccion, idPuesto) VALUES (@Nombre, @Cedula, @Direccion, @idPuesto)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Cedula", cedula);
                    cmd.Parameters.AddWithValue("@Direccion", direccion);
                    cmd.Parameters.AddWithValue("@idPuesto", idPuesto);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Personal guardado correctamente.");
                LimpiarCampos();
                CargarPersonal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        // ===================== MODIFICAR =====================

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un registro del listado para modificarlo.");
                return;
            }

            string nombre = txtNombre.Text.Trim();
            string cedula = txtCedula.Text.Trim();
            string direccion = txtDireccion.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(cedula) ||
                string.IsNullOrWhiteSpace(direccion) ||
                comboPuesto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe llenar todos los campos antes de modificar.");
                return;
            }

            int idPuesto = Convert.ToInt32(comboPuesto.SelectedValue);
            string conexion = @"Server=.\SQLEXPRESS;Database=menuUsuarios;Trusted_Connection=True;";

            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    string query = "UPDATE Personal SET nombre=@Nombre, cedula=@Cedula, direccion=@Direccion, idPuesto=@idPuesto WHERE idPersonal=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Cedula", cedula);
                    cmd.Parameters.AddWithValue("@Direccion", direccion);
                    cmd.Parameters.AddWithValue("@idPuesto", idPuesto);
                    cmd.Parameters.AddWithValue("@id", idSeleccionado);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registro modificado correctamente.");
                LimpiarCampos();
                CargarPersonal();
                idSeleccionado = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        // ===================== BUSCAR =====================

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();
            if (texto == "")
            {
                MessageBox.Show("Ingrese un nombre para buscar.");
                return;
            }

            string conexion = @"Server=.\SQLEXPRESS;Database=menuUsuarios;Trusted_Connection=True;";
            using (SqlConnection con = new SqlConnection(conexion))
            {
                try
                {
                    con.Open();
                    string query = "SELECT idPersonal, nombre, cedula, direccion, idPuesto FROM Personal WHERE nombre LIKE @buscar";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@buscar", "%" + texto + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar: " + ex.Message);
                }
            }
        }

        private void btnCancelarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarPersonal();
        }

        // ===================== SELECCIÓN EN DATAGRID =====================

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(fila.Cells["idPersonal"].Value);
                txtNombre.Text = fila.Cells["nombre"].Value.ToString();
                txtCedula.Text = fila.Cells["cedula"].Value.ToString();
                txtDireccion.Text = fila.Cells["direccion"].Value.ToString();
                comboPuesto.SelectedValue = fila.Cells["idPuesto"].Value;
            }
        }

        // ===================== LIMPIAR =====================

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCedula.Clear();
            txtDireccion.Clear();
            comboPuesto.SelectedIndex = -1;
            idSeleccionado = 0;
        }

        // ===================== BUSCAR AUTOMÁTICO =====================

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();
            if (texto == "")
            {
                CargarPersonal();
                return;
            }

            string conexion = @"Server=.\SQLEXPRESS;Database=menuUsuarios;Trusted_Connection=True;";
            using (SqlConnection con = new SqlConnection(conexion))
            {
                try
                {
                    con.Open();
                    string query = "SELECT idPersonal, nombre, cedula, direccion, idPuesto FROM Personal WHERE nombre LIKE @buscar";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@buscar", "%" + texto + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar: " + ex.Message);
                }
            }
        }
    }
}
