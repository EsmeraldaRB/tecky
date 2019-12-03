using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TecSystem
{
    public class Conexion
    {
        private SqlConnection conexion = new SqlConnection("server=JADE;DataBase=bdtec2;Integrated Security=true");
        public SqlConnection AbrirConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
                conexion.Open();
            return conexion;

        }
        public SqlConnection CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    }
}
