using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PROYECTO_ESCUELA;

namespace PROYECTO_ESCUELA
{
   public  class usuario1
    {
        private usuarios ObjUsuarios = new usuarios ();
        private string Usuario;
        private string Contraseña;

        public string _Usuario
        {
            set
            {
                if (value == "USUARIO")
                {
                    Usuario = "No ha ingresado ningun usuario";
                }
                else { Usuario = value; }
            }
            get { return Usuario; }
        }

        public string _Contraseña
        {
            set
            {
                if (value == "CONTRASEÑA")
                {
                    Contraseña = "No ha ingresado ninguna contraseña";
                }
                else { Contraseña = value; }
            }
            get { return Contraseña; }
        }
        public usuario1 () { }

        public SqlDataReader iniciarsesion()
        {
            SqlDataReader Loguear;
            Loguear = ObjUsuarios.iniciarsesion(_Usuario, _Contraseña);
            return Loguear;
        }
    }
}
