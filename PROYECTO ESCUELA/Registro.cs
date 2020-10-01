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
   public class Registro
    {
        private conection Conexion = new conection();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;
        public class Calificaciones
        {
            public string Curp { get; set; }
            public string Mes { get; set; }
            public string Español { get; set; }
            public string Matematicas { get; set; }
            public string Nat_y_Soc { get; set; }
            public string Civica { get; set; }
            public string Ed_Fisica { get; set; }
            public string Ed_Artistica { get; set; }
            public string Computacion { get; set; }
            public string Ingles { get; set; }
            //public string EdFisica { get; set; }
            //public string Artes { get; set; }


            public string puntualidad { get; set; }
            public string Ortografia { get; set; }
            public string Disciplina { get; set; }
            public string Uniforme { get; set; }
            public string Puntualidad { get; set; }
            public string Material { get; set; }
            public string Partici { get; set; }
            public string Comp_Lect { get; set; }
            public string Trabajos { get; set; }
            public string Tareas { get; set; }

            public string Lugar { get; set; }

            public string Inasistenicias { get; set; }

            public string Karate { get; set; }

            public string Ballet { get; set; }

            public string Take { get; set; }

            public string Grado { get; set; }

            public string promgen { get; set; }

            public string prosep { get; set; }

            public string promcom { get; set; }

            public string puntos { get; set; }
        }

        public class Vegeta
        {
            public string Curp { get; set; }
            public string Español { get; set; }
            public string Matematicas { get; set; }
            public string Nat_y_Soc { get; set; }
            public string Civica { get; set; }
            public string Ed_Fisica { get; set; }
            public string Ed_Artistica { get; set; }
            public string Computacion { get; set; }
            public string Ingles { get; set; }
            //public string EdFisica { get; set; }
            //public string Artes { get; set; }


            public string puntualidad { get; set; }
            public string Ortografia { get; set; }
            public string Disciplina { get; set; }
            public string Uniforme { get; set; }
            public string Puntualidad { get; set; }
            public string Material { get; set; }
            public string Partici { get; set; }
            public string Comp_Lect { get; set; }
            public string Trabajos { get; set; }
            public string Tareas { get; set; }

            public string Lugar { get; set; }

            public string Inasistenicias { get; set; }

            public string Karate { get; set; }

            public string Ballet { get; set; }

            public string Take { get; set; }

            public string promgen { get; set; }

            public string prosep { get; set; }

            public string promcom { get; set; }

            public string tipobimes { get; set; }

            public string puntos { get; set; }
        }

        public static int CalificaPri(Calificaciones Cali, Registro  cDAlumnos)
        {

            int retorno = 0;

            SqlCommand comando = new SqlCommand(string.Format(
            "Insert into Calificaciones3 (Curp,Mes,Español,Matema,Exnat_Soc,Civica,Ed_Fisica ,Ed_Artis,Computac,Ingles,Ortogrf,Discipl,Uniforme,Puntualid,Material,Partici,Comp_Lec,Trabajos,Tareas,inasis,Grado,Ballet,Takewondo,Karate,promgeneral,prosep,procomp,puntos) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}')",

             Cali.Curp,
             Cali.Mes,
             Cali.Español,
             Cali.Matematicas,
             Cali.Nat_y_Soc,
             Cali.Civica,
             Cali.Ed_Fisica,
             Cali.Ed_Artistica,
             Cali.Computacion,
             Cali.Ingles,
             //Cali.Com,
             //Cali.Ing,

             Cali.Ortografia,
             Cali.Disciplina,
             Cali.Uniforme,
             Cali.Puntualidad,
             Cali.Material,
             Cali.Partici,
             Cali.Comp_Lect,
             Cali.Trabajos,
             Cali.Tareas,
    
             Cali.Inasistenicias,
           Cali.Grado,
             Cali.Ballet,
             Cali.Karate,
             Cali.Take,
             Cali.promgen,
             Cali.prosep,
             Cali.promcom,
             Cali.puntos

             //Cali.Ina
             ), conection.conectar);
            conection.conectar.Open();
            retorno = comando.ExecuteNonQuery();
            conection.conectar.Close();
            return retorno;
        }

        public static int Calificacion(Vegeta Calif)
        {

            int retorno = 0;

            SqlCommand comando = new SqlCommand(string.Format(
            "Insert into Calificaciones2 (Curp,Español,Matema,Exnat_Soc,Civica,Ed_Fisica ,Ed_Artis,Computac,Ingles,Ortogrf,Discipl,Uniforme,Puntualid,Material,Partici,Comp_Lec,Trabajos,Tareas,inasis,Ballet,Takewondo,Karate,promgeneral,prosep,procomp,tipo_bimtre,puntos) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}')",
             Calif.Curp,
             Calif.Español,
             Calif.Matematicas,
             Calif.Nat_y_Soc,
             Calif.Civica,
             Calif.Ed_Fisica,
             Calif.Ed_Artistica,
             Calif.Computacion,
             Calif.Ingles,
             //Cali.Com,
             //Cali.Ing,

             Calif.Ortografia,
             Calif.Disciplina,
             Calif.Uniforme,
             Calif.Puntualidad,
             Calif.Material,
             Calif.Partici,
             Calif.Comp_Lect,
             Calif.Trabajos,
             Calif.Tareas,

             Calif.Inasistenicias,
             Calif.Ballet,
             Calif.Karate,
             Calif.Take,
             Calif.promgen,
             Calif.prosep,
             Calif.promcom,
             Calif.tipobimes,
             Calif.puntos


             ), conection.conectar);
            conection.conectar.Open();
            retorno = comando.ExecuteNonQuery();
            conection.conectar.Close();
            return retorno;
        }


        public class Modifica
        {
            public string Curp { get; set; }
            public string Grado { get; set; }
            public string Mes { get; set; }

            public string Español { get; set; }
            public string Matematicas { get; set; }
            public string Nat_y_Soc { get; set; }
            public string Civica { get; set; }
            public string Ed_Fisica { get; set; }
            public string Ed_Artistica { get; set; }
            public string Computacion { get; set; }
            public string Ingles { get; set; }

            public string Ortografia { get; set; }
            public string Disciplina { get; set; }
            public string Uniforme { get; set; }
            public string Puntualidad { get; set; }
            public string Material { get; set; }
            public string Partici { get; set; }
            public string Comp_Lect { get; set; }
            public string Trabajos { get; set; }
            public string Tareas { get; set; }
            public string Ballet { get; set; }
            public string Karate { get; set; }
            public string Take { get; set; }

            public string Lugar { get; set; }

            public string Inasistenicias { get; set; }
        }
        public static int Modificacion(Modifica Califica)
        {

            int retorno = 0;

            SqlCommand comando = new SqlCommand(string.Format(
            "update Calificaciones1 set Curp='" + Califica.Curp + "',Español='" + Califica.Español + "',Matema='" + Califica.Matematicas + "',Exnat_Soc='" + Califica.Nat_y_Soc + "' , Civica='" + Califica.Civica + "' , Ed_Fisica='" + Califica.Ed_Fisica + "' , Ed_Artis='" + Califica.Ed_Artistica + "',Computac='" + Califica.Computacion + "',Ingles='" + Califica.Ingles + "',Ortogrf='" + Califica.Ortografia + "',Discipl='" + Califica.Disciplina + "',Uniforme='" + Califica.Uniforme + "',Puntualid='" + Califica.Puntualidad + "',Material='" + Califica.Material + "',Partici='" + Califica.Partici + "',Comp_Lec='" + Califica.Comp_Lect + "',Trabajos='" + Califica.Trabajos + "',Tareas='" + Califica.Tareas + "',inasis='" + Califica.Inasistenicias + "',Grado='" + Califica.Grado + "',Ballet='" + Califica.Ballet + "',Takewondo='" + Califica.Take + "',Karate='" + Califica.Karate + "'WHERE Mes='" + Califica.Mes + "'"), conection.conectar);
            conection.conectar.Open();
            retorno = comando.ExecuteNonQuery();
            conection.conectar.Close();
            return retorno;
        }

        //public SqlConnection conectar = new SqlConnection("Data Source = DESKTOP-MIH3BF9\\MSSQLSERVER01;Initial Catalog = ControlEscolar;Integrated Security = true");
        ////public DataSet ds;
        //private ConexionBD conexion = new ConexionBD();
        //private SqlCommand comando = new SqlCommand();
        //private readonly CDUsuarios objDato = new CDUsuarios();
        //private SqlDataReader LeerFilas;


        public void insertarAlumno(string Curp,string Nombre,string Paterno,string Materno,int Edad,string FechaNacimiento,string Grado,string Sexo,string sangre,string Alergia)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "insertaralumno";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Curp", Curp);
            Comando.Parameters.AddWithValue("@Nombre", Nombre);
            Comando.Parameters.AddWithValue("@Paterno", Paterno);
            Comando.Parameters.AddWithValue("@Materno", Materno);
            Comando.Parameters.AddWithValue("@Edad", Edad);
            Comando.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
            Comando.Parameters.AddWithValue("@Grado", Grado);
            Comando.Parameters.AddWithValue("@Sexo", Sexo);
            Comando.Parameters.AddWithValue("@Tipo_Sangre", sangre);
            Comando.Parameters.AddWithValue("@Alergia", Alergia);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
    public void insertartutor (string Curp,string nombre,string paterno,string materno,string correo,string grado_estudios,string calle,string colinia,string lote,string cp,string manzana,String Celular,string Telefono)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "insertartuto";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Curp", Curp);
            Comando.Parameters.AddWithValue("@nombre", nombre);
            Comando.Parameters.AddWithValue("@paterno", paterno);
            Comando.Parameters.AddWithValue("@materno", materno);
            Comando.Parameters.AddWithValue("@correo", correo);
            Comando.Parameters.AddWithValue("@grado_estudios", grado_estudios);
            Comando.Parameters.AddWithValue("@calle", calle);
            Comando.Parameters.AddWithValue("@colinia", colinia);
            Comando.Parameters.AddWithValue("@lote", lote);
            Comando.Parameters.AddWithValue("@cp", cp);
            Comando.Parameters.AddWithValue("@manzana", manzana);
            Comando.Parameters.AddWithValue("@Celular",Celular);
            Comando.Parameters.AddWithValue("@Telefono", Telefono);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }

    public DataTable listaralumno()
        {
            DataTable tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "lista";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return tabla;
        }
        public DataTable Listargrupo()
        {
            DataTable tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "grupo1";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return tabla;
        }
        public DataTable Listargrupo2()
        {
            DataTable tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "grupo2";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return tabla;
        }
        public DataTable Listargrupo3()
        {
            DataTable tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "grupo3";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return tabla;
        }
        public DataTable Listargrupo4 ()
        {
            DataTable tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "grupo4";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return tabla;
        }
        public DataTable Listargrupo5()
        {
            DataTable tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "grupo5";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return tabla;
        }
        public DataTable Listargrupo6()
        {
            DataTable tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "grupo6";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return tabla;
        }

        public void editar(string Curp, string Nombre, string Paterno, string Materno, int Edad, string FechaNacimiento, string Grado, string Sexo,string sangre,string alergia)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "update alumno set Nombre='" + Nombre + "',Paterno='" + Paterno + "',Materno='" + Materno + "',Edad=" + Edad + ",FechaNacimiento='" + FechaNacimiento + "',Grado='" + Grado + "',Sexo='" + Sexo + "',Tipo_Sangre='"+sangre+"',Alergia='"+alergia+"' where Curp='" + Curp+"'";
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }
        public void editartutor(string Curp, string nombres, string paternos, string maternos, string correo, string grado_estudios, string calle, string colinia,string lote,int cp,string manzana,string Celular,string Telefono)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "update Tutor set nombre='" + nombres + "',paterno='" + paternos + "',materno='" + maternos + "',correo='" + correo + "',grado_estudios='" + grado_estudios + "',calle='" + calle + "',colinia='" + colinia + "',lote='" + lote + "',cp=" + cp + ",manzana='" + manzana + "',Celular=" + Celular + ",Telefono=" + Telefono + " where Curp='" + Curp + "'";
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }
        public void eliminarAlum(string Curp)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "delete alumno where Curp='" + Curp + "'"; 
            Comando.CommandType = CommandType.Text; 
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }
        public void eliminartutor(string Curp)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "delete Tutor where Curp='" + Curp + "'";
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }
        public DataTable Buscar(string Nombre)
        {
            Conexion.AbrirConexion();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT alumno.Curp,alumno.Nombre,alumno.Paterno,alumno.Materno,Edad,FechaNacimiento,Grado,Sexo,Tipo_Sangre,Alergia,Tutor.nombre, Tutor.paterno, Tutor.materno, correo, Grado_estudios, calle, colinia, lote, cp, manzana, Celular, Telefono FROM alumno INNER JOIN Tutor ON alumno.curp = Tutor.Curp where alumno.Nombre like '%{0}%'", Nombre),conectar );
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "alumno");
            conectar.Close();
            return ds.Tables["alumno"];
        }
        public DataTable Buscar1 (string Nombre)
        {
            Conexion.AbrirConexion();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT alumno.Curp,alumno.Nombre,alumno.Paterno,alumno.Materno,Edad,FechaNacimiento,Grado,Sexo,Tipo_Sangre,Alergia FROM alumno" ), conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "alumno");
            conectar.Close();
            return ds.Tables["alumno"];
        }
        public SqlConnection conectar = new SqlConnection("Server=ANGELHDZS; DataBase=Control_Escolar1; integrated Security=true");
        public DataSet ds;
        public bool Existe(string nombre)
        {
            {
                conectar.Close();
                string query = "SELECT COUNT(*) FROM alumno WHERE Curp=@Curp";
                SqlCommand cmd = new SqlCommand(query, conectar);
                cmd.Parameters.AddWithValue("curp", nombre);
                conectar.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                    return false;
                else
                    return true;
            }
        }
    }

}
