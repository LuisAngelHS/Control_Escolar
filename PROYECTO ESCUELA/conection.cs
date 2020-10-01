using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PROYECTO_ESCUELA
{
   public class conection
    {
        static public SqlConnection conectar = new SqlConnection("Server=ANGELHDZS; DataBase=Control_Escolar1; integrated Security=true");
        static private string cadenaConexion = "Server=ANGELHDZS; DataBase=Control_Escolar1; integrated Security=true";
        private SqlConnection conexion  = new SqlConnection(cadenaConexion);
        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;  
        }
        public  SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
        public static SqlConnection obtenerConexion()
        {
            SqlConnection conectar = new SqlConnection("Server=ANGELHDZS; DataBase=Control_Escolar1; integrated Security=true");
            conectar.Open();
            return conectar;
        }
       
    }
}
