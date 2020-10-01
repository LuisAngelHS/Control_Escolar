using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PROYECTO_ESCUELA
{
    public  class usuarios
    {
        private conection Conexion = new conection();
        private SqlDataReader leer;

        public SqlDataReader iniciarsesion(string user, string pass)
        {
            string sql = "select*from usuarios where NombreUsuario='" + user + "' and Contrasenia='" + pass + "'";
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = sql;
            leer = comando.ExecuteReader();
            return leer;
        }
    }
}
