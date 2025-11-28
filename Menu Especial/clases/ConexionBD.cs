using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Especial.clases
{
    internal class ConexionBD
    {
        private readonly string connectionString = @"Server=localhost\SQLEXPRESS;Database=menuUsuarios;Trusted_Connection=True;";
        private SqlConnection con;

        public SqlConnection AbrirConexion()
        {
            con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }

        public void CerrarConexion()
        {
            if (con != null && con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
    }
}
