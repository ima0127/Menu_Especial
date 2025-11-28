using Menu_Especial.clases;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Menu_Especial
{
    public partial class FormCrearUsuario : Form
    {
        // Instancia de tu clase de conexión
        private ConexionBD conexion;

        public FormCrearUsuario()
        {
            InitializeComponent();
            conexion = new ConexionBD(); // inicializa tu clase de conexión

            // Asignar eventos a los botones
            button1.Click += button1_Click;
            button2.Click += button2_Click;

            this.Load += FormCrearUsuario_Load;
        }

        private void FormCrearUsuario_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtPassword2.Text = "";
        }

        // Botón Registrar
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string pass1 = txtPassword.Text.Trim();
            string pass2 = txtPassword2.Text.Trim();

            // Validaciones básicas
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(pass1) || string.IsNullOrEmpty(pass2))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Advertencia");
                return;
            }

            if (pass1 != pass2)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error");
                return;
            }

            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    // Cambié los nombres de las columnas para que coincidan con tu tabla
                    string query = "INSERT INTO Usuarios (Usuario, Contrasena) VALUES (@usuario, @contrasena)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", pass1);

                        int resultado = cmd.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Usuario registrado correctamente.", "Éxito");
                            txtUsuario.Clear();
                            txtPassword.Clear();
                            txtPassword2.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar el usuario.", "Error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message, "Error");
            }
        }

        // Botón Cancelar
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
