using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Menu_Especial
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Server=localhost\SQLEXPRESS;Database=menuUsuarios;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = inputUser.Text;
            string contrasena = inputPassword.Text;

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario=@usuario AND Contrasena=@contrasena";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("✅ Bienvenido " + usuario);

                        // Pasamos el nombre de usuario al formulario Menu
                        Menu formPrincipal = new Menu(usuario);
                        formPrincipal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("❌ Usuario o contraseña incorrectos");
                        inputPassword.Clear();
                        inputUser.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
