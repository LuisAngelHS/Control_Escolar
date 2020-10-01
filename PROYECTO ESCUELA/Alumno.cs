using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PROYECTO_ESCUELA
{
   public  class Alumno
    {
        
    }

    public class llenadomes
    {
        // Paso 1
        // son identicos a los que estan en la base de datos
        public string IdAlumnoPre { get; set; }
        public string IdMaterias { get; set; }
        public string Calificacion { get; set; }
        public string NombreMes { get; set; }

        public llenadomes() { }
        public llenadomes(string pIdAlumnoPre, string pIdMaterias, string pCalificacion, string pNombreMes)
        {
            this.IdAlumnoPre = pIdAlumnoPre;
            this.IdMaterias = pIdMaterias;
            this.Calificacion = pCalificacion;
            this.NombreMes = pNombreMes;
        }

    }
    public class Calificaciongral1
    {
        public string IdAlumnoPre { get; set; }
        public string PromedioGeneral { get; set; }
        public string TotalPuntos { get; set; }
        public string Inasistencias { get; set; }
        public string NombreMes { get; set; }

        public Calificaciongral1() { }
        public Calificaciongral1(string pIdAlumnoPre, string pPromedioGeneral, string pTotalPuntos, string pInasistencias, string pNombreMes)
        {
            this.IdAlumnoPre = pIdAlumnoPre;
            this.PromedioGeneral = pPromedioGeneral;
            this.TotalPuntos = pTotalPuntos;
            this.Inasistencias = pInasistencias;
            this.NombreMes = pNombreMes;

        }
    }
    class calificacionalta
    {
        public static int Agregarcalif(llenadomes pCalifica)
        {
            conection a = new conection();
            int retorno1 = 0;

            using (SqlConnection conn = a.AbrirConexion()) 
            {
                // paso 2
                // Conexion e insercion de datos en la tabla de calificaciones
                SqlCommand comando = new SqlCommand(String.Format("insert into CalificacionMensual(IdAlumnoPre,IdMaterias,Calificacion,NombreMes) values('{0}','{1}','{2}','{3}') ",
                    pCalifica.IdAlumnoPre, pCalifica.IdMaterias, pCalifica.Calificacion, pCalifica.NombreMes), conn);
                retorno1 = comando.ExecuteNonQuery();
            }
            return retorno1;
        }
    }
    public class promediomes
    {
        public string IdAlumnoPre { get; set; }
        public string Calificacion { get; set; }
        public string NombreMes { get; set; }

        public promediomes() { }
        public promediomes(string pIdAlumnoPre, string pCalificacion, string pNombreMes)
        {
            this.IdAlumnoPre = pIdAlumnoPre;
            this.Calificacion = pCalificacion;
            this.NombreMes = pNombreMes;

        }
    }
    public class promediomescomp
    {
        public string IdAlumnoPre { get; set; }
        public string CalificacionComp { get; set; }
        public string NombreMes { get; set; }

        public promediomescomp() { }
        public promediomescomp(string pIdAlumnoPre, string pCalificacionComp, string pNombreMes)
        {
            this.IdAlumnoPre = pIdAlumnoPre;
            this.CalificacionComp = pCalificacionComp;
            this.NombreMes = pNombreMes;

        }
    }
    public class llenadopres
    {
        public int IdAlumnoPrees { get; set; }
        public string IdMaterias { get; set; }
        public string Calificacion { get; set; }
        public string NombreMes { get; set; }
        public string Inasistencias { get; set; }

        public llenadopres() { }

        public llenadopres(int pIdAlumnoPrees, string pIdMaterias, string pCalificacion, string pNombreMes, string pInasistencias)
        {
            this.IdAlumnoPrees = pIdAlumnoPrees;
            this.IdMaterias = pIdMaterias;
            this.Calificacion = pCalificacion;
            this.NombreMes = pNombreMes;
            this.Inasistencias = pInasistencias;
        }
    }
    class Calificaciongral
    {
        public static int Calificaciongral1(Calificaciongral1 pPromediogeneral)
        {
            int retorno4 = 0;
            conection a = new conection();

            using (SqlConnection conn = a.AbrirConexion())
            {
                SqlCommand comando = new SqlCommand(String.Format("insert into PromedioGeneral(IdAlumnoPre,PromedioGeneral,TotalPuntos,Inasistencias,NombreMes) values('{0}','{1}','{2}','{3}','{4}') ",
                        pPromediogeneral.IdAlumnoPre, pPromediogeneral.PromedioGeneral, pPromediogeneral.TotalPuntos, pPromediogeneral.Inasistencias, pPromediogeneral.NombreMes), conn);
                retorno4 = comando.ExecuteNonQuery();
                //retorno2 = comando.ExecuteNonQuery();
            }
            return retorno4;
        }
    }
    class promediomensual
    {
        public static int Promediomes(promediomes pPromediomes)
        {
            conection a = new conection();
            int retorno2 = 0;
            using (SqlConnection conn = a.AbrirConexion())
            {
                SqlCommand comando = new SqlCommand(String.Format("insert into PromedioMensual(IdAlumnoPre,Calificacion,NombreMes) values('{0}','{1}','{2}') ",
                        pPromediomes.IdAlumnoPre, pPromediomes.Calificacion, pPromediomes.NombreMes), conn);
                retorno2 = comando.ExecuteNonQuery();
                //retorno2 = comando.ExecuteNonQuery();
            }
            return retorno2;
        }
    }
    class promediomensualcomp
    {
        public static int Promediomescomp(promediomescomp pPromediomescomp)
        {
            int retorno3 = 0;
            conection a = new conection();
            using (SqlConnection conn = a.AbrirConexion())
            {
                SqlCommand comando = new SqlCommand(String.Format("insert into PromedioMensualComp(IdAlumnoPre,CalificacionComp,NombreMes) values('{0}','{1}','{2}') ",
                        pPromediomescomp.IdAlumnoPre, pPromediomescomp.CalificacionComp, pPromediomescomp.NombreMes), conn);
                retorno3 = comando.ExecuteNonQuery();
                //retorno2 = comando.ExecuteNonQuery();
            }
            return retorno3;
        }
    }

}
