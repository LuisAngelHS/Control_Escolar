using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text; //Para lo del pdf
using iTextSharp.text.pdf;
using System.Net.Mail; //Para lo del correo
using System.Net.Mime;
using static PROYECTO_ESCUELA.Registro;
using System.IO;

namespace PROYECTO_ESCUELA
{
    public partial class BOLETA : Form
    {
        public BOLETA()
        {
            InitializeComponent();
        }

        public Registro objproducto = new Registro();
        public SqlConnection conectar = new SqlConnection("Server=ANGELHDZS; DataBase=Control_Escolar1; integrated Security=true");
        public DataSet ds;
        private conection conexion = new conection();
        private SqlCommand comando = new SqlCommand();
        //private readonly CDUsuarios objDato = new CDUsuarios();
        //private SqlDataReader leer;
        Registro sql = new Registro();
        private string To;
        private string Subject;
        private string Body;
        private MailMessage mail;
        private Attachment Data;
        private Bitmap bmp;
        Vegeta trons = new Vegeta();


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            comando.Connection = conexion.AbrirConexion();
            SqlCommand cmd = new SqlCommand("Boletas", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Curp", txtbuscador.Text);
            conectar.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtpaterno.Text = Convert.ToString(reader["Paterno"]);
                txtmaterno.Text = Convert.ToString(reader["Materno"]);
                txtnombre.Text = Convert.ToString(reader["Nombre"]);

                txtnombrecomplet.Text = txtpaterno.Text + " " + txtmaterno.Text + " " + txtnombre.Text;
                txtgrado.Text = Convert.ToString(reader["Grado"]);
            }
            conectar.Close();

            conectar.Open();

            SqlCommand Dia = new SqlCommand("select * from Calificaciones3 where Curp = '" + txtbuscador.Text + "' and Mes = 'Diagnostico'", conectar);

            SqlDataReader Diag = Dia.ExecuteReader();
            if (Diag.Read() == true)
            {
                TD1.Text = Diag["Español"].ToString();
                TD2.Text = Diag["Matema"].ToString();
                TD3.Text = Diag["Exnat_Soc"].ToString();
                TD4.Text = Diag["Civica"].ToString();
                TD5.Text = Diag["Ed_Fisica"].ToString();
                TD6.Text = Diag["Ed_Artis"].ToString();
                TD7.Text = Diag["Computac"].ToString();
                TD8.Text = Diag["Ingles"].ToString();

                TD10.Text = Diag["Ortogrf"].ToString();
                TD11.Text = Diag["Discipl"].ToString();
                TD12.Text = Diag["Uniforme"].ToString();
                TD13.Text = Diag["Puntualid"].ToString();
                TD14.Text = Diag["Material"].ToString();
                TD15.Text = Diag["Partici"].ToString();
                TD16.Text = Diag["Comp_Lec"].ToString();
                TD17.Text = Diag["Trabajos"].ToString();
                TD18.Text = Diag["Tareas"].ToString();
                txt1.Text = Diag["karate"].ToString();
                txt2.Text = Diag["Ballet"].ToString();
                txt3.Text = Diag["Takewondo"].ToString();
                TD23.Text = Diag["inasis"].ToString();
            }

            conectar.Close();

            conectar.Open();

            SqlCommand Sep = new SqlCommand("select * from Calificaciones3 where Curp = '" + txtbuscador.Text + "' and Mes = 'Septiembre'", conectar);

            SqlDataReader Sept = Sep.ExecuteReader();
            if (Sept.Read() == true)
            {
                TS1.Text = Sept["Español"].ToString();
                TS2.Text = Sept["Matema"].ToString();
                TS3.Text = Sept["Exnat_Soc"].ToString();
                TS4.Text = Sept["Civica"].ToString();
                TS5.Text = Sept["Ed_Fisica"].ToString();
                TS6.Text = Sept["Ed_Artis"].ToString();
                TS7.Text = Sept["Computac"].ToString();
                TS8.Text = Sept["Ingles"].ToString();

                TS10.Text = Sept["Ortogrf"].ToString();
                TS11.Text = Sept["Discipl"].ToString();
                TS12.Text = Sept["Uniforme"].ToString();
                TS13.Text = Sept["Puntualid"].ToString();
                TS14.Text = Sept["Material"].ToString();
                TS15.Text = Sept["Partici"].ToString();
                TS16.Text = Sept["Comp_Lec"].ToString();
                TS17.Text = Sept["Trabajos"].ToString();
                TS18.Text = Sept["Tareas"].ToString();
                txt6.Text = Sept["Takewondo"].ToString();
                txt5.Text = Sept["Ballet"].ToString();
                txt4.Text = Sept["Karate"].ToString();
                TS23.Text = Sept["inasis"].ToString();
            }

            conectar.Close();

            conectar.Open();

            SqlCommand Oct = new SqlCommand("select * from Calificaciones3 where Curp = '" + txtbuscador.Text + "' and Mes = 'Octubre'", conectar);

            SqlDataReader Octu = Oct.ExecuteReader();
            if (Octu.Read() == true)
            {
                TO1.Text = Octu["Español"].ToString();
                TO2.Text = Octu["Matema"].ToString();
                TO3.Text = Octu["Exnat_Soc"].ToString();
                TO4.Text = Octu["Civica"].ToString();
                TO5.Text = Octu["Ed_Fisica"].ToString();
                TO6.Text = Octu["Ed_Artis"].ToString();
                TO7.Text = Octu["Computac"].ToString();
                TO8.Text = Octu["Ingles"].ToString();

                T10.Text = Octu["Ortogrf"].ToString();
                TO11.Text = Octu["Discipl"].ToString();
                TO12.Text = Octu["Uniforme"].ToString();
                TO13.Text = Octu["Puntualid"].ToString();
                TO14.Text = Octu["Material"].ToString();
                TO15.Text = Octu["Partici"].ToString();
                TO16.Text = Octu["Comp_Lec"].ToString();
                TO17.Text = Octu["Trabajos"].ToString();
                TO18.Text = Octu["Tareas"].ToString();
                txt8.Text = Octu["Ballet"].ToString();
                txt9.Text = Octu["Takewondo"].ToString();
                txt7.Text = Octu["Karate"].ToString();
                TO23.Text = Octu["inasis"].ToString();

            }

            conectar.Close();

            conectar.Open();

            SqlCommand Nov = new SqlCommand("select * from Calificaciones3 where Curp = '" + txtbuscador.Text + "' and Mes = 'Noviembre'", conectar);

            SqlDataReader Novi = Nov.ExecuteReader();
            if (Novi.Read() == true)
            {
                TN1.Text = Novi["Español"].ToString();
                TN2.Text = Novi["Matema"].ToString();
                TN3.Text = Novi["Exnat_Soc"].ToString();
                TN4.Text = Novi["Civica"].ToString();
                TN5.Text = Novi["Ed_Fisica"].ToString();
                TN6.Text = Novi["Ed_Artis"].ToString();
                TN7.Text = Novi["Computac"].ToString();
                TN8.Text = Novi["Ingles"].ToString();

                TN10.Text = Novi["Ortogrf"].ToString();
                TN11.Text = Novi["Discipl"].ToString();
                TN12.Text = Novi["Uniforme"].ToString();
                TN13.Text = Novi["Puntualid"].ToString();
                TN14.Text = Novi["Material"].ToString();
                TN15.Text = Novi["Partici"].ToString();
                TN16.Text = Novi["Comp_Lec"].ToString();
                TN17.Text = Novi["Trabajos"].ToString();
                TN18.Text = Novi["Tareas"].ToString();
                txt11.Text = Novi["Ballet"].ToString();
                txt12.Text = Novi["Takewondo"].ToString();
                txt10.Text = Novi["Karate"].ToString();
                TN23.Text = Novi["inasis"].ToString();

            }

            conectar.Close();

            conectar.Open();

            SqlCommand Dic = new SqlCommand("select * from Calificaciones3 where Curp = '" + txtbuscador.Text + "' and Mes = 'Diciembre'", conectar);

            SqlDataReader Dici = Dic.ExecuteReader();
            if (Dici.Read() == true)
            {
                TDD1.Text = Dici["Español"].ToString();
                TDD2.Text = Dici["Matema"].ToString();
                TDD3.Text = Dici["Exnat_Soc"].ToString();
                TDD4.Text = Dici["Civica"].ToString();
                TDD5.Text = Dici["Ed_Fisica"].ToString();
                TDD6.Text = Dici["Ed_Artis"].ToString();
                TDD7.Text = Dici["Computac"].ToString();
                TDD8.Text = Dici["Ingles"].ToString();

                TDD10.Text = Dici["Ortogrf"].ToString();
                TDD11.Text = Dici["Discipl"].ToString();
                TDD12.Text = Dici["Uniforme"].ToString();
                TDD13.Text = Dici["Puntualid"].ToString();
                TDD14.Text = Dici["Material"].ToString();
                TDD15.Text = Dici["Partici"].ToString();
                TDD16.Text = Dici["Comp_Lec"].ToString();
                TDD17.Text = Dici["Trabajos"].ToString();
                TDD18.Text = Dici["Tareas"].ToString();
                txt14.Text = Dici["Ballet"].ToString();
                txt15.Text = Dici["Takewondo"].ToString();
                txt13.Text = Dici["Karate"].ToString();
                TDD23.Text = Dici["inasis"].ToString();

            }

            conectar.Close();

            conectar.Open();

            SqlCommand Ene = new SqlCommand("select * from Calificaciones3 where Curp = '" + txtbuscador.Text + "' and Mes = 'Enero'", conectar);

            SqlDataReader Ener = Ene.ExecuteReader();
            if (Ener.Read() == true)
            {
                TE1.Text = Ener["Español"].ToString();
                TE2.Text = Ener["Matema"].ToString();
                TE3.Text = Ener["Exnat_Soc"].ToString();
                TE4.Text = Ener["Civica"].ToString();
                TE5.Text = Ener["Ed_Fisica"].ToString();
                TE6.Text = Ener["Ed_Artis"].ToString();
                TE7.Text = Ener["Computac"].ToString();
                TE8.Text = Ener["Ingles"].ToString();

                TE10.Text = Ener["Ortogrf"].ToString();
                TE11.Text = Ener["Discipl"].ToString();
                TE12.Text = Ener["Uniforme"].ToString();
                TE13.Text = Ener["Puntualid"].ToString();
                TE14.Text = Ener["Material"].ToString();
                TE15.Text = Ener["Partici"].ToString();
                TE16.Text = Ener["Comp_Lec"].ToString();
                TE17.Text = Ener["Trabajos"].ToString();
                TE18.Text = Ener["Tareas"].ToString();
                txt17.Text = Ener["Ballet"].ToString();
                txt18.Text = Ener["Takewondo"].ToString();
                txt16.Text = Ener["Karate"].ToString();
                TE23.Text = Ener["inasis"].ToString();
            }

            conectar.Close();

            conectar.Open();

            SqlCommand Feb = new SqlCommand("select * from Calificaciones3 where Curp = '" + txtbuscador.Text + "' and Mes = 'Febrero'", conectar);

            SqlDataReader Febr = Feb.ExecuteReader();
            if (Febr.Read() == true)
            {
                TF1.Text = Febr["Español"].ToString();
                TF2.Text = Febr["Matema"].ToString();
                TF3.Text = Febr["Exnat_Soc"].ToString();
                TF4.Text = Febr["Civica"].ToString();
                TF5.Text = Febr["Ed_Fisica"].ToString();
                TF6.Text = Febr["Ed_Artis"].ToString();
                TF7.Text = Febr["Computac"].ToString();
                TF8.Text = Febr["Ingles"].ToString();

                TF10.Text = Febr["Ortogrf"].ToString();
                TF11.Text = Febr["Discipl"].ToString();
                TF12.Text = Febr["Uniforme"].ToString();
                TF13.Text = Febr["Puntualid"].ToString();
                TF14.Text = Febr["Material"].ToString();
                TF15.Text = Febr["Partici"].ToString();
                TF16.Text = Febr["Comp_Lec"].ToString();
                TF17.Text = Febr["Trabajos"].ToString();
                TF18.Text = Febr["Tareas"].ToString();
                textBox32.Text = Febr["Ballet"].ToString();
                textBox33.Text = Febr["Takewondo"].ToString();
                textBox31.Text = Febr["Karate"].ToString();
                TF23.Text = Febr["inasis"].ToString();
            }

            conectar.Close();

            conectar.Open();

            SqlCommand Mar = new SqlCommand("select * from Calificaciones3 where Curp = '" + txtbuscador.Text + "' and Mes = 'Marzo' and Grado = '" + txtgrado.Text + "' ", conectar);

            SqlDataReader Marz = Mar.ExecuteReader();
            if (Marz.Read() == true)
            {
                TM1.Text = Marz["Español"].ToString();
                TM2.Text = Marz["Matema"].ToString();
                TM3.Text = Marz["Exnat_Soc"].ToString();
                TM4.Text = Marz["Civica"].ToString();
                TM5.Text = Marz["Ed_Fisica"].ToString();
                TM6.Text = Marz["Ed_Artis"].ToString();
                TM7.Text = Marz["Computac"].ToString();
                TM8.Text = Marz["Ingles"].ToString();


                TM10.Text = Marz["Ortogrf"].ToString();
                TM11.Text = Marz["Discipl"].ToString();
                TM12.Text = Marz["Uniforme"].ToString();
                TM13.Text = Marz["Puntualid"].ToString();
                TM14.Text = Marz["Material"].ToString();
                TM15.Text = Marz["Partici"].ToString();
                TM16.Text = Marz["Comp_Lec"].ToString();
                TM17.Text = Marz["Trabajos"].ToString();
                TM18.Text = Marz["Tareas"].ToString();
                textBox29.Text = Marz["Ballet"].ToString();
                textBox30.Text = Marz["Takewondo"].ToString();
                textBox28.Text = Marz["Karate"].ToString();
                TM23.Text = Marz["inasis"].ToString();

            }

            conectar.Close();

            conectar.Open();

            SqlCommand Abr = new SqlCommand("select * from Calificaciones3 where Curp = '" + txtbuscador.Text + "' and Mes = 'Abril'", conectar);

            SqlDataReader Abri = Abr.ExecuteReader();
            if (Abri.Read() == true)
            {
                TA1.Text = Abri["Español"].ToString();
                TA2.Text = Abri["Matema"].ToString();
                TA3.Text = Abri["Exnat_Soc"].ToString();
                TA4.Text = Abri["Civica"].ToString();
                TA5.Text = Abri["Ed_Fisica"].ToString();
                TA6.Text = Abri["Ed_Artis"].ToString();
                TA7.Text = Abri["Computac"].ToString();
                TA8.Text = Abri["Ingles"].ToString();


                TA10.Text = Abri["Ortogrf"].ToString();
                TA11.Text = Abri["Discipl"].ToString();
                TA12.Text = Abri["Uniforme"].ToString();
                TA13.Text = Abri["Puntualid"].ToString();
                TA14.Text = Abri["Material"].ToString();
                TA15.Text = Abri["Partici"].ToString();
                TA16.Text = Abri["Comp_Lec"].ToString();
                TA17.Text = Abri["Trabajos"].ToString();
                TA18.Text = Abri["Tareas"].ToString();
                textBox26.Text = Abri["Ballet"].ToString();
                textBox27.Text = Abri["Takewondo"].ToString();
                textBox25.Text = Abri["Karate"].ToString();
                TA23.Text = Abri["inasis"].ToString();

                //TxBAbrIna.Text = Abri["Ina"].ToString();
            }

            conectar.Close();

            conectar.Open();

            SqlCommand May = new SqlCommand("select * from Calificaciones3 where Curp = '" + txtbuscador.Text + "' and Mes = 'Mayo'", conectar);

            SqlDataReader Mayo = May.ExecuteReader();
            if (Mayo.Read() == true)
            {
                TMA1.Text = Mayo["Español"].ToString();
                TMA2.Text = Mayo["Matema"].ToString();
                TMA3.Text = Mayo["Exnat_Soc"].ToString();
                TMA4.Text = Mayo["Civica"].ToString();
                TMA5.Text = Mayo["Ed_Fisica"].ToString();
                TMA6.Text = Mayo["Ed_Artis"].ToString();
                TMA7.Text = Mayo["Computac"].ToString();
                TMA8.Text = Mayo["Ingles"].ToString();

                TMA10.Text = Mayo["Ortogrf"].ToString();
                TMA11.Text = Mayo["Discipl"].ToString();
                TMA12.Text = Mayo["Uniforme"].ToString();
                TMA13.Text = Mayo["Puntualid"].ToString();
                TMA14.Text = Mayo["Material"].ToString();
                TMA15.Text = Mayo["Partici"].ToString();
                TMA16.Text = Mayo["Comp_Lec"].ToString();
                TMA17.Text = Mayo["Trabajos"].ToString();
                TMA18.Text = Mayo["Tareas"].ToString();
                textBox23.Text = Mayo["Ballet"].ToString();
                textBox24.Text = Mayo["Takewondo"].ToString();
                textBox22.Text = Mayo["Karate"].ToString();
                TMA23.Text = Mayo["inasis"].ToString();
            }

            conectar.Close();

            conectar.Open();

            SqlCommand Jun = new SqlCommand("select * from Calificaciones3 where Curp = '" + txtbuscador.Text + "' and Mes = 'Junio'", conectar);

            SqlDataReader Juni = Jun.ExecuteReader();
            if (Juni.Read() == true)
            {
                TJ1.Text = Juni["Español"].ToString();
                TJ2.Text = Juni["Matema"].ToString();
                TJ3.Text = Juni["Exnat_Soc"].ToString();
                TJ4.Text = Juni["Civica"].ToString();
                TJ5.Text = Juni["Ed_Fisica"].ToString();
                TJ6.Text = Juni["Ed_Artis"].ToString();
                TJ7.Text = Juni["Computac"].ToString();
                TJ8.Text = Juni["Ingles"].ToString();

                TJ10.Text = Juni["Ortogrf"].ToString();
                TJ11.Text = Juni["Discipl"].ToString();
                TJ12.Text = Juni["Uniforme"].ToString();
                TJ13.Text = Juni["Puntualid"].ToString();
                TJ14.Text = Juni["Material"].ToString();
                TJ15.Text = Juni["Partici"].ToString();
                TJ16.Text = Juni["Comp_Lec"].ToString();
                TJ17.Text = Juni["Trabajos"].ToString();
                TJ18.Text = Juni["Tareas"].ToString();
                textBox20.Text = Juni["Ballet"].ToString();
                textBox21.Text = Juni["Takewondo"].ToString();
                textBox19.Text = Juni["Karate"].ToString();
                TJ23.Text = Juni["inasis"].ToString();

            }
            conectar.Close();

        }
        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtgrado_TextChanged(object sender, EventArgs e)
        {
            if (txtgrado.Text == "1°A")
            {
                String total;
                total = "ESPAÑOL";
                lbmate1.Text = total.ToString();
                total = "MATEMATICAS";
                lbmate2.Text = total.ToString();
                total = "EXP. DE LA NAT. Y SOC.";
                lbmate3.Text = total.ToString();
                total = "FORMACIÓN CIV. Y ET.";
                lbmate4.Text = total.ToString();
                total = "ED. FISICA";
                lbmate5.Text = total.ToString();
                total = "ED. ARTISTICA";
                lbmate6.Text = total.ToString();
                total = "COMPUTACION";
                lbmate7.Text = total.ToString();
                total = "INGLES";
                lbmate8.Text = total.ToString();
            }
            if (txtgrado.Text == "2°A")
            {
                String total;
                total = "ESPAÑOL";
                lbmate1.Text = total.ToString();
                total = "MATEMATICAS";
                lbmate2.Text = total.ToString();
                total = "EXP. DE LA NAT. Y SOC.";
                lbmate3.Text = total.ToString();
                total = "FORMACIÓN CIV. Y ET.";
                lbmate4.Text = total.ToString();
                total = "ED. FISICA";
                lbmate5.Text = total.ToString();
                total = "ED. ARTISTICA";
                lbmate6.Text = total.ToString();
                total = "COMPUTACION";
                lbmate7.Text = total.ToString();
                total = "INGLES";
                lbmate8.Text = total.ToString();
            }

            if (txtgrado.Text == "3°A")
            {
                String total;
                total = "ESPAÑOL";
                lbmate1.Text = total.ToString();
                total = "MATEMATICAS";
                lbmate2.Text = total.ToString();
                total = "CIENCIAS NATURALES";
                lbmate3.Text = total.ToString();
                total = "LA ENTIDAD DONDE VIVO";
                lbmate4.Text = total.ToString();
                total = "FORMACIÓN CIV.Y ET.";
                lbmate5.Text = total.ToString();
                total = "ED. FISICA";
                lbmate6.Text = total.ToString();
                total = "ED. ARTISTICA";
                lbmate7.Text = total.ToString();
                total = "COMPUTACIÓN";
                lbmate8.Text = total.ToString();
            }
            if (txtgrado.Text == "4°A" || txtgrado.Text == "5°A" || txtgrado.Text == "6°A")
            {
                String total;
                total = "ESPAÑOL";
                lbmate1.Text = total.ToString();
                total = "MATEMATICAS";
                lbmate2.Text = total.ToString();
                total = "CIENCIAS NATURALES";
                lbmate3.Text = total.ToString();
                total = "GEOGRAFIA";
                lbmate4.Text = total.ToString();
                total = "HISTORIA";
                lbmate5.Text = total.ToString();
                total = "FORMACIÓN CIV.Y ET.";
                lbmate6.Text = total.ToString();
                total = "ED. ARTISTICA";
                lbmate7.Text = total.ToString();
                total = "ED. ARTISTICA";
                lbmate8.Text = total.ToString();
            }

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Calificaciones Califica = new Calificaciones();
            Registro cDAlumnos = new Registro();

            if (CBMes.Text == "" || txtbuscador.Text == "")
            {
                MessageBox.Show("buscar un alumno y seleccionar un mes", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //Subir calificaciones de DIAGNOSTICO
                if (CBMes.Text == "DIAGNOSTICO")
                {

                    if (TD1.Text == "" || TD2.Text == "" || TD3.Text == "" || TD4.Text == "" || TD5.Text == "" || TD6.Text == ""
                        || TD7.Text == "" || TD8.Text == "" || TD10.Text == "" || TD11.Text == "" || TD12.Text == "" ||
                        TD13.Text == "" || TD14.Text == "" || TD15.Text == "" || TD16.Text == "" || TD17.Text == "" || TD18.Text == "" || txt1.Text == "" || txt2.Text == "" || txt3.Text == "")
                    {
                        MessageBox.Show("ESPACIO EN BLANCO, LLENARLO ANTES DE GUARDAR", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Califica.Curp = txtbuscador.Text;
                        Califica.Mes = "DIAGNOSTICO";
                        Califica.Español = TD1.Text;
                        Califica.Matematicas = TD2.Text;
                        Califica.Nat_y_Soc = TD3.Text;
                        Califica.Civica = TD4.Text;
                        Califica.Ed_Fisica = TD5.Text;
                        Califica.Ed_Artistica = TD6.Text;
                        Califica.Computacion = TD7.Text;
                        Califica.Ingles = TD8.Text;

                        Califica.Ortografia = TD10.Text;
                        Califica.Disciplina = TD11.Text;
                        Califica.Uniforme = TD12.Text;
                        Califica.Puntualidad = TD13.Text;
                        Califica.Material = TD14.Text;
                        Califica.Partici = TD15.Text;
                        Califica.Comp_Lect = TD16.Text;
                        Califica.Trabajos = TD17.Text;
                        Califica.Tareas = TD18.Text;
                        //Califica.Inasistenicias = TD23.Text;
                        Califica.Grado = txtgrado.Text;
                        Califica.Karate = txt1.Text;
                        Califica.Ballet = txt2.Text;
                        Califica.Take = txt3.Text;
                        Califica.Inasistenicias = TD23.Text;
                        Califica.prosep = TD9.Text;
                        Califica.promcom = TD19.Text;
                        Califica.promgen = TD20.Text;
                        Califica.puntos = TD21.Text;



                        int resultado = CalificaPri(Califica, cDAlumnos);
                        if (resultado > 0)
                        {
                            MessageBox.Show("Calificacion GuardadA!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CBMes.Visible = true;
                            label6.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el la Calificacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        };
                    }
                }

                //Subir calificaciones de SEPTIEMBRE
                if (CBMes.Text == "SEPTIEMBRE")
                {


                    if (TS1.Text == "" || TS2.Text == "" || TS3.Text == "" || TS6.Text == "" || TS7.Text == "" || TS8.Text == "" ||
                         TS10.Text == "" || TS11.Text == "" || TS12.Text == "" || TS13.Text == "" || TS14.Text == "" ||
                        TS15.Text == "" || TS16.Text == "" || TS17.Text == "" || TS18.Text == "" || TS23.Text == "" || txt4.Text == "" || txt5.Text == "" || txt6.Text == "")
                    {
                        MessageBox.Show("UN CAMPO ESTA VACIO, DEBE DE LLENARLO ANTES DE CONTINUAR", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Califica.Curp = txtbuscador.Text;
                        Califica.Mes = "SEPTIEMBRE";
                        Califica.Grado = txtgrado.Text;

                        Califica.Español = TS1.Text;
                        Califica.Matematicas = TS2.Text;
                        Califica.Nat_y_Soc = TS3.Text;
                        Califica.Civica = TS4.Text;
                        Califica.Ed_Fisica = TS5.Text;
                        Califica.Ed_Artistica = TS6.Text;
                        Califica.Computacion = TS7.Text;
                        Califica.Ingles = TS8.Text;

                        Califica.Ortografia = TS10.Text;
                        Califica.Disciplina = TS11.Text;
                        Califica.Uniforme = TS12.Text;
                        Califica.Puntualidad = TS13.Text;
                        Califica.Material = TS14.Text;
                        Califica.Partici = TS15.Text;
                        Califica.Comp_Lect = TS16.Text;
                        Califica.Trabajos = TS17.Text;
                        Califica.Tareas = TS18.Text;
                        Califica.Karate = txt4.Text;
                        Califica.Ballet = txt5.Text;
                        Califica.Take = txt6.Text;
                        Califica.Inasistenicias = TS23.Text;
                        Califica.prosep = TS9.Text;
                        Califica.promcom = TS19.Text;
                        Califica.promgen = TS20.Text;
                        Califica.puntos = TS21.Text;

                        int resultado = CalificaPri(Califica, cDAlumnos);
                        if (resultado > 0)
                        {
                            MessageBox.Show("Calificacion GuardadA!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CBMes.Visible = true;
                            label6.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el la Calificacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        };
                    }
                }

                //Subir calificaciones de OCTUBRE
                if (CBMes.Text == "OCTUBRE")
                {

                    if (TO1.Text == "" || TO2.Text == "" || TO3.Text == "" || TO6.Text == "" || TO7.Text == "" || TO8.Text == "" ||
                        T10.Text == "" || TO11.Text == "" || TO12.Text == "" || TO13.Text == "" || TO14.Text == "" ||
                        TO15.Text == "" || TO16.Text == "" || TO17.Text == "" || TO18.Text == "" || TO23.Text == "")
                    {
                        MessageBox.Show("UN CAMPO ESTA VACIO, DEBE DE LLENARLO ANTES DE CONTINUAR", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Califica.Curp = txtbuscador.Text;
                        Califica.Mes = "OCTUBRE";
                        Califica.Grado = txtgrado.Text;

                        Califica.Español = TO1.Text;
                        Califica.Matematicas = TO2.Text;
                        Califica.Nat_y_Soc = TO3.Text;
                        Califica.Civica = TO4.Text;
                        Califica.Ed_Fisica = TO5.Text;
                        Califica.Ed_Artistica = TO6.Text;
                        Califica.Computacion = TO7.Text;
                        Califica.Ingles = TO8.Text;

                        Califica.Ortografia = T10.Text;
                        Califica.Disciplina = TO11.Text;
                        Califica.Uniforme = TO12.Text;
                        Califica.Puntualidad = TO13.Text;
                        Califica.Material = TO14.Text;
                        Califica.Partici = TO15.Text;
                        Califica.Comp_Lect = TO16.Text;
                        Califica.Trabajos = TO17.Text;
                        Califica.Tareas = TO18.Text;
                        Califica.Karate = txt7.Text;
                        Califica.Ballet = txt8.Text;
                        Califica.Take = txt9.Text;
                        Califica.Inasistenicias = TO23.Text;
                        Califica.prosep = TO9.Text;
                        Califica.promcom = TO19.Text;
                        Califica.promgen = TO20.Text;
                        Califica.puntos = TO21.Text;


                        int resultado = CalificaPri(Califica, cDAlumnos);
                        if (resultado > 0)
                        {
                            CBMes.Visible = true;
                            label6.Visible = true;
                            MessageBox.Show("Calificacion GuardadA!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el la Calificacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        };
                        trons.Curp = txtbuscador.Text;
                        trons.tipobimes = "1°BIMESTRE";

                        trons.Español = B11.Text;
                        trons.Matematicas = B12.Text;
                        trons.Nat_y_Soc = B13.Text;
                        trons.Civica = B14.Text;
                        trons.Ed_Fisica = B15.Text;
                        trons.Ed_Artistica = B16.Text;
                        trons.Computacion = B17.Text;
                        trons.Ingles = B18.Text;

                        trons.Ortografia = B110.Text;
                        trons.Disciplina = B111.Text;
                        trons.Uniforme = B112.Text;
                        trons.Puntualidad = B113.Text;
                        trons.Material = B114.Text;
                        trons.Partici = B115.Text;
                        trons.Comp_Lect = B116.Text;
                        trons.Trabajos = B117.Text;
                        trons.Tareas = B118.Text;
                        trons.Karate = textBox16.Text;
                        trons.Ballet = textBox17.Text;
                        trons.Take = textBox18.Text;
                        trons.Inasistenicias = B123.Text;
                        trons.prosep = B19.Text;
                        trons.promcom = B119.Text;
                        trons.promgen = B120.Text;
                        trons.puntos = B121.Text;
                        int resultad = Registro.Calificacion(trons);
                    }


                }

                //Subir calificaciones de NOVIEMBRE
                if (CBMes.Text == "NOVIEMBRE")
                {

                    if (TN1.Text == "" || TN2.Text == "" || TN3.Text == "" || TN6.Text == "" || TN7.Text == "" || TN8.Text == ""
                        || TN10.Text == "" || TN11.Text == "" || TN12.Text == "" || TN13.Text == "" || TN14.Text == "" ||
                        TN15.Text == "" || TN16.Text == "" || TN17.Text == "" || TN18.Text == "" || TN23.Text == "")
                    {
                        MessageBox.Show("UN CAMPO ESTA VACIO, DEBE DE LLENARLO ANTES DE CONTINUAR", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Califica.Curp = txtbuscador.Text;
                        Califica.Mes = "NOVIEMBRE";
                        Califica.Grado = txtgrado.Text;

                        Califica.Español = TN1.Text;
                        Califica.Matematicas = TN2.Text;
                        Califica.Nat_y_Soc = TN3.Text;
                        Califica.Civica = TN4.Text;
                        Califica.Ed_Fisica = TN5.Text;
                        Califica.Ed_Artistica = TN6.Text;
                        Califica.Computacion = TN7.Text;
                        Califica.Ingles = TN8.Text;

                        Califica.Ortografia = TN10.Text;
                        Califica.Disciplina = TN11.Text;
                        Califica.Uniforme = TN12.Text;
                        Califica.Puntualidad = TN13.Text;
                        Califica.Material = TN14.Text;
                        Califica.Partici = TN15.Text;
                        Califica.Comp_Lect = TN16.Text;
                        Califica.Trabajos = TN17.Text;
                        Califica.Tareas = TN18.Text;
                        Califica.Karate = txt10.Text;
                        Califica.Ballet = txt11.Text;
                        Califica.Take = txt12.Text;
                        Califica.Inasistenicias = TN23.Text;
                        Califica.prosep = TN9.Text;
                        Califica.promcom = TN19.Text;
                        Califica.promgen = TN20.Text;
                        Califica.puntos = TN21.Text;

                        int resultado = CalificaPri(Califica, cDAlumnos);
                        if (resultado > 0)
                        {
                            CBMes.Visible = true;
                            label6.Visible = true;
                            MessageBox.Show("Calificacion GuardadA!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el la Calificacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        };
                    }
                }

                //Subir calificaciones de DICIEMBRE
                if (CBMes.Text == "DICIEMBRE")
                {

                    if (TDD1.Text == "" || TDD2.Text == "" || TDD3.Text == "" || TDD6.Text == "" || TDD7.Text == "" || TDD8.Text == "" ||
                         TDD10.Text == "" || TDD11.Text == "" || TDD12.Text == "" || TDD13.Text == "" || TDD14.Text == "" ||
                        TDD15.Text == "" || TDD16.Text == "" || TDD17.Text == "" || TDD18.Text == "" || TDD23.Text == "")
                    {
                        MessageBox.Show("UN CAMPO ESTA VACIO, DEBE DE LLENARLO ANTES DE CONTINUAR", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Califica.Curp = txtbuscador.Text;
                        Califica.Mes = "DICIEMBRE";
                        Califica.Grado = txtgrado.Text;

                        Califica.Español = TDD1.Text;
                        Califica.Matematicas = TDD2.Text;
                        Califica.Nat_y_Soc = TDD3.Text;
                        Califica.Civica = TDD4.Text;
                        Califica.Ed_Fisica = TDD5.Text;
                        Califica.Ed_Artistica = TDD6.Text;
                        Califica.Computacion = TDD7.Text;
                        Califica.Ingles = TDD8.Text;

                        Califica.Ortografia = TDD10.Text;
                        Califica.Disciplina = TDD11.Text;
                        Califica.Uniforme = TDD12.Text;
                        Califica.Puntualidad = TDD13.Text;
                        Califica.Material = TDD14.Text;
                        Califica.Partici = TDD15.Text;
                        Califica.Comp_Lect = TDD16.Text;
                        Califica.Trabajos = TDD17.Text;
                        Califica.Tareas = TDD18.Text;
                        Califica.Karate = txt13.Text;
                        Califica.Ballet = txt14.Text;
                        Califica.Take = txt15.Text;
                        Califica.Inasistenicias = TDD23.Text;
                        Califica.prosep = TDD9.Text;
                        Califica.promcom = TDD19.Text;
                        Califica.promgen = TDD20.Text;
                        Califica.puntos = TDD21.Text;

                        int resultado = CalificaPri(Califica, cDAlumnos);
                        if (resultado > 0)
                        {
                            MessageBox.Show("Calificacion GuardadA!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CBMes.Visible = true;
                            label6.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el la Calificacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        };

                        trons.Curp = txtbuscador.Text;
                        trons.tipobimes = "2°BIMESTRE";

                        trons.Español = B21.Text;
                        trons.Matematicas = B22.Text;
                        trons.Nat_y_Soc = B23.Text;
                        trons.Civica = B24.Text;
                        trons.Ed_Fisica = B25.Text;
                        trons.Ed_Artistica = B26.Text;
                        trons.Computacion = B27.Text;
                        trons.Ingles = B28.Text;

                        trons.Ortografia = B210.Text;
                        trons.Disciplina = B211.Text;
                        trons.Uniforme = B212.Text;
                        trons.Puntualidad = B213.Text;
                        trons.Material = B214.Text;
                        trons.Partici = B215.Text;
                        trons.Comp_Lect = B216.Text;
                        trons.Trabajos = B217.Text;
                        trons.Tareas = B218.Text;
                        trons.Karate = textBox13.Text;
                        trons.Ballet = textBox14.Text;
                        trons.Take = textBox15.Text;
                        trons.Inasistenicias = B223.Text;
                        trons.prosep = B29.Text;
                        trons.promcom = B219.Text;
                        trons.promgen = B220.Text;
                        trons.puntos = B221.Text;
                        int resulta  = Registro.Calificacion(trons);
                    }
                }
                //Subir calificaciones de ENERO
                if (CBMes.Text == "ENERO")
                {

                    if (TE1.Text == "" || TE2.Text == "" || TE3.Text == "" || TE6.Text == "" || TE7.Text == "" || TE8.Text == ""
                       || TE10.Text == "" || TE11.Text == "" || TE12.Text == "" || TE13.Text == "" || TE14.Text == "" ||
                        TE15.Text == "" || TE16.Text == "" || TE17.Text == "" || TE18.Text == "" || TE23.Text == "")
                    {
                        MessageBox.Show("UN CAMPO ESTA VACIO, DEBE DE LLENARLO ANTES DE CONTINUAR", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Califica.Curp = txtbuscador.Text;
                        Califica.Mes = "ENERO";
                        Califica.Grado = txtgrado.Text;

                        Califica.Español = TE1.Text;
                        Califica.Matematicas = TE2.Text;
                        Califica.Nat_y_Soc = TE3.Text;
                        Califica.Civica = TE4.Text;
                        Califica.Ed_Fisica = TE5.Text;
                        Califica.Ed_Artistica = TE6.Text;
                        Califica.Computacion = TE7.Text;
                        Califica.Ingles = TE8.Text;

                        Califica.Ortografia = TE10.Text;
                        Califica.Disciplina = TE11.Text;
                        Califica.Uniforme = TE12.Text;
                        Califica.Puntualidad = TE13.Text;
                        Califica.Material = TE14.Text;
                        Califica.Partici = TE15.Text;
                        Califica.Comp_Lect = TE16.Text;
                        Califica.Trabajos = TE17.Text;
                        Califica.Tareas = TE18.Text;
                        Califica.Karate = txt16.Text;
                        Califica.Ballet = txt17.Text;
                        Califica.Take = txt18.Text;
                        Califica.Inasistenicias = TE23.Text;
                        Califica.prosep = TE9.Text;
                        Califica.promcom = TE19.Text;
                        Califica.promgen = TE20.Text;
                        Califica.puntos = TE21.Text;

                        int resultado = CalificaPri(Califica, cDAlumnos);
                        if (resultado > 0)
                        {
                            MessageBox.Show("Calificacion GuardadA!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CBMes.Visible = true;
                            label6.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el la Calificacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        };
                    }
                }
                //Subir calificaciones de FEBRERO
                if (CBMes.Text == "FEBRERO")
                {

                    if (TF1.Text == "" || TF2.Text == "" || TF3.Text == "" || TF6.Text == "" || TF7.Text == "" || TF8.Text == ""
                        || TF10.Text == "" || TF11.Text == "" || TF12.Text == "" || TF13.Text == "" || TF14.Text == "" ||
                        TF15.Text == "" || TF16.Text == "" || TF17.Text == "" || TF18.Text == "" || TF23.Text == "")
                    {
                        MessageBox.Show("UN CAMPO ESTA VACIO, DEBE DE LLENARLO ANTES DE CONTINUAR", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Califica.Curp = txtbuscador.Text;
                        Califica.Mes = "FEBRERO";
                        Califica.Grado = txtgrado.Text;

                        Califica.Español = TF1.Text;
                        Califica.Matematicas = TF2.Text;
                        Califica.Nat_y_Soc = TF3.Text;
                        Califica.Civica = TF4.Text;
                        Califica.Ed_Fisica = TF5.Text;
                        Califica.Ed_Artistica = TF6.Text;
                        Califica.Computacion = TF7.Text;
                        Califica.Ingles = TF8.Text;

                        Califica.Ortografia = TF10.Text;
                        Califica.Disciplina = TF11.Text;
                        Califica.Uniforme = TF12.Text;
                        Califica.Puntualidad = TF13.Text;
                        Califica.Material = TF14.Text;
                        Califica.Partici = TF15.Text;
                        Califica.Comp_Lect = TF16.Text;
                        Califica.Trabajos = TF17.Text;
                        Califica.Tareas = TF18.Text;
                        Califica.Karate = textBox31.Text;
                        Califica.Ballet = textBox32.Text;
                        Califica.Take = textBox33.Text;
                        Califica.Inasistenicias = TF23.Text;
                        Califica.prosep = TF9.Text;
                        Califica.promcom = TF19.Text;
                        Califica.promgen = TF20.Text;
                        Califica.puntos = TF21.Text;

                        int resultado = CalificaPri(Califica, cDAlumnos);
                        if (resultado > 0)
                        {
                            MessageBox.Show("Calificacion GuardadA!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CBMes.Visible = true;
                            label6.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el la Calificacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        };
                        trons.Curp = txtbuscador.Text;
                        trons.tipobimes = "3°BIMESTRE";

                        trons.Español = B31.Text;
                        trons.Matematicas = B32.Text;
                        trons.Nat_y_Soc = B33.Text;
                        trons.Civica = B34.Text;
                        trons.Ed_Fisica = B35.Text;
                        trons.Ed_Artistica = B36.Text;
                        trons.Computacion = B37.Text;
                        trons.Ingles = B38.Text;

                        trons.Ortografia = B310.Text;
                        trons.Disciplina = B311.Text;
                        trons.Uniforme = B312.Text;
                        trons.Puntualidad = B313.Text;
                        trons.Material = B314.Text;
                        trons.Partici = B315.Text;
                        trons.Comp_Lect = B316.Text;
                        trons.Trabajos = B317.Text;
                        trons.Tareas = B318.Text;
                        trons.Karate = textBox10.Text;
                        trons.Ballet = textBox11.Text;
                        trons.Take = textBox12.Text;
                        trons.Inasistenicias = B323.Text;
                        trons.prosep = B39.Text;
                        trons.promcom = B319.Text;
                        trons.promgen = B320.Text;
                        trons.puntos = B321.Text;
                        int result  = Registro.Calificacion(trons);

                    }
                }

                //Subir calificaciones de MARZO
                if (CBMes.Text == "MARZO")
                {

                    if (TM1.Text == "" || TM2.Text == "" || TM3.Text == "" || TM6.Text == "" || TM7.Text == "" || TM8.Text == "" ||
                         TM10.Text == "" || TM11.Text == "" || TM12.Text == "" || TM13.Text == "" || TM14.Text == "" ||
                        TM15.Text == "" || TM16.Text == "" || TM17.Text == "" || TM18.Text == "" || TM23.Text == "")
                    {
                        MessageBox.Show("UN CAMPO ESTA VACIO, DEBE DE LLENARLO ANTES DE CONTINUAR", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Califica.Curp = txtbuscador.Text;
                        Califica.Mes = "MARZO";
                        Califica.Grado = txtgrado.Text;

                        Califica.Español = TM1.Text;
                        Califica.Matematicas = TM2.Text;
                        Califica.Nat_y_Soc = TM3.Text;
                        Califica.Civica = TM4.Text;
                        Califica.Ed_Fisica = TM5.Text;
                        Califica.Ed_Artistica = TM6.Text;
                        Califica.Computacion = TM7.Text;
                        Califica.Ingles = TM8.Text;

                        Califica.Ortografia = TM10.Text;
                        Califica.Disciplina = TM11.Text;
                        Califica.Uniforme = TM12.Text;
                        Califica.Puntualidad = TM13.Text;
                        Califica.Material = TM14.Text;
                        Califica.Partici = TM15.Text;
                        Califica.Comp_Lect = TM16.Text;
                        Califica.Trabajos = TM17.Text;
                        Califica.Tareas = TM18.Text;
                        Califica.Karate = textBox28.Text;
                        Califica.Ballet = textBox29.Text;
                        Califica.Take = textBox30.Text;
                        Califica.Inasistenicias = TM23.Text;
                        Califica.prosep = TM9.Text;
                        Califica.promcom = TM19.Text;
                        Califica.promgen = TM20.Text;
                        Califica.puntos = TM21.Text;


                        int resultado = CalificaPri(Califica, cDAlumnos);
                        if (resultado > 0)
                        {
                            MessageBox.Show("Calificacion GuardadA!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CBMes.Visible = true;
                            label6.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el la Calificacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        };
                    }
                }

                //Subir calificaciones de ABRIL
                if (CBMes.Text == "ABRIL")
                {

                    if (TA1.Text == "" || TA2.Text == "" || TA3.Text == "" || TA6.Text == "" || TA7.Text == "" || TA8.Text == ""
                        || TA10.Text == "" || TA11.Text == "" || TA12.Text == "" || TA13.Text == "" || TA14.Text == "" ||
                        TA15.Text == "" || TA16.Text == "" || TA17.Text == "" || TA18.Text == "" || TA23.Text == "")
                    {
                        MessageBox.Show("UN CAMPO ESTA VACIO, DEBE DE LLENARLO ANTES DE CONTINUAR", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Califica.Curp = txtbuscador.Text;
                        Califica.Mes = "ABRIL";
                        Califica.Grado = txtgrado.Text;

                        Califica.Español = TA1.Text;
                        Califica.Matematicas = TA2.Text;
                        Califica.Nat_y_Soc = TA3.Text;
                        Califica.Civica = TA4.Text;
                        Califica.Ed_Fisica = TA5.Text;
                        Califica.Ed_Artistica = TA6.Text;
                        Califica.Computacion = TA7.Text;
                        Califica.Ingles = TA8.Text;

                        Califica.Ortografia = TA10.Text;
                        Califica.Disciplina = TA11.Text;
                        Califica.Uniforme = TA12.Text;
                        Califica.Puntualidad = TA13.Text;
                        Califica.Material = TA14.Text;
                        Califica.Partici = TA15.Text;
                        Califica.Comp_Lect = TA16.Text;
                        Califica.Trabajos = TA17.Text;
                        Califica.Tareas = TA18.Text;
                        Califica.Karate = textBox25.Text;
                        Califica.Ballet = textBox26.Text;
                        Califica.Take = textBox27.Text;
                        Califica.Inasistenicias = TA23.Text;
                        Califica.prosep = TA9.Text;
                        Califica.promcom = TA19.Text;
                        Califica.promgen = TA20.Text;
                        Califica.puntos = TA21.Text;

                        int resultado = CalificaPri(Califica, cDAlumnos);
                        if (resultado > 0)
                        {
                            MessageBox.Show("Calificacion GuardadA!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CBMes.Visible = true;
                            label6.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el la Calificacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        };
                        trons.Curp = txtbuscador.Text;
                        trons.tipobimes = "4°BIMESTRE";

                        trons.Español = B41.Text;
                        trons.Matematicas = B42.Text;
                        trons.Nat_y_Soc = B43.Text;
                        trons.Civica = B44.Text;
                        trons.Ed_Fisica = B45.Text;
                        trons.Ed_Artistica = B46.Text;
                        trons.Computacion = B47.Text;
                        trons.Ingles = B48.Text;

                        trons.Ortografia = B410.Text;
                        trons.Disciplina = B411.Text;
                        trons.Uniforme = B412.Text;
                        trons.Puntualidad = B413.Text;
                        trons.Material = B414.Text;
                        trons.Partici = B415.Text;
                        trons.Comp_Lect = B416.Text;
                        trons.Trabajos = B417.Text;
                        trons.Tareas = B418.Text;
                        trons.Karate = textBox7.Text;
                        trons.Ballet = textBox8.Text;
                        trons.Take = textBox9.Text;
                        trons.Inasistenicias = B423.Text;
                        trons.prosep = B49.Text;
                        trons.promcom = B419.Text;
                        trons.promgen = B420.Text;
                        trons.puntos = B421.Text;
                        int resul   = Registro.Calificacion(trons);


                    }
                }
                //Subir calificaciones de MAYO
                if (CBMes.Text == "MAYO")
                {

                    if (TMA1.Text == "" || TMA2.Text == "" || TMA3.Text == "" || TMA6.Text == "" || TMA7.Text == "" || TMA8.Text == ""
                         || TMA10.Text == "" || TMA11.Text == "" || TMA12.Text == "" || TMA13.Text == "" || TMA14.Text == "" ||
                        TMA15.Text == "" || TMA16.Text == "" || TMA17.Text == "" || TMA18.Text == "" || TMA23.Text == "")
                    {
                        MessageBox.Show("UN CAMPO ESTA VACIO, DEBE DE LLENARLO ANTES DE CONTINUAR", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Califica.Curp = txtbuscador.Text;
                        Califica.Mes = "MAYO";
                        Califica.Grado = txtgrado.Text;

                        Califica.Español = TMA1.Text;
                        Califica.Matematicas = TMA2.Text;
                        Califica.Nat_y_Soc = TMA3.Text;
                        Califica.Civica = TMA4.Text;
                        Califica.Ed_Fisica = TMA5.Text;
                        Califica.Ed_Artistica = TMA6.Text;
                        Califica.Computacion = TMA7.Text;
                        Califica.Ingles = TMA8.Text;

                        Califica.Ortografia = TMA10.Text;
                        Califica.Disciplina = TMA11.Text;
                        Califica.Uniforme = TMA12.Text;
                        Califica.Puntualidad = TMA13.Text;
                        Califica.Material = TMA14.Text;
                        Califica.Partici = TMA15.Text;
                        Califica.Comp_Lect = TMA16.Text;
                        Califica.Trabajos = TMA17.Text;
                        Califica.Tareas = TMA18.Text;
                        Califica.Karate = textBox22.Text;
                        Califica.Ballet = textBox23.Text;
                        Califica.Take = textBox24.Text;
                        Califica.Inasistenicias = TMA23.Text;
                        Califica.prosep = TMA9.Text;
                        Califica.promcom = TMA19.Text;
                        Califica.promgen = TMA20.Text;
                        Califica.puntos = TMA21.Text;


                        int resultado = CalificaPri(Califica, cDAlumnos);
                        if (resultado > 0)
                        {
                            MessageBox.Show("Calificacion GuardadA!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CBMes.Visible = true;
                            label6.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el la Calificacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        };
                    }
                }

                //Subir calificaciones de JUNIO
                if (CBMes.Text == "JUNIO")
                {

                    if (TJ1.Text == "" || TJ2.Text == "" || TJ3.Text == "" || TJ6.Text == "" || TJ7.Text == "" || TJ8.Text == ""
                       || TJ10.Text == "" || TJ11.Text == "" || TJ12.Text == "" || TJ13.Text == "" || TJ14.Text == "" ||
                        TJ15.Text == "" || TJ16.Text == "" || TJ17.Text == "" || TJ18.Text == "" || TJ23.Text == "")
                    {
                        MessageBox.Show("UN CAMPO ESTA VACIO, DEBE DE LLENARLO ANTES DE CONTINUAR", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Califica.Curp = txtbuscador.Text;
                        Califica.Mes = "JUNIO";
                        Califica.Grado = txtgrado.Text;

                        Califica.Español = TJ1.Text;
                        Califica.Matematicas = TJ2.Text;
                        Califica.Nat_y_Soc = TJ3.Text;
                        Califica.Civica = TJ4.Text;
                        Califica.Ed_Fisica = TJ5.Text;
                        Califica.Ed_Artistica = TJ6.Text;
                        Califica.Computacion = TJ7.Text;
                        Califica.Ingles = TJ8.Text;

                        Califica.Ortografia = TJ10.Text;
                        Califica.Disciplina = TJ11.Text;
                        Califica.Uniforme = TJ12.Text;
                        Califica.Puntualidad = TJ13.Text;
                        Califica.Material = TJ14.Text;
                        Califica.Partici = TJ15.Text;
                        Califica.Comp_Lect = TJ16.Text;
                        Califica.Trabajos = TJ17.Text;
                        Califica.Tareas = TJ18.Text;
                        Califica.Karate = textBox19.Text;
                        Califica.Ballet = textBox20.Text;
                        Califica.Take = textBox21.Text;
                        Califica.Inasistenicias = TJ23.Text;
                        Califica.prosep = TJ9.Text;
                        Califica.promcom = TJ19.Text;
                        Califica.promgen = TJ20.Text;
                        Califica.puntos = TJ21.Text;

                        int resultado = CalificaPri(Califica, cDAlumnos);
                        if (resultado > 0)
                        {
                            MessageBox.Show("Calificacion GuardadA!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CBMes.Visible = true;
                            label6.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el la Calificacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        };
                        trons.Curp = txtbuscador.Text;
                        trons.tipobimes = "5°BIMESTRE";

                        trons.Español = B51.Text;
                        trons.Matematicas = B52.Text;
                        trons.Nat_y_Soc = B53.Text;
                        trons.Civica = B54.Text;
                        trons.Ed_Fisica = B55.Text;
                        trons.Ed_Artistica = B56.Text;
                        trons.Computacion = B57.Text;
                        trons.Ingles = B58.Text;

                        trons.Ortografia = B510.Text;
                        trons.Disciplina = B511.Text;
                        trons.Uniforme = B512.Text;
                        trons.Puntualidad = B513.Text;
                        trons.Material = B514.Text;
                        trons.Partici = B515.Text;
                        trons.Comp_Lect = B516.Text;
                        trons.Trabajos = B517.Text;
                        trons.Tareas = B518.Text;
                        trons.Karate = textBox4.Text;
                        trons.Ballet = textBox5.Text;
                        trons.Take = textBox6.Text;
                        trons.Inasistenicias = B423.Text;
                        trons.prosep = B59.Text;
                        trons.promcom = B519.Text;
                        trons.promgen = B520.Text;
                        trons.puntos = B521.Text;
                        int resu = Registro.Calificacion(trons);


                    }


                }
            }
        }

        private void CBMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBMes.Text == "DIAGNOSTICO")
            {
                CBMes.Visible = false;
                label6.Visible = false;
                if (
                TD2.Text == "" ||
                TD1.Text == "" ||
                TD3.Text == "" ||
                TD4.Text == "" ||
                TD5.Text == "" ||
                TD6.Text == "" ||
                TD7.Text == "" ||
                TD8.Text == "" ||

                TD10.Text == "" ||
                TD11.Text == "" ||
                TD12.Text == "" ||
                TD13.Text == "" ||
                TD14.Text == "" ||
                TD15.Text == "" ||
                TD16.Text == "" ||
                TD17.Text == "" ||
                TD18.Text == "" ||
                txt1.Text == "" ||
                txt2.Text == "" ||
                txt3.Text == "" ||

                TD23.Text == ""


                )
                {
                    //Deshabilita los textbox de Diagnostico
                    TD2.Enabled = true;
                    TD1.Enabled = true;
                    TD3.Enabled = true;
                    TD4.Enabled = true;
                    TD5.Enabled = true;
                    TD6.Enabled = true;
                    TD7.Enabled = true;
                    TD8.Enabled = true;
                    //TxBDiaCom.Enabled = true;
                    //TxBDiaIng.Enabled = true;

                    TD10.Enabled = true;
                    TD11.Enabled = true;
                    TD12.Enabled = true;
                    TD13.Enabled = true;
                    TD14.Enabled = true;
                    TD15.Enabled = true;
                    TD16.Enabled = true;
                    TD17.Enabled = true;
                    TD18.Enabled = true;
                    txt1.Enabled = true;
                    txt2.Enabled = true;
                    txt3.Enabled = true;

                    TD23.Enabled = true;


                    //Deshabilita los textbox de Septiembre
                    TS1.Enabled = false;
                    TS2.Enabled = false;
                    TS3.Enabled = false;
                    TS4.Enabled = false;
                    TS5.Enabled = false;
                    TS6.Enabled = false;
                    TS7.Enabled = false;
                    TS8.Enabled = false;

                    TS10.Enabled = false;
                    TS11.Enabled = false;
                    TS12.Enabled = false;
                    TS13.Enabled = false;
                    TS14.Enabled = false;
                    TS15.Enabled = false;
                    TS16.Enabled = false;
                    TS17.Enabled = false;
                    TS18.Enabled = false;
                    txt6.Enabled = false;
                    txt5.Enabled = false;
                    txt4.Enabled = false;

                    TS23.Enabled = false;

                    //Deshabilita los textbox de Octubre
                    TO1.Enabled = false;
                    TO2.Enabled = false;
                    TO3.Enabled = false;
                    TO4.Enabled = false;
                    TO5.Enabled = false;
                    TO6.Enabled = false;
                    TO7.Enabled = false;
                    TO8.Enabled = false;

                    T10.Enabled = false;
                    TO11.Enabled = false;
                    TO12.Enabled = false;
                    TO13.Enabled = false;
                    TO14.Enabled = false;
                    TO15.Enabled = false;
                    TO16.Enabled = false;
                    TO17.Enabled = false;
                    TO18.Enabled = false;
                    txt9.Enabled = false;
                    txt8.Enabled = false;
                    txt7.Enabled = false;

                    TO23.Enabled = false;

                    //Deshabilita los textbox de Noviembre
                    TN1.Enabled = false;
                    TN2.Enabled = false;
                    TN3.Enabled = false;
                    TN4.Enabled = false;
                    TN5.Enabled = false;
                    TN6.Enabled = false;
                    TN7.Enabled = false;
                    TN8.Enabled = false;

                    TN10.Enabled = false;
                    TN11.Enabled = false;
                    TN12.Enabled = false;
                    TN13.Enabled = false;
                    TN14.Enabled = false;
                    TN15.Enabled = false;
                    TN16.Enabled = false;
                    TN17.Enabled = false;
                    TN18.Enabled = false;
                    txt10.Enabled = false;
                    txt11.Enabled = false;
                    txt12.Enabled = false;

                    TN23.Enabled = false;

                    //Deshabilita los textbox de Diciembre
                    TDD1.Enabled = false;
                    TDD2.Enabled = false;
                    TDD3.Enabled = false;
                    TDD4.Enabled = false;
                    TDD5.Enabled = false;
                    TDD6.Enabled = false;
                    TDD7.Enabled = false;
                    TDD8.Enabled = false;

                    TDD10.Enabled = false;
                    TDD11.Enabled = false;
                    TDD12.Enabled = false;
                    TDD13.Enabled = false;
                    TDD14.Enabled = false;
                    TDD15.Enabled = false;
                    TDD16.Enabled = false;
                    TDD17.Enabled = false;
                    TDD18.Enabled = false;
                    txt13.Enabled = false;
                    txt14.Enabled = false;
                    txt15.Enabled = false;

                    TDD23.Enabled = false;

                    //Deshabilita los textbox de Enero
                    TE1.Enabled = false;
                    TE2.Enabled = false;
                    TE3.Enabled = false;
                    TE4.Enabled = false;
                    TE5.Enabled = false;
                    TE6.Enabled = false;
                    TE7.Enabled = false;
                    TE8.Enabled = false;

                    TE10.Enabled = false;
                    TE11.Enabled = false;
                    TE12.Enabled = false;
                    TE13.Enabled = false;
                    TE14.Enabled = false;
                    TE15.Enabled = false;
                    TE16.Enabled = false;
                    TE17.Enabled = false;
                    TE18.Enabled = false;
                    txt16.Enabled = false;
                    txt17.Enabled = false;
                    txt18.Enabled = false;

                    TE23.Enabled = false;

                    //Deshabilita los textbox de Febrero
                    TF1.Enabled = false;
                    TF2.Enabled = false;
                    TF3.Enabled = false;
                    TF4.Enabled = false;
                    TF5.Enabled = false;
                    TF6.Enabled = false;
                    TF7.Enabled = false;
                    TF8.Enabled = false;

                    TF10.Enabled = false;
                    TF11.Enabled = false;
                    TF12.Enabled = false;
                    TF13.Enabled = false;
                    TF14.Enabled = false;
                    TF15.Enabled = false;
                    TF16.Enabled = false;
                    TF17.Enabled = false;
                    TF18.Enabled = false;
                    textBox31.Enabled = false;
                    textBox32.Enabled = false;
                    textBox33.Enabled = false;

                    TF23.Enabled = false;

                    //Deshabilita los textbox de Marzo
                    TM1.Enabled = false;
                    TM2.Enabled = false;
                    TM3.Enabled = false;
                    TM4.Enabled = false;
                    TM5.Enabled = false;
                    TM6.Enabled = false;
                    TM7.Enabled = false;
                    TM8.Enabled = false;

                    TM10.Enabled = false;
                    TM11.Enabled = false;
                    TM12.Enabled = false;
                    TM13.Enabled = false;
                    TM14.Enabled = false;
                    TM15.Enabled = false;
                    TM16.Enabled = false;
                    TM17.Enabled = false;
                    TM18.Enabled = false;
                    textBox28.Enabled = false;
                    textBox29.Enabled = false;
                    textBox30.Enabled = false;

                    TM23.Enabled = false;

                    //Deshabilita los textbox de Abril
                    TA1.Enabled = false;
                    TA2.Enabled = false;
                    TA3.Enabled = false;
                    TA4.Enabled = false;
                    TA5.Enabled = false;
                    TA6.Enabled = false;
                    TA7.Enabled = false;
                    TA8.Enabled = false;

                    TA10.Enabled = false;
                    TA11.Enabled = false;
                    TA12.Enabled = false;
                    TA13.Enabled = false;
                    TA14.Enabled = false;
                    TA15.Enabled = false;
                    TA16.Enabled = false;
                    TA17.Enabled = false;
                    TA18.Enabled = false;
                    textBox25.Enabled = false;
                    textBox26.Enabled = false;
                    textBox27.Enabled = false;

                    TA23.Enabled = false;

                    //Deshabilita los textbox de Mayo
                    TMA1.Enabled = false;
                    TMA2.Enabled = false;
                    TMA3.Enabled = false;
                    TMA4.Enabled = false;
                    TMA5.Enabled = false;
                    TMA6.Enabled = false;
                    TMA7.Enabled = false;
                    TMA8.Enabled = false;

                    TMA10.Enabled = false;
                    TMA11.Enabled = false;
                    TMA12.Enabled = false;
                    TMA13.Enabled = false;
                    TMA14.Enabled = false;
                    TMA15.Enabled = false;
                    TMA16.Enabled = false;
                    TMA17.Enabled = false;
                    TMA18.Enabled = false;
                    textBox22.Enabled = false;
                    textBox23.Enabled = false;
                    textBox24.Enabled = false;

                    TMA23.Enabled = false;

                    //Deshabilita los textbox de Junio
                    TJ1.Enabled = false;
                    TJ2.Enabled = false;
                    TJ3.Enabled = false;
                    TJ4.Enabled = false;
                    TJ5.Enabled = false;
                    TJ6.Enabled = false;
                    TJ7.Enabled = false;
                    TJ8.Enabled = false;

                    TJ10.Enabled = false;
                    TJ11.Enabled = false;
                    TJ12.Enabled = false;
                    TJ13.Enabled = false;
                    TJ14.Enabled = false;
                    TJ15.Enabled = false;
                    TJ16.Enabled = false;
                    TJ17.Enabled = false;
                    TJ18.Enabled = false;
                    textBox19.Enabled = false;
                    textBox20.Enabled = false;
                    textBox21.Enabled = false;

                    TJ23.Enabled = false;
                }
                else
                {
                    MessageBox.Show("El mes ya no se puede modificar");
                }

            }


            if (CBMes.Text == "SEPTIEMBRE")
            {
                CBMes.Visible = false;
                label6.Visible = false;
                if (TD2.Text == "" ||
                TD1.Text == "" ||
                TD3.Text == "" ||
                TD4.Text == "" ||
                TD5.Text == "" ||
                TD6.Text == "" ||
                TD7.Text == "" ||
                TD8.Text == "" ||

                TD10.Text == "" ||
                TD11.Text == "" ||
                TD12.Text == "" ||
                TD13.Text == "" ||
                TD14.Text == "" ||
                TD15.Text == "" ||
                TD16.Text == "" ||
                TD17.Text == "" ||
                TD18.Text == "" ||
                txt1.Text == "" ||
                txt2.Text == "" ||
                txt3.Text == "" ||

                TD23.Text == "")

                {
                    if (!objproducto.Existe(Convert.ToString(TD23.Text)))
                    {
                        MessageBox.Show("Diagnostico");

                    }
                    MessageBox.Show("Primero  debe de llenar Diagnostico");
                }
                else
                {
                    if (TS1.Text == "" ||
                        TS2.Text == "" ||
                        TS3.Text == "" ||
                        TS4.Text == "" ||
                        TS5.Text == "" ||
                        TS6.Text == "" ||
                        TS7.Text == "" ||
                        TS8.Text == "" ||

                        TS10.Text == "" ||
                        TS11.Text == "" ||
                        TS12.Text == "" ||
                        TS13.Text == "" ||
                        TS14.Text == "" ||
                        TS15.Text == "" ||
                        TS16.Text == "" ||
                        TS17.Text == "" ||
                        TS18.Text == "" ||
                        txt6.Text == "" ||
                        txt5.Text == "" ||
                        txt4.Text == "" ||

                        TS23.Text == "")
                    {
                        //Deshabilita los textbox de Diagnostico
                        TD2.Enabled = false;
                        TD1.Enabled = false;
                        TD3.Enabled = false;
                        TD4.Enabled = false;
                        TD5.Enabled = false;
                        TD6.Enabled = false;
                        TD7.Enabled = false;
                        TD8.Enabled = false;

                        TD10.Enabled = false;
                        TD11.Enabled = false;
                        TD12.Enabled = false;
                        TD13.Enabled = false;
                        TD14.Enabled = false;
                        TD15.Enabled = false;
                        TD16.Enabled = false;
                        TD17.Enabled = false;
                        TD18.Enabled = false;
                        txt1.Enabled = false;
                        txt2.Enabled = false;
                        txt3.Enabled = false;

                        TD23.Enabled = false;


                        //Deshabilita los textbox de Septiembre
                        TS1.Enabled = true;
                        TS2.Enabled = true;
                        TS3.Enabled = true;
                        TS4.Enabled = true;
                        TS5.Enabled = true;
                        TS6.Enabled = true;
                        TS7.Enabled = true;
                        TS8.Enabled = true;
                        //TxBSepCom.Enabled = false;
                        //TxBSepIng.Enabled = false;

                        TS10.Enabled = true;
                        TS11.Enabled = true;
                        TS12.Enabled = true;
                        TS13.Enabled = true;
                        TS14.Enabled = true;
                        TS15.Enabled = true;
                        TS16.Enabled = true;
                        TS17.Enabled = true;
                        TS18.Enabled = true;
                        txt6.Enabled = true;
                        txt5.Enabled = true;
                        txt4.Enabled = true;

                        TS23.Enabled = true;

                        //Deshabilita los textbox de Octubre
                        TO1.Enabled = false;
                        TO2.Enabled = false;
                        TO3.Enabled = false;
                        TO4.Enabled = false;
                        TO5.Enabled = false;
                        TO6.Enabled = false;
                        TO7.Enabled = false;
                        TO8.Enabled = false;
                        //TxBOctCom.Enabled = false;
                        //TxBOctIng.Enabled = false;

                        T10.Enabled = false;
                        TO11.Enabled = false;
                        TO12.Enabled = false;
                        TO13.Enabled = false;
                        TO14.Enabled = false;
                        TO15.Enabled = false;
                        TO16.Enabled = false;
                        TO17.Enabled = false;
                        TO18.Enabled = false;
                        txt8.Enabled = false;
                        txt9.Enabled = false;
                        txt7.Enabled = false;

                        TO23.Enabled = false;

                        //Deshabilita los textbox de Noviembre
                        TN1.Enabled = false;
                        TN2.Enabled = false;
                        TN3.Enabled = false;
                        TN4.Enabled = false;
                        TN5.Enabled = false;
                        TN6.Enabled = false;
                        TN7.Enabled = false;
                        TN8.Enabled = false;
                        //TxBNovCom.Enabled = false;
                        //TxBNovIng.Enabled = false;

                        TN10.Enabled = false;
                        TN11.Enabled = false;
                        TN12.Enabled = false;
                        TN13.Enabled = false;
                        TN14.Enabled = false;
                        TN15.Enabled = false;
                        TN16.Enabled = false;
                        TN17.Enabled = false;
                        TN18.Enabled = false;
                        txt10.Enabled = false;
                        txt11.Enabled = false;
                        txt12.Enabled = false;

                        TN23.Enabled = false;

                        //Deshabilita los textbox de Diciembre
                        TDD1.Enabled = false;
                        TDD2.Enabled = false;
                        TDD3.Enabled = false;
                        TDD4.Enabled = false;
                        TDD5.Enabled = false;
                        TDD6.Enabled = false;
                        TDD7.Enabled = false;
                        TDD8.Enabled = false;
                        //TxBDicCom.Enabled = false;
                        //TxBDicIng.Enabled = false;

                        TDD10.Enabled = false;
                        TDD11.Enabled = false;
                        TDD12.Enabled = false;
                        TDD13.Enabled = false;
                        TDD14.Enabled = false;
                        TDD15.Enabled = false;
                        TDD16.Enabled = false;
                        TDD17.Enabled = false;
                        TDD18.Enabled = false;
                        txt13.Enabled = false;
                        txt14.Enabled = false;
                        txt15.Enabled = false;

                        TDD23.Enabled = false;

                        //Deshabilita los textbox de Enero
                        TE1.Enabled = false;
                        TE2.Enabled = false;
                        TE3.Enabled = false;
                        TE4.Enabled = false;
                        TE5.Enabled = false;
                        TE6.Enabled = false;
                        TE7.Enabled = false;
                        TE8.Enabled = false;
                        //TxBEneCom.Enabled = false;
                        //TxBEneIng.Enabled = false;

                        TE10.Enabled = false;
                        TE11.Enabled = false;
                        TE12.Enabled = false;
                        TE13.Enabled = false;
                        TE14.Enabled = false;
                        TE15.Enabled = false;
                        TE16.Enabled = false;
                        TE17.Enabled = false;
                        TE18.Enabled = false;
                        txt16.Enabled = false;
                        txt17.Enabled = false;
                        txt18.Enabled = false;

                        TE23.Enabled = false;

                        //Deshabilita los textbox de Febrero
                        TF1.Enabled = false;
                        TF2.Enabled = false;
                        TF3.Enabled = false;
                        TF4.Enabled = false;
                        TF5.Enabled = false;
                        TF6.Enabled = false;
                        TF7.Enabled = false;
                        TF8.Enabled = false;
                        //TxBFebCom.Enabled = false;
                        //TxBFebIng.Enabled = false;

                        TF10.Enabled = false;
                        TF11.Enabled = false;
                        TF12.Enabled = false;
                        TF13.Enabled = false;
                        TF14.Enabled = false;
                        TF15.Enabled = false;
                        TF16.Enabled = false;
                        TF17.Enabled = false;
                        TF18.Enabled = false;
                        textBox31.Enabled = false;
                        textBox32.Enabled = false;
                        textBox33.Enabled = false;

                        TF23.Enabled = false;

                        //Deshabilita los textbox de Marzo
                        TM1.Enabled = false;
                        TM2.Enabled = false;
                        TM3.Enabled = false;
                        TM4.Enabled = false;
                        TM5.Enabled = false;
                        TM6.Enabled = false;
                        TM7.Enabled = false;
                        TM8.Enabled = false;
                        //TxBMarCom.Enabled = false;
                        //TxBMarIng.Enabled = false;

                        TM10.Enabled = false;
                        TM11.Enabled = false;
                        TM12.Enabled = false;
                        TM13.Enabled = false;
                        TM14.Enabled = false;
                        TM15.Enabled = false;
                        TM16.Enabled = false;
                        TM17.Enabled = false;
                        TM18.Enabled = false;
                        textBox28.Enabled = false;
                        textBox29.Enabled = false;
                        textBox30.Enabled = false;

                        TM23.Enabled = false;

                        //Deshabilita los textbox de Abril
                        TA1.Enabled = false;
                        TA2.Enabled = false;
                        TA3.Enabled = false;
                        TA4.Enabled = false;
                        TA5.Enabled = false;
                        TA6.Enabled = false;
                        TA7.Enabled = false;
                        TA8.Enabled = false;
                        //TxBAbrCom.Enabled = false;
                        //TxBAbrIng.Enabled = false;

                        TA10.Enabled = false;
                        TA11.Enabled = false;
                        TA12.Enabled = false;
                        TA13.Enabled = false;
                        TA14.Enabled = false;
                        TA15.Enabled = false;
                        TA16.Enabled = false;
                        TA17.Enabled = false;
                        TA18.Enabled = false;
                        textBox25.Enabled = false;
                        textBox26.Enabled = false;
                        textBox27.Enabled = false;

                        TA23.Enabled = false;

                        //Deshabilita los textbox de Mayo
                        TMA1.Enabled = false;
                        TMA2.Enabled = false;
                        TMA3.Enabled = false;
                        TMA4.Enabled = false;
                        TMA5.Enabled = false;
                        TMA6.Enabled = false;
                        TMA7.Enabled = false;
                        TMA8.Enabled = false;
                        //TxBMayCom.Enabled = false;
                        //TxBMayIng.Enabled = false;

                        TMA10.Enabled = false;
                        TMA11.Enabled = false;
                        TMA12.Enabled = false;
                        TMA13.Enabled = false;
                        TMA14.Enabled = false;
                        TMA15.Enabled = false;
                        TMA16.Enabled = false;
                        TMA17.Enabled = false;
                        TMA18.Enabled = false;
                        textBox22.Enabled = false;
                        textBox23.Enabled = false;
                        textBox24.Enabled = false;

                        TMA23.Enabled = false;


                        //Deshabilita los textbox de Junio
                        TJ1.Enabled = false;
                        TJ2.Enabled = false;
                        TJ3.Enabled = false;
                        TJ4.Enabled = false;
                        TJ5.Enabled = false;
                        TJ6.Enabled = false;
                        TJ7.Enabled = false;
                        TJ8.Enabled = false;

                        TJ10.Enabled = false;
                        TJ11.Enabled = false;
                        TJ12.Enabled = false;
                        TJ13.Enabled = false;
                        TJ14.Enabled = false;
                        TJ15.Enabled = false;
                        TJ16.Enabled = false;
                        TJ17.Enabled = false;
                        TJ18.Enabled = false;
                        textBox19.Enabled = false;
                        textBox20.Enabled = false;
                        textBox21.Enabled = false;

                        TJ23.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Ya no se puede modificar el mes de septiembre");
                    }
                }
            }
            if (CBMes.Text == "OCTUBRE")
            {
                CBMes.Visible = false;
                label6.Visible = false;
                if (TS1.Text == "" ||
                TS2.Text == "" ||
                TS3.Text == "" ||
                TS4.Text == "" ||
                TS5.Text == "" ||
                TS6.Text == "" ||
                TS7.Text == "" ||
                TS8.Text == "" ||

                TS10.Text == "" ||
                TS11.Text == "" ||
                TS12.Text == "" ||
                TS13.Text == "" ||
                TS14.Text == "" ||
                TS15.Text == "" ||
                TS16.Text == "" ||
                TS17.Text == "" ||
                TS18.Text == "" ||
                txt6.Text == "" ||
                txt5.Text == "" ||
                txt4.Text == "" ||

                TS23.Text == "")
                {
                    MessageBox.Show("Debe llenar primero Septiembre");
                }
                else
                {
                    if (TO1.Text == "" ||
                    TO2.Text == "" ||
                    TO3.Text == "" ||
                    TO4.Text == "" ||
                    TO5.Text == "" ||
                    TO6.Text == "" ||
                    TO7.Text == "" ||
                    TO8.Text == "" ||


                    T10.Text == "" ||
                    TO11.Text == "" ||
                    TO12.Text == "" ||
                    TO13.Text == "" ||
                    TO14.Text == "" ||
                    TO15.Text == "" ||
                    TO16.Text == "" ||
                    TO17.Text == "" ||
                    TO18.Text == "" ||
                    txt9.Text == "" ||
                    txt8.Text == "" ||
                    txt7.Text == "" ||

                    TO23.Text == "")
                    {
                        TD3.Enabled = false;
                        TD1.Enabled = false;
                        TD3.Enabled = false;
                        TD4.Enabled = false;
                        TD5.Enabled = false;
                        TD6.Enabled = false;
                        TD7.Enabled = false;
                        TD8.Enabled = false;
                        //TxBDiaCom.Enabled = false;
                        //TxBDiaIng.Enabled = false;

                        TD10.Enabled = false;
                        TD11.Enabled = false;
                        TD12.Enabled = false;
                        TD13.Enabled = false;
                        TD14.Enabled = false;
                        TD15.Enabled = false;
                        TD16.Enabled = false;
                        TD17.Enabled = false;
                        TD18.Enabled = false;
                        txt1.Enabled = false;
                        txt2.Enabled = false;
                        txt3.Enabled = false;

                        TD23.Enabled = false;


                        //Deshabilita los textbox de Septiembre
                        TS1.Enabled = false;
                        TS2.Enabled = false;
                        TS3.Enabled = false;
                        TS4.Enabled = false;
                        TS5.Enabled = false;
                        TS6.Enabled = false;
                        TS7.Enabled = false;
                        TS8.Enabled = false;
                        //TxBSepCom.Enabled = false;
                        //TxBSepIng.Enabled = false;

                        TS10.Enabled = false;
                        TS11.Enabled = false;
                        TS12.Enabled = false;
                        TS13.Enabled = false;
                        TS14.Enabled = false;
                        TS15.Enabled = false;
                        TS16.Enabled = false;
                        TS17.Enabled = false;
                        TS18.Enabled = false;
                        txt6.Enabled = false;
                        txt5.Enabled = false;
                        txt4.Enabled = false;

                        TS23.Enabled = false;

                        //Deshabilita los textbox de Octubre
                        TO1.Enabled = true;
                        TO2.Enabled = true;
                        TO3.Enabled = true;
                        TO4.Enabled = true;
                        TO5.Enabled = true;
                        TO6.Enabled = true;
                        TO7.Enabled = true;
                        TO8.Enabled = true;
                        //TxBOctCom.Enabled = true;
                        //TxBOctIng.Enabled = true;

                        T10.Enabled = true;
                        TO11.Enabled = true;
                        TO12.Enabled = true;
                        TO13.Enabled = true;
                        TO14.Enabled = true;
                        TO15.Enabled = true;
                        TO16.Enabled = true;
                        TO17.Enabled = true;
                        TO18.Enabled = true;
                        txt8.Enabled = true;
                        txt9.Enabled = true;
                        txt7.Enabled = true;

                        TO23.Enabled = true;

                        //Deshabilita los textbox de Noviembre
                        TN1.Enabled = false;
                        TN2.Enabled = false;
                        TN3.Enabled = false;
                        TN4.Enabled = false;
                        TN5.Enabled = false;
                        TN6.Enabled = false;
                        TN7.Enabled = false;
                        TN8.Enabled = false;
                        //TxBNovCom.Enabled = false;
                        //TxBNovIng.Enabled = false;

                        TN10.Enabled = false;
                        TN11.Enabled = false;
                        TN12.Enabled = false;
                        TN13.Enabled = false;
                        TN14.Enabled = false;
                        TN15.Enabled = false;
                        TN16.Enabled = false;
                        TN17.Enabled = false;
                        TN18.Enabled = false;
                        txt10.Enabled = false;
                        txt11.Enabled = false;
                        txt12.Enabled = false;

                        TN23.Enabled = false;

                        //Deshabilita los textbox de Diciembre
                        TDD1.Enabled = false;
                        TDD2.Enabled = false;
                        TDD3.Enabled = false;
                        TDD4.Enabled = false;
                        TDD5.Enabled = false;
                        TDD6.Enabled = false;
                        TDD7.Enabled = false;
                        TDD8.Enabled = false;
                        //TxBDicCom.Enabled = false;
                        //TxBDicIng.Enabled = false;

                        TDD10.Enabled = false;
                        TDD11.Enabled = false;
                        TDD12.Enabled = false;
                        TDD13.Enabled = false;
                        TDD14.Enabled = false;
                        TDD15.Enabled = false;
                        TDD16.Enabled = false;
                        TDD17.Enabled = false;
                        TDD18.Enabled = false;
                        txt13.Enabled = false;
                        txt14.Enabled = false;
                        txt15.Enabled = false;

                        TDD23.Enabled = false;

                        //Deshabilita los textbox de Enero
                        TE1.Enabled = false;
                        TE2.Enabled = false;
                        TE3.Enabled = false;
                        TE4.Enabled = false;
                        TE5.Enabled = false;
                        TE6.Enabled = false;
                        TE7.Enabled = false;
                        TE8.Enabled = false;
                        //TxBEneCom.Enabled = false;
                        //TxBEneIng.Enabled = false;

                        TE10.Enabled = false;
                        TE11.Enabled = false;
                        TE12.Enabled = false;
                        TE13.Enabled = false;
                        TE14.Enabled = false;
                        TE15.Enabled = false;
                        TE16.Enabled = false;
                        TE17.Enabled = false;
                        TE18.Enabled = false;
                        txt16.Enabled = false;
                        txt17.Enabled = false;
                        txt18.Enabled = false;

                        TE23.Enabled = false;

                        //Deshabilita los textbox de Febrero
                        TF1.Enabled = false;
                        TF2.Enabled = false;
                        TF3.Enabled = false;
                        TF4.Enabled = false;
                        TF5.Enabled = false;
                        TF6.Enabled = false;
                        TF7.Enabled = false;
                        TF8.Enabled = false;
                        //TxBFebCom.Enabled = false;
                        //TxBFebIng.Enabled = false;

                        TF10.Enabled = false;
                        TF11.Enabled = false;
                        TF12.Enabled = false;
                        TF13.Enabled = false;
                        TF14.Enabled = false;
                        TF15.Enabled = false;
                        TF16.Enabled = false;
                        TF17.Enabled = false;
                        TF18.Enabled = false;
                        textBox31.Enabled = false;
                        textBox32.Enabled = false;
                        textBox33.Enabled = false;

                        TF23.Enabled = false;

                        //Deshabilita los textbox de Marzo
                        TM1.Enabled = false;
                        TM2.Enabled = false;
                        TM3.Enabled = false;
                        TM4.Enabled = false;
                        TM5.Enabled = false;
                        TM6.Enabled = false;
                        TM7.Enabled = false;
                        TM8.Enabled = false;
                        //TxBMarCom.Enabled = false;
                        //TxBMarIng.Enabled = false;

                        TM10.Enabled = false;
                        TM11.Enabled = false;
                        TM12.Enabled = false;
                        TM13.Enabled = false;
                        TM14.Enabled = false;
                        TM15.Enabled = false;
                        TM16.Enabled = false;
                        TM17.Enabled = false;
                        TM18.Enabled = false;
                        textBox28.Enabled = false;
                        textBox29.Enabled = false;
                        textBox30.Enabled = false;

                        TM23.Enabled = false;

                        //Deshabilita los textbox de Abril
                        TA1.Enabled = false;
                        TA2.Enabled = false;
                        TA3.Enabled = false;
                        TA4.Enabled = false;
                        TA5.Enabled = false;
                        TA6.Enabled = false;
                        TA7.Enabled = false;
                        TA8.Enabled = false;
                        //TxBAbrCom.Enabled = false;
                        //TxBAbrIng.Enabled = false;

                        TA10.Enabled = false;
                        TA11.Enabled = false;
                        TA12.Enabled = false;
                        TA13.Enabled = false;
                        TA14.Enabled = false;
                        TA15.Enabled = false;
                        TA16.Enabled = false;
                        TA17.Enabled = false;
                        TA18.Enabled = false;
                        textBox25.Enabled = false;
                        textBox26.Enabled = false;
                        textBox27.Enabled = false;

                        TA23.Enabled = false;

                        //Deshabilita los textbox de Mayo
                        TMA1.Enabled = false;
                        TMA2.Enabled = false;
                        TMA3.Enabled = false;
                        TMA4.Enabled = false;
                        TMA5.Enabled = false;
                        TMA6.Enabled = false;
                        TMA7.Enabled = false;
                        TMA8.Enabled = false;
                        //TxBMayCom.Enabled = false;
                        //TxBMayIng.Enabled = false;

                        TMA10.Enabled = false;
                        TMA11.Enabled = false;
                        TMA12.Enabled = false;
                        TMA13.Enabled = false;
                        TMA14.Enabled = false;
                        TMA15.Enabled = false;
                        TMA16.Enabled = false;
                        TMA17.Enabled = false;
                        TMA18.Enabled = false;
                        textBox22.Enabled = false;
                        textBox23.Enabled = false;
                        textBox24.Enabled = false;

                        TMA23.Enabled = false;


                        //Deshabilita los textbox de Junio
                        TJ1.Enabled = false;
                        TJ2.Enabled = false;
                        TJ3.Enabled = false;
                        TJ4.Enabled = false;
                        TJ5.Enabled = false;
                        TJ6.Enabled = false;
                        TJ7.Enabled = false;
                        TJ8.Enabled = false;
                        //TxBJunCom.Enabled = false;
                        //TxBJunIng.Enabled = false;

                        TJ10.Enabled = false;
                        TJ11.Enabled = false;
                        TJ12.Enabled = false;
                        TJ13.Enabled = false;
                        TJ14.Enabled = false;
                        TJ15.Enabled = false;
                        TJ16.Enabled = false;
                        TJ17.Enabled = false;
                        TJ18.Enabled = false;
                        textBox19.Enabled = false;
                        textBox20.Enabled = false;
                        textBox21.Enabled = false;

                        TJ23.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("El mes de octubre ya no se puede modificar ");
                    }
                }
            }
            if (CBMes.Text == "NOVIEMBRE")
            {
                CBMes.Visible = false;
                label6.Visible = false;
                if (TO1.Text == "" ||
                    TO2.Text == "" ||
                    TO3.Text == "" ||
                    TO4.Text == "" ||
                    TO5.Text == "" ||
                    TO6.Text == "" ||
                    TO7.Text == "" ||
                    TO8.Text == "" ||


                    T10.Text == "" ||
                    TO11.Text == "" ||
                    TO12.Text == "" ||
                    TO13.Text == "" ||
                    TO14.Text == "" ||
                    TO15.Text == "" ||
                    TO16.Text == "" ||
                    TO17.Text == "" ||
                    TO18.Text == "" ||
                    txt9.Text == "" ||
                    txt8.Text == "" ||
                    txt7.Text == "" ||

                    TO23.Text == "")
                {
                    MessageBox.Show("Debe de llenar el Octubre");
                }
                else
                {
                    if (
                    TN1.Text == "" ||
                    TN2.Text == "" ||
                    TN3.Text == "" ||
                    TN4.Text == "" ||
                    TN5.Text == "" ||
                    TN6.Text == "" ||
                    TN7.Text == "" ||
                    TN8.Text == "" ||

                    TN10.Text == "" ||
                    TN11.Text == "" ||
                    TN12.Text == "" ||
                    TN13.Text == "" ||
                    TN14.Text == "" ||
                    TN15.Text == "" ||
                    TN16.Text == "" ||
                    TN17.Text == "" ||
                    TN18.Text == "" ||
                    txt10.Text == "" ||
                    txt11.Text == "" ||
                    txt12.Text == "" ||

                    TN23.Text == "")
                    {
                        TD3.Enabled = false;
                        TD1.Enabled = false;
                        TD3.Enabled = false;
                        TD4.Enabled = false;
                        TD5.Enabled = false;
                        TD6.Enabled = false;
                        TD7.Enabled = false;
                        TD8.Enabled = false;
                        //TxBDiaCom.Enabled = false;
                        //TxBDiaIng.Enabled = false;

                        TD10.Enabled = false;
                        TD11.Enabled = false;
                        TD12.Enabled = false;
                        TD13.Enabled = false;
                        TD14.Enabled = false;
                        TD15.Enabled = false;
                        TD16.Enabled = false;
                        TD17.Enabled = false;
                        TD18.Enabled = false;

                        TD23.Enabled = false;


                        //Deshabilita los textbox de Septiembre
                        TS1.Enabled = false;
                        TS2.Enabled = false;
                        TS3.Enabled = false;
                        TS4.Enabled = false;
                        TS5.Enabled = false;
                        TS6.Enabled = false;
                        TS7.Enabled = false;
                        TS8.Enabled = false;
                        //TxBSepCom.Enabled = false;
                        //TxBSepIng.Enabled = false;

                        TS10.Enabled = false;
                        TS11.Enabled = false;
                        TS12.Enabled = false;
                        TS13.Enabled = false;
                        TS14.Enabled = false;
                        TS15.Enabled = false;
                        TS16.Enabled = false;
                        TS17.Enabled = false;
                        TS18.Enabled = false;

                        TS23.Enabled = false;

                        //Deshabilita los textbox de Octubre
                        TO1.Enabled = false;
                        TO2.Enabled = false;
                        TO3.Enabled = false;
                        TO4.Enabled = false;
                        TO5.Enabled = false;
                        TO6.Enabled = false;
                        TO7.Enabled = false;
                        TO8.Enabled = false;
                        //TxBOctCom.Enabled = false;
                        //TxBOctIng.Enabled = false;

                        T10.Enabled = false;
                        TO11.Enabled = false;
                        TO12.Enabled = false;
                        TO13.Enabled = false;
                        TO14.Enabled = false;
                        TO15.Enabled = false;
                        TO16.Enabled = false;
                        TO17.Enabled = false;
                        TO18.Enabled = false;
                        txt8.Enabled = false;
                        txt9.Enabled = false;
                        txt7.Enabled = false;

                        TO23.Enabled = false;

                        //Deshabilita los textbox de Noviembre
                        TN1.Enabled = true;
                        TN2.Enabled = true;
                        TN3.Enabled = true;
                        TN4.Enabled = true;
                        TN5.Enabled = true;
                        TN6.Enabled = true;
                        TN7.Enabled = true;
                        TN8.Enabled = true;
                        //TxBNovCom.Enabled = true;
                        //TxBNovIng.Enabled = true;

                        TN10.Enabled = true;
                        TN11.Enabled = true;
                        TN12.Enabled = true;
                        TN13.Enabled = true;
                        TN14.Enabled = true;
                        TN15.Enabled = true;
                        TN16.Enabled = true;
                        TN17.Enabled = true;
                        TN18.Enabled = true;
                        txt10.Enabled = true;
                        txt11.Enabled = true;
                        txt12.Enabled = true;

                        TN23.Enabled = true;

                        //Deshabilita los textbox de Diciembre
                        TDD1.Enabled = false;
                        TDD2.Enabled = false;
                        TDD3.Enabled = false;
                        TDD4.Enabled = false;
                        TDD5.Enabled = false;
                        TDD6.Enabled = false;
                        TDD7.Enabled = false;
                        TDD8.Enabled = false;
                        //TxBDicCom.Enabled = false;
                        //TxBDicIng.Enabled = false;

                        TDD10.Enabled = false;
                        TDD11.Enabled = false;
                        TDD12.Enabled = false;
                        TDD13.Enabled = false;
                        TDD14.Enabled = false;
                        TDD15.Enabled = false;
                        TDD16.Enabled = false;
                        TDD17.Enabled = false;
                        TDD18.Enabled = false;
                        txt13.Enabled = false;
                        txt14.Enabled = false;
                        txt15.Enabled = false;

                        TDD23.Enabled = false;

                        //Deshabilita los textbox de Enero
                        TE1.Enabled = false;
                        TE2.Enabled = false;
                        TE3.Enabled = false;
                        TE4.Enabled = false;
                        TE5.Enabled = false;
                        TE6.Enabled = false;
                        TE7.Enabled = false;
                        TE8.Enabled = false;
                        //TxBEneCom.Enabled = false;
                        //TxBEneIng.Enabled = false;

                        TE10.Enabled = false;
                        TE11.Enabled = false;
                        TE12.Enabled = false;
                        TE13.Enabled = false;
                        TE14.Enabled = false;
                        TE15.Enabled = false;
                        TE16.Enabled = false;
                        TE17.Enabled = false;
                        TE18.Enabled = false;
                        txt16.Enabled = false;
                        txt17.Enabled = false;
                        txt18.Enabled = false;

                        TE23.Enabled = false;

                        //Deshabilita los textbox de Febrero
                        TF1.Enabled = false;
                        TF2.Enabled = false;
                        TF3.Enabled = false;
                        TF4.Enabled = false;
                        TF5.Enabled = false;
                        TF6.Enabled = false;
                        TF7.Enabled = false;
                        TF8.Enabled = false;
                        //TxBFebCom.Enabled = false;
                        //TxBFebIng.Enabled = false;

                        TF10.Enabled = false;
                        TF11.Enabled = false;
                        TF12.Enabled = false;
                        TF13.Enabled = false;
                        TF14.Enabled = false;
                        TF15.Enabled = false;
                        TF16.Enabled = false;
                        TF17.Enabled = false;
                        TF18.Enabled = false;
                        textBox31.Enabled = false;
                        textBox32.Enabled = false;
                        textBox33.Enabled = false;

                        TF23.Enabled = false;

                        //Deshabilita los textbox de Marzo
                        TM1.Enabled = false;
                        TM2.Enabled = false;
                        TM3.Enabled = false;
                        TM4.Enabled = false;
                        TM5.Enabled = false;
                        TM6.Enabled = false;
                        TM7.Enabled = false;
                        TM8.Enabled = false;
                        //TxBMarCom.Enabled = false;
                        //TxBMarIng.Enabled = false;

                        TM10.Enabled = false;
                        TM11.Enabled = false;
                        TM12.Enabled = false;
                        TM13.Enabled = false;
                        TM14.Enabled = false;
                        TM15.Enabled = false;
                        TM16.Enabled = false;
                        TM17.Enabled = false;
                        TM18.Enabled = false;
                        textBox28.Enabled = false;
                        textBox29.Enabled = false;
                        textBox30.Enabled = false;

                        TM23.Enabled = false;

                        //Deshabilita los textbox de Abril
                        TA1.Enabled = false;
                        TA2.Enabled = false;
                        TA3.Enabled = false;
                        TA4.Enabled = false;
                        TA5.Enabled = false;
                        TA6.Enabled = false;
                        TA7.Enabled = false;
                        TA8.Enabled = false;
                        //TxBAbrCom.Enabled = false;
                        //TxBAbrIng.Enabled = false;

                        TA10.Enabled = false;
                        TA11.Enabled = false;
                        TA12.Enabled = false;
                        TA13.Enabled = false;
                        TA14.Enabled = false;
                        TA15.Enabled = false;
                        TA16.Enabled = false;
                        TA17.Enabled = false;
                        TA18.Enabled = false;
                        textBox25.Enabled = false;
                        textBox26.Enabled = false;
                        textBox27.Enabled = false;

                        TA23.Enabled = false;

                        //Deshabilita los textbox de Mayo
                        TMA1.Enabled = false;
                        TMA2.Enabled = false;
                        TMA3.Enabled = false;
                        TMA4.Enabled = false;
                        TMA5.Enabled = false;
                        TMA6.Enabled = false;
                        TMA7.Enabled = false;
                        TMA8.Enabled = false;
                        //TxBMayCom.Enabled = false;
                        //TxBMayIng.Enabled = false;

                        TMA10.Enabled = false;
                        TMA11.Enabled = false;
                        TMA12.Enabled = false;
                        TMA13.Enabled = false;
                        TMA14.Enabled = false;
                        TMA15.Enabled = false;
                        TMA16.Enabled = false;
                        TMA17.Enabled = false;
                        TMA18.Enabled = false;
                        textBox22.Enabled = false;
                        textBox23.Enabled = false;
                        textBox24.Enabled = false;

                        TMA23.Enabled = false;


                        //Deshabilita los textbox de Junio
                        TJ1.Enabled = false;
                        TJ2.Enabled = false;
                        TJ3.Enabled = false;
                        TJ4.Enabled = false;
                        TJ5.Enabled = false;
                        TJ6.Enabled = false;
                        TJ7.Enabled = false;
                        TJ8.Enabled = false;
                        //TxBJunCom.Enabled = false;
                        //TxBJunIng.Enabled = false;

                        TJ10.Enabled = false;
                        TJ11.Enabled = false;
                        TJ12.Enabled = false;
                        TJ13.Enabled = false;
                        TJ14.Enabled = false;
                        TJ15.Enabled = false;
                        TJ16.Enabled = false;
                        TJ17.Enabled = false;
                        TJ18.Enabled = false;
                        textBox19.Enabled = false;
                        textBox20.Enabled = false;
                        textBox21.Enabled = false;

                        TJ23.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("No se puede modificar este mes");
                    }
                }
            }
            if (CBMes.Text == "DICIEMBRE")
            {
                label6.Visible = false;
                CBMes.Visible = false;
                if (TN1.Text == "" ||
                TN2.Text == "" ||
                TN3.Text == "" ||
                TN4.Text == "" ||
                TN5.Text == "" ||
                TN6.Text == "" ||
                TN7.Text == "" ||
                TN8.Text == "" ||

                TN10.Text == "" ||
                TN11.Text == "" ||
                TN12.Text == "" ||
                TN13.Text == "" ||
                TN14.Text == "" ||
                TN15.Text == "" ||
                TN16.Text == "" ||
                TN17.Text == "" ||
                TN18.Text == "" ||
                txt10.Text == "" ||
                txt11.Text == "" ||
                txt12.Text == "" ||

                TN23.Text == "")
                {
                    MessageBox.Show("Debe llenar primero Noviembre");
                }
                else
                {
                    if (
                    TDD1.Text == "" ||
                    TDD2.Text == "" ||
                    TDD3.Text == "" ||
                    TDD4.Text == "" ||
                    TDD5.Text == "" ||
                    TDD6.Text == "" ||
                    TDD7.Text == "" ||
                    TDD8.Text == "" ||

                    TDD10.Text == "" ||
                    TDD11.Text == "" ||
                    TDD12.Text == "" ||
                    TDD13.Text == "" ||
                    TDD14.Text == "" ||
                    TDD15.Text == "" ||
                    TDD16.Text == "" ||
                    TDD17.Text == "" ||
                    TDD18.Text == "" ||
                    txt13.Text == "" ||
                    txt14.Text == "" ||
                    txt15.Text == "" ||

                    TDD23.Text == "")
                    {
                        TD3.Enabled = false;
                        TD1.Enabled = false;
                        TD3.Enabled = false;
                        TD4.Enabled = false;
                        TD5.Enabled = false;
                        TD6.Enabled = false;
                        TD7.Enabled = false;
                        TD8.Enabled = false;
                        //TxBDiaCom.Enabled = false;
                        //TxBDiaIng.Enabled = false;

                        TD10.Enabled = false;
                        TD11.Enabled = false;
                        TD12.Enabled = false;
                        TD13.Enabled = false;
                        TD14.Enabled = false;
                        TD15.Enabled = false;
                        TD16.Enabled = false;
                        TD17.Enabled = false;
                        TD18.Enabled = false;

                        TD23.Enabled = false;


                        //Deshabilita los textbox de Septiembre
                        TS1.Enabled = false;
                        TS2.Enabled = false;
                        TS3.Enabled = false;
                        TS4.Enabled = false;
                        TS5.Enabled = false;
                        TS6.Enabled = false;
                        TS7.Enabled = false;
                        TS8.Enabled = false;
                        //TxBSepCom.Enabled = false;
                        //TxBSepIng.Enabled = false;

                        TS10.Enabled = false;
                        TS11.Enabled = false;
                        TS12.Enabled = false;
                        TS13.Enabled = false;
                        TS14.Enabled = false;
                        TS15.Enabled = false;
                        TS16.Enabled = false;
                        TS17.Enabled = false;
                        TS18.Enabled = false;

                        TS23.Enabled = false;

                        //Deshabilita los textbox de Octubre
                        TO1.Enabled = false;
                        TO2.Enabled = false;
                        TO3.Enabled = false;
                        TO4.Enabled = false;
                        TO5.Enabled = false;
                        TO6.Enabled = false;
                        TO7.Enabled = false;
                        TO8.Enabled = false;
                        //TxBOctCom.Enabled = false;
                        //TxBOctIng.Enabled = false;

                        T10.Enabled = false;
                        TO11.Enabled = false;
                        TO12.Enabled = false;
                        TO13.Enabled = false;
                        TO14.Enabled = false;
                        TO15.Enabled = false;
                        TO16.Enabled = false;
                        TO17.Enabled = false;
                        TO18.Enabled = false;
                        txt8.Enabled = false;
                        txt9.Enabled = false;
                        txt7.Enabled = false;

                        TO23.Enabled = false;

                        //Deshabilita los textbox de Noviembre
                        TN1.Enabled = false;
                        TN2.Enabled = false;
                        TN3.Enabled = false;
                        TN4.Enabled = false;
                        TN5.Enabled = false;
                        TN6.Enabled = false;
                        TN7.Enabled = false;
                        TN8.Enabled = false;
                        //TxBNovCom.Enabled = false;
                        //TxBNovIng.Enabled = false;

                        TN10.Enabled = false;
                        TN11.Enabled = false;
                        TN12.Enabled = false;
                        TN13.Enabled = false;
                        TN14.Enabled = false;
                        TN15.Enabled = false;
                        TN16.Enabled = false;
                        TN17.Enabled = false;
                        TN18.Enabled = false;
                        txt10.Enabled = false;
                        txt11.Enabled = false;
                        txt12.Enabled = false;

                        TN23.Enabled = false;

                        //Deshabilita los textbox de Diciembre
                        TDD1.Enabled = true;
                        TDD2.Enabled = true;
                        TDD3.Enabled = true;
                        TDD4.Enabled = true;
                        TDD5.Enabled = true;
                        TDD6.Enabled = true;
                        TDD7.Enabled = true;
                        TDD8.Enabled = true;
                        //TxBDicCom.Enabled = true;
                        //TxBDicIng.Enabled = true;

                        TDD10.Enabled = true;
                        TDD11.Enabled = true;
                        TDD12.Enabled = true;
                        TDD13.Enabled = true;
                        TDD14.Enabled = true;
                        TDD15.Enabled = true;
                        TDD16.Enabled = true;
                        TDD17.Enabled = true;
                        TDD18.Enabled = true;
                        txt13.Enabled = true;
                        txt14.Enabled = true;
                        txt15.Enabled = true;

                        TDD23.Enabled = true;

                        //Deshabilita los textbox de Enero
                        TE1.Enabled = false;
                        TE2.Enabled = false;
                        TE3.Enabled = false;
                        TE4.Enabled = false;
                        TE5.Enabled = false;
                        TE6.Enabled = false;
                        TE7.Enabled = false;
                        TE8.Enabled = false;
                        //TxBEneCom.Enabled = false;
                        //TxBEneIng.Enabled = false;

                        TE10.Enabled = false;
                        TE11.Enabled = false;
                        TE12.Enabled = false;
                        TE13.Enabled = false;
                        TE14.Enabled = false;
                        TE15.Enabled = false;
                        TE16.Enabled = false;
                        TE17.Enabled = false;
                        TE18.Enabled = false;
                        txt16.Enabled = false;
                        txt17.Enabled = false;
                        txt18.Enabled = false;

                        TE23.Enabled = false;

                        //Deshabilita los textbox de Febrero
                        TF1.Enabled = false;
                        TF2.Enabled = false;
                        TF3.Enabled = false;
                        TF4.Enabled = false;
                        TF5.Enabled = false;
                        TF6.Enabled = false;
                        TF7.Enabled = false;
                        TF8.Enabled = false;
                        //TxBFebCom.Enabled = false;
                        //TxBFebIng.Enabled = false;

                        TF10.Enabled = false;
                        TF11.Enabled = false;
                        TF12.Enabled = false;
                        TF13.Enabled = false;
                        TF14.Enabled = false;
                        TF15.Enabled = false;
                        TF16.Enabled = false;
                        TF17.Enabled = false;
                        TF18.Enabled = false;
                        textBox31.Enabled = false;
                        textBox32.Enabled = false;
                        textBox33.Enabled = false;

                        TF23.Enabled = false;

                        //Deshabilita los textbox de Marzo
                        TM1.Enabled = false;
                        TM2.Enabled = false;
                        TM3.Enabled = false;
                        TM4.Enabled = false;
                        TM5.Enabled = false;
                        TM6.Enabled = false;
                        TM7.Enabled = false;
                        TM8.Enabled = false;
                        //TxBMarCom.Enabled = false;
                        //TxBMarIng.Enabled = false;

                        TM10.Enabled = false;
                        TM11.Enabled = false;
                        TM12.Enabled = false;
                        TM13.Enabled = false;
                        TM14.Enabled = false;
                        TM15.Enabled = false;
                        TM16.Enabled = false;
                        TM17.Enabled = false;
                        TM18.Enabled = false;
                        textBox28.Enabled = false;
                        textBox29.Enabled = false;
                        textBox30.Enabled = false;

                        TM23.Enabled = false;

                        //Deshabilita los textbox de Abril
                        TA1.Enabled = false;
                        TA2.Enabled = false;
                        TA3.Enabled = false;
                        TA4.Enabled = false;
                        TA5.Enabled = false;
                        TA6.Enabled = false;
                        TA7.Enabled = false;
                        TA8.Enabled = false;
                        //TxBAbrCom.Enabled = false;
                        //TxBAbrIng.Enabled = false;

                        TA10.Enabled = false;
                        TA11.Enabled = false;
                        TA12.Enabled = false;
                        TA13.Enabled = false;
                        TA14.Enabled = false;
                        TA15.Enabled = false;
                        TA16.Enabled = false;
                        TA17.Enabled = false;
                        TA18.Enabled = false;
                        textBox25.Enabled = false;
                        textBox26.Enabled = false;
                        textBox27.Enabled = false;

                        TA23.Enabled = false;

                        //Deshabilita los textbox de Mayo
                        TMA1.Enabled = false;
                        TMA2.Enabled = false;
                        TMA3.Enabled = false;
                        TMA4.Enabled = false;
                        TMA5.Enabled = false;
                        TMA6.Enabled = false;
                        TMA7.Enabled = false;
                        TMA8.Enabled = false;
                        //TxBMayCom.Enabled = false;
                        //TxBMayIng.Enabled = false;

                        TMA10.Enabled = false;
                        TMA11.Enabled = false;
                        TMA12.Enabled = false;
                        TMA13.Enabled = false;
                        TMA14.Enabled = false;
                        TMA15.Enabled = false;
                        TMA16.Enabled = false;
                        TMA17.Enabled = false;
                        TMA18.Enabled = false;
                        textBox22.Enabled = false;
                        textBox23.Enabled = false;
                        textBox24.Enabled = false;

                        TMA23.Enabled = false;


                        //Deshabilita los textbox de Junio
                        TJ1.Enabled = false;
                        TJ2.Enabled = false;
                        TJ3.Enabled = false;
                        TJ4.Enabled = false;
                        TJ5.Enabled = false;
                        TJ6.Enabled = false;
                        TJ7.Enabled = false;
                        TJ8.Enabled = false;
                        //TxBJunCom.Enabled = false;
                        //TxBJunIng.Enabled = false;

                        TJ10.Enabled = false;
                        TJ11.Enabled = false;
                        TJ12.Enabled = false;
                        TJ13.Enabled = false;
                        TJ14.Enabled = false;
                        TJ15.Enabled = false;
                        TJ16.Enabled = false;
                        TJ17.Enabled = false;
                        TJ18.Enabled = false;
                        textBox19.Enabled = false;
                        textBox20.Enabled = false;
                        textBox21.Enabled = false;

                        TJ23.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Este mes no se puede modifcar");
                    }
                }
            }
            if (CBMes.Text == "ENERO")
            {
                label6.Visible = false;
                CBMes.Visible = false;
                if (TDD1.Text == "" ||
                TDD2.Text == "" ||
                TDD3.Text == "" ||
                TDD4.Text == "" ||
                TDD5.Text == "" ||
                TDD6.Text == "" ||
                TDD7.Text == "" ||
                TDD8.Text == "" ||

                TDD10.Text == "" ||
                TDD11.Text == "" ||
                TDD12.Text == "" ||
                TDD13.Text == "" ||
                TDD14.Text == "" ||
                TDD15.Text == "" ||
                TDD16.Text == "" ||
                TDD17.Text == "" ||
                TDD18.Text == "" ||
                txt13.Text == "" ||
                txt14.Text == "" ||
                txt15.Text == "" ||

                TDD23.Text == "")
                {
                    MessageBox.Show("Debe llenar primero Diciembre");
                }
                else
                {
                    if (
                    TE1.Text == "" ||
                    TE2.Text == "" ||
                    TE3.Text == "" ||
                    TE4.Text == "" ||
                    TE5.Text == "" ||
                    TE6.Text == "" ||
                    TE7.Text == "" ||
                    TE8.Text == "" ||

                    TE10.Text == "" ||
                    TE11.Text == "" ||
                    TE12.Text == "" ||
                    TE13.Text == "" ||
                    TE14.Text == "" ||
                    TE15.Text == "" ||
                    TE16.Text == "" ||
                    TE17.Text == "" ||
                    TE18.Text == "" ||
                    txt16.Text == "" ||
                    txt17.Text == "" ||
                    txt18.Text == "" ||

                    TE23.Text == "")
                    {
                        TD3.Enabled = false;
                        TD1.Enabled = false;
                        TD3.Enabled = false;
                        TD4.Enabled = false;
                        TD5.Enabled = false;
                        TD6.Enabled = false;
                        TD7.Enabled = false;
                        TD8.Enabled = false;
                        //TxBDiaCom.Enabled = false;
                        //TxBDiaIng.Enabled = false;

                        TD10.Enabled = false;
                        TD11.Enabled = false;
                        TD12.Enabled = false;
                        TD13.Enabled = false;
                        TD14.Enabled = false;
                        TD15.Enabled = false;
                        TD16.Enabled = false;
                        TD17.Enabled = false;
                        TD18.Enabled = false;

                        TD23.Enabled = false;


                        //Deshabilita los textbox de Septiembre
                        TS1.Enabled = false;
                        TS2.Enabled = false;
                        TS3.Enabled = false;
                        TS4.Enabled = false;
                        TS5.Enabled = false;
                        TS6.Enabled = false;
                        TS7.Enabled = false;
                        TS8.Enabled = false;
                        //TxBSepCom.Enabled = false;
                        //TxBSepIng.Enabled = false;

                        TS10.Enabled = false;
                        TS11.Enabled = false;
                        TS12.Enabled = false;
                        TS13.Enabled = false;
                        TS14.Enabled = false;
                        TS15.Enabled = false;
                        TS16.Enabled = false;
                        TS17.Enabled = false;
                        TS18.Enabled = false;

                        TS23.Enabled = false;

                        //Deshabilita los textbox de Octubre
                        TO1.Enabled = false;
                        TO2.Enabled = false;
                        TO3.Enabled = false;
                        TO4.Enabled = false;
                        TO5.Enabled = false;
                        TO6.Enabled = false;
                        TO7.Enabled = false;
                        TO8.Enabled = false;
                        //TxBOctCom.Enabled = false;
                        //TxBOctIng.Enabled = false;

                        T10.Enabled = false;
                        TO11.Enabled = false;
                        TO12.Enabled = false;
                        TO13.Enabled = false;
                        TO14.Enabled = false;
                        TO15.Enabled = false;
                        TO16.Enabled = false;
                        TO17.Enabled = false;
                        TO18.Enabled = false;
                        txt8.Enabled = false;
                        txt9.Enabled = false;
                        txt7.Enabled = false;

                        TO23.Enabled = false;

                        //Deshabilita los textbox de Noviembre
                        TN1.Enabled = false;
                        TN2.Enabled = false;
                        TN3.Enabled = false;
                        TN4.Enabled = false;
                        TN5.Enabled = false;
                        TN6.Enabled = false;
                        TN7.Enabled = false;
                        TN8.Enabled = false;
                        //TxBNovCom.Enabled = false;
                        //TxBNovIng.Enabled = false;

                        TN10.Enabled = false;
                        TN11.Enabled = false;
                        TN12.Enabled = false;
                        TN13.Enabled = false;
                        TN14.Enabled = false;
                        TN15.Enabled = false;
                        TN16.Enabled = false;
                        TN17.Enabled = false;
                        TN18.Enabled = false;
                        txt10.Enabled = false;
                        txt11.Enabled = false;
                        txt12.Enabled = false;

                        TN23.Enabled = false;

                        //Deshabilita los textbox de Diciembre
                        TDD1.Enabled = false;
                        TDD2.Enabled = false;
                        TDD3.Enabled = false;
                        TDD4.Enabled = false;
                        TDD5.Enabled = false;
                        TDD6.Enabled = false;
                        TDD7.Enabled = false;
                        TDD8.Enabled = false;
                        //TxBDicCom.Enabled = false;
                        //TxBDicIng.Enabled = false;

                        TDD10.Enabled = false;
                        TDD11.Enabled = false;
                        TDD12.Enabled = false;
                        TDD13.Enabled = false;
                        TDD14.Enabled = false;
                        TDD15.Enabled = false;
                        TDD16.Enabled = false;
                        TDD17.Enabled = false;
                        TDD18.Enabled = false;
                        txt13.Enabled = false;
                        txt14.Enabled = false;
                        txt15.Enabled = false;

                        TDD23.Enabled = false;

                        //Deshabilita los textbox de Enero
                        TE1.Enabled = true;
                        TE2.Enabled = true;
                        TE3.Enabled = true;
                        TE4.Enabled = true;
                        TE5.Enabled = true;
                        TE6.Enabled = true;
                        TE7.Enabled = true;
                        TE8.Enabled = true;
                        //TxBEneCom.Enabled = true;
                        //TxBEneIng.Enabled = true;

                        TE10.Enabled = true;
                        TE11.Enabled = true;
                        TE12.Enabled = true;
                        TE13.Enabled = true;
                        TE14.Enabled = true;
                        TE15.Enabled = true;
                        TE16.Enabled = true;
                        TE17.Enabled = true;
                        TE18.Enabled = true;
                        txt16.Enabled = true;
                        txt17.Enabled = true;
                        txt18.Enabled = true;

                        TE23.Enabled = true;

                        //Deshabilita los textbox de Febrero
                        TF1.Enabled = false;
                        TF2.Enabled = false;
                        TF3.Enabled = false;
                        TF4.Enabled = false;
                        TF5.Enabled = false;
                        TF6.Enabled = false;
                        TF7.Enabled = false;
                        TF8.Enabled = false;
                        //TxBFebCom.Enabled = false;
                        //TxBFebIng.Enabled = false;

                        TF10.Enabled = false;
                        TF11.Enabled = false;
                        TF12.Enabled = false;
                        TF13.Enabled = false;
                        TF14.Enabled = false;
                        TF15.Enabled = false;
                        TF16.Enabled = false;
                        TF17.Enabled = false;
                        TF18.Enabled = false;
                        textBox31.Enabled = false;
                        textBox32.Enabled = false;
                        textBox33.Enabled = false;

                        TF23.Enabled = false;

                        //Deshabilita los textbox de Marzo
                        TM1.Enabled = false;
                        TM2.Enabled = false;
                        TM3.Enabled = false;
                        TM4.Enabled = false;
                        TM5.Enabled = false;
                        TM6.Enabled = false;
                        TM7.Enabled = false;
                        TM8.Enabled = false;
                        //TxBMarCom.Enabled = false;
                        //TxBMarIng.Enabled = false;

                        TM10.Enabled = false;
                        TM11.Enabled = false;
                        TM12.Enabled = false;
                        TM13.Enabled = false;
                        TM14.Enabled = false;
                        TM15.Enabled = false;
                        TM16.Enabled = false;
                        TM17.Enabled = false;
                        TM18.Enabled = false;
                        textBox28.Enabled = false;
                        textBox29.Enabled = false;
                        textBox30.Enabled = false;

                        TM23.Enabled = false;

                        //Deshabilita los textbox de Abril
                        TA1.Enabled = false;
                        TA2.Enabled = false;
                        TA3.Enabled = false;
                        TA4.Enabled = false;
                        TA5.Enabled = false;
                        TA6.Enabled = false;
                        TA7.Enabled = false;
                        TA8.Enabled = false;
                        //TxBAbrCom.Enabled = false;
                        //TxBAbrIng.Enabled = false;

                        TA10.Enabled = false;
                        TA11.Enabled = false;
                        TA12.Enabled = false;
                        TA13.Enabled = false;
                        TA14.Enabled = false;
                        TA15.Enabled = false;
                        TA16.Enabled = false;
                        TA17.Enabled = false;
                        TA18.Enabled = false;
                        textBox25.Enabled = false;
                        textBox26.Enabled = false;
                        textBox27.Enabled = false;

                        TA23.Enabled = false;

                        //Deshabilita los textbox de Mayo
                        TMA1.Enabled = false;
                        TMA2.Enabled = false;
                        TMA3.Enabled = false;
                        TMA4.Enabled = false;
                        TMA5.Enabled = false;
                        TMA6.Enabled = false;
                        TMA7.Enabled = false;
                        TMA8.Enabled = false;
                        //TxBMayCom.Enabled = false;
                        //TxBMayIng.Enabled = false;

                        TMA10.Enabled = false;
                        TMA11.Enabled = false;
                        TMA12.Enabled = false;
                        TMA13.Enabled = false;
                        TMA14.Enabled = false;
                        TMA15.Enabled = false;
                        TMA16.Enabled = false;
                        TMA17.Enabled = false;
                        TMA18.Enabled = false;
                        textBox22.Enabled = false;
                        textBox23.Enabled = false;
                        textBox24.Enabled = false;

                        TMA23.Enabled = false;


                        //Deshabilita los textbox de Junio
                        TJ1.Enabled = false;
                        TJ2.Enabled = false;
                        TJ3.Enabled = false;
                        TJ4.Enabled = false;
                        TJ5.Enabled = false;
                        TJ6.Enabled = false;
                        TJ7.Enabled = false;
                        TJ8.Enabled = false;
                        //TxBJunCom.Enabled = false;
                        //TxBJunIng.Enabled = false;

                        TJ10.Enabled = false;
                        TJ11.Enabled = false;
                        TJ12.Enabled = false;
                        TJ13.Enabled = false;
                        TJ14.Enabled = false;
                        TJ15.Enabled = false;
                        TJ16.Enabled = false;
                        TJ17.Enabled = false;
                        TJ18.Enabled = false;
                        textBox19.Enabled = false;
                        textBox20.Enabled = false;
                        textBox21.Enabled = false;

                        TJ23.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Este mes ya no se puede modifcar");
                    }
                }
            }
            if (CBMes.Text == "FEBRERO")
            {
                label6.Visible = false;
                CBMes.Visible = false;
                if (TE1.Text == "" ||
                TE2.Text == "" ||
                TE3.Text == "" ||
                TE4.Text == "" ||
                TE5.Text == "" ||
                TE6.Text == "" ||
                TE7.Text == "" ||
                TE8.Text == "" ||

                TE10.Text == "" ||
                TE11.Text == "" ||
                TE12.Text == "" ||
                TE13.Text == "" ||
                TE14.Text == "" ||
                TE15.Text == "" ||
                TE16.Text == "" ||
                TE17.Text == "" ||
                TE18.Text == "" ||
                txt16.Text == "" ||
                txt17.Text == "" ||
                txt18.Text == "" ||

                TE23.Text == "")
                {
                    MessageBox.Show("Debe llenar primero Enero");
                }
                else
                {
                    if (
                    TF1.Text == "" ||
                    TF2.Text == "" ||
                    TF3.Text == "" ||
                    TF4.Text == "" ||
                    TF5.Text == "" ||
                    TF6.Text == "" ||
                    TF7.Text == "" ||
                    TF8.Text == "" ||

                    TF10.Text == "" ||
                    TF11.Text == "" ||
                    TF12.Text == "" ||
                    TF13.Text == "" ||
                    TF14.Text == "" ||
                    TF15.Text == "" ||
                    TF16.Text == "" ||
                    TF17.Text == "" ||
                    TF18.Text == "" ||
                    textBox31.Text == "" ||
                    textBox32.Text == "" ||
                    textBox33.Text == "" ||

                    TF23.Text == "")
                    {
                        TD3.Enabled = false;
                        TD1.Enabled = false;
                        TD3.Enabled = false;
                        TD4.Enabled = false;
                        TD5.Enabled = false;
                        TD6.Enabled = false;
                        TD7.Enabled = false;
                        TD8.Enabled = false;
                        //TxBDiaCom.Enabled = false;
                        //TxBDiaIng.Enabled = false;

                        TD10.Enabled = false;
                        TD11.Enabled = false;
                        TD12.Enabled = false;
                        TD13.Enabled = false;
                        TD14.Enabled = false;
                        TD15.Enabled = false;
                        TD16.Enabled = false;
                        TD17.Enabled = false;
                        TD18.Enabled = false;

                        TD23.Enabled = false;


                        //Deshabilita los textbox de Septiembre
                        TS1.Enabled = false;
                        TS2.Enabled = false;
                        TS3.Enabled = false;
                        TS4.Enabled = false;
                        TS5.Enabled = false;
                        TS6.Enabled = false;
                        TS7.Enabled = false;
                        TS8.Enabled = false;
                        //TxBSepCom.Enabled = false;
                        //TxBSepIng.Enabled = false;

                        TS10.Enabled = false;
                        TS11.Enabled = false;
                        TS12.Enabled = false;
                        TS13.Enabled = false;
                        TS14.Enabled = false;
                        TS15.Enabled = false;
                        TS16.Enabled = false;
                        TS17.Enabled = false;
                        TS18.Enabled = false;

                        TS23.Enabled = false;

                        //Deshabilita los textbox de Octubre
                        TO1.Enabled = false;
                        TO2.Enabled = false;
                        TO3.Enabled = false;
                        TO4.Enabled = false;
                        TO5.Enabled = false;
                        TO6.Enabled = false;
                        TO7.Enabled = false;
                        TO8.Enabled = false;
                        //TxBOctCom.Enabled = false;
                        //TxBOctIng.Enabled = false;

                        T10.Enabled = false;
                        TO11.Enabled = false;
                        TO12.Enabled = false;
                        TO13.Enabled = false;
                        TO14.Enabled = false;
                        TO15.Enabled = false;
                        TO16.Enabled = false;
                        TO17.Enabled = false;
                        TO18.Enabled = false;
                        txt8.Enabled = false;
                        txt9.Enabled = false;
                        txt7.Enabled = false;

                        TO23.Enabled = false;

                        //Deshabilita los textbox de Noviembre
                        TN1.Enabled = false;
                        TN2.Enabled = false;
                        TN3.Enabled = false;
                        TN4.Enabled = false;
                        TN5.Enabled = false;
                        TN6.Enabled = false;
                        TN7.Enabled = false;
                        TN8.Enabled = false;
                        //TxBNovCom.Enabled = false;
                        //TxBNovIng.Enabled = false;

                        TN10.Enabled = false;
                        TN11.Enabled = false;
                        TN12.Enabled = false;
                        TN13.Enabled = false;
                        TN14.Enabled = false;
                        TN15.Enabled = false;
                        TN16.Enabled = false;
                        TN17.Enabled = false;
                        TN18.Enabled = false;
                        txt10.Enabled = false;
                        txt11.Enabled = false;
                        txt12.Enabled = false;

                        TN23.Enabled = false;

                        //Deshabilita los textbox de Diciembre
                        TDD1.Enabled = false;
                        TDD2.Enabled = false;
                        TDD3.Enabled = false;
                        TDD4.Enabled = false;
                        TDD5.Enabled = false;
                        TDD6.Enabled = false;
                        TDD7.Enabled = false;
                        TDD8.Enabled = false;
                        //TxBDicCom.Enabled = false;
                        //TxBDicIng.Enabled = false;

                        TDD10.Enabled = false;
                        TDD11.Enabled = false;
                        TDD12.Enabled = false;
                        TDD13.Enabled = false;
                        TDD14.Enabled = false;
                        TDD15.Enabled = false;
                        TDD16.Enabled = false;
                        TDD17.Enabled = false;
                        TDD18.Enabled = false;
                        txt13.Enabled = false;
                        txt14.Enabled = false;
                        txt15.Enabled = false;

                        TDD23.Enabled = false;

                        //Deshabilita los textbox de Enero
                        TE1.Enabled = false;
                        TE2.Enabled = false;
                        TE3.Enabled = false;
                        TE4.Enabled = false;
                        TE5.Enabled = false;
                        TE6.Enabled = false;
                        TE7.Enabled = false;
                        TE8.Enabled = false;
                        //TxBEneCom.Enabled = false;
                        //TxBEneIng.Enabled = false;

                        TE10.Enabled = false;
                        TE11.Enabled = false;
                        TE12.Enabled = false;
                        TE13.Enabled = false;
                        TE14.Enabled = false;
                        TE15.Enabled = false;
                        TE16.Enabled = false;
                        TE17.Enabled = false;
                        TE18.Enabled = false;
                        txt16.Enabled = false;
                        txt17.Enabled = false;
                        txt18.Enabled = false;

                        TE23.Enabled = false;

                        //Deshabilita los textbox de Febrero
                        TF1.Enabled = true;
                        TF2.Enabled = true;
                        TF3.Enabled = true;
                        TF4.Enabled = true;
                        TF5.Enabled = true;
                        TF6.Enabled = true;
                        TF7.Enabled = true;
                        TF8.Enabled = true;
                        //TxBFebCom.Enabled = true;
                        //TxBFebIng.Enabled = true;

                        TF10.Enabled = true;
                        TF11.Enabled = true;
                        TF12.Enabled = true;
                        TF13.Enabled = true;
                        TF14.Enabled = true;
                        TF15.Enabled = true;
                        TF16.Enabled = true;
                        TF17.Enabled = true;
                        TF18.Enabled = true;
                        textBox31.Enabled = true;
                        textBox32.Enabled = true;
                        textBox33.Enabled = true;

                        TF23.Enabled = true;

                        //Deshabilita los textbox de Marzo
                        TM1.Enabled = false;
                        TM2.Enabled = false;
                        TM3.Enabled = false;
                        TM4.Enabled = false;
                        TM5.Enabled = false;
                        TM6.Enabled = false;
                        TM7.Enabled = false;
                        TM8.Enabled = false;
                        //TxBMarCom.Enabled = false;
                        //TxBMarIng.Enabled = false;

                        TM10.Enabled = false;
                        TM11.Enabled = false;
                        TM12.Enabled = false;
                        TM13.Enabled = false;
                        TM14.Enabled = false;
                        TM15.Enabled = false;
                        TM16.Enabled = false;
                        TM17.Enabled = false;
                        TM18.Enabled = false;
                        textBox28.Enabled = false;
                        textBox29.Enabled = false;
                        textBox30.Enabled = false;

                        TM23.Enabled = false;

                        //Deshabilita los textbox de Abril
                        TA1.Enabled = false;
                        TA2.Enabled = false;
                        TA3.Enabled = false;
                        TA4.Enabled = false;
                        TA5.Enabled = false;
                        TA6.Enabled = false;
                        TA7.Enabled = false;
                        TA8.Enabled = false;
                        //TxBAbrCom.Enabled = false;
                        //TxBAbrIng.Enabled = false;

                        TA10.Enabled = false;
                        TA11.Enabled = false;
                        TA12.Enabled = false;
                        TA13.Enabled = false;
                        TA14.Enabled = false;
                        TA15.Enabled = false;
                        TA16.Enabled = false;
                        TA17.Enabled = false;
                        TA18.Enabled = false;
                        textBox25.Enabled = false;
                        textBox26.Enabled = false;
                        textBox27.Enabled = false;

                        TA23.Enabled = false;

                        //Deshabilita los textbox de Mayo
                        TMA1.Enabled = false;
                        TMA2.Enabled = false;
                        TMA3.Enabled = false;
                        TMA4.Enabled = false;
                        TMA5.Enabled = false;
                        TMA6.Enabled = false;
                        TMA7.Enabled = false;
                        TMA8.Enabled = false;
                        //TxBMayCom.Enabled = false;
                        //TxBMayIng.Enabled = false;

                        TMA10.Enabled = false;
                        TMA11.Enabled = false;
                        TMA12.Enabled = false;
                        TMA13.Enabled = false;
                        TMA14.Enabled = false;
                        TMA15.Enabled = false;
                        TMA16.Enabled = false;
                        TMA17.Enabled = false;
                        TMA18.Enabled = false;
                        textBox22.Enabled = false;
                        textBox23.Enabled = false;
                        textBox24.Enabled = false;

                        TMA23.Enabled = false;


                        //Deshabilita los textbox de Junio
                        TJ1.Enabled = false;
                        TJ2.Enabled = false;
                        TJ3.Enabled = false;
                        TJ4.Enabled = false;
                        TJ5.Enabled = false;
                        TJ6.Enabled = false;
                        TJ7.Enabled = false;
                        TJ8.Enabled = false;
                        //TxBJunCom.Enabled = false;
                        //TxBJunIng.Enabled = false;

                        TJ10.Enabled = false;
                        TJ11.Enabled = false;
                        TJ12.Enabled = false;
                        TJ13.Enabled = false;
                        TJ14.Enabled = false;
                        TJ15.Enabled = false;
                        TJ16.Enabled = false;
                        TJ17.Enabled = false;
                        TJ18.Enabled = false;
                        textBox19.Enabled = false;
                        textBox20.Enabled = false;
                        textBox21.Enabled = false;

                        TJ23.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Este mes ya no se puede modificar");
                    }
                }
            }
            if (CBMes.Text == "MARZO")
            {
                label6.Visible = false;
                CBMes.Visible = false;
                if (TF1.Text == "" ||
                TF2.Text == "" ||
                TF3.Text == "" ||
                TF4.Text == "" ||
                TF5.Text == "" ||
                TF6.Text == "" ||
                TF7.Text == "" ||
                TF8.Text == "" ||

                TF10.Text == "" ||
                TF11.Text == "" ||
                TF12.Text == "" ||
                TF13.Text == "" ||
                TF14.Text == "" ||
                TF15.Text == "" ||
                TF16.Text == "" ||
                TF17.Text == "" ||
                TF18.Text == "" ||
                textBox31.Text == "" ||
                textBox32.Text == "" ||
                textBox33.Text == "" ||

                TF23.Text == "")
                {
                    MessageBox.Show("Debe llenar primero Febrero");
                }
                else
                {
                    if (
                    TM1.Text == "" ||
                    TM2.Text == "" ||
                    TM3.Text == "" ||
                    TM4.Text == "" ||
                    TM5.Text == "" ||
                    TM6.Text == "" ||
                    TM7.Text == "" ||
                    TM8.Text == "" ||

                    TM10.Text == "" ||
                    TM11.Text == "" ||
                    TM12.Text == "" ||
                    TM13.Text == "" ||
                    TM14.Text == "" ||
                    TM15.Text == "" ||
                    TM16.Text == "" ||
                    TM17.Text == "" ||
                    TM18.Text == "" ||
                    textBox28.Text == "" ||
                    textBox29.Text == "" ||
                    textBox30.Text == "" ||

                    TM23.Text == "")
                    {
                        TD3.Enabled = false;
                        TD1.Enabled = false;
                        TD3.Enabled = false;
                        TD4.Enabled = false;
                        TD5.Enabled = false;
                        TD6.Enabled = false;
                        TD7.Enabled = false;
                        TD8.Enabled = false;
                        //TxBDiaCom.Enabled = false;
                        //TxBDiaIng.Enabled = false;

                        TD10.Enabled = false;
                        TD11.Enabled = false;
                        TD12.Enabled = false;
                        TD13.Enabled = false;
                        TD14.Enabled = false;
                        TD15.Enabled = false;
                        TD16.Enabled = false;
                        TD17.Enabled = false;
                        TD18.Enabled = false;

                        TD23.Enabled = false;


                        //Deshabilita los textbox de Septiembre
                        TS1.Enabled = false;
                        TS2.Enabled = false;
                        TS3.Enabled = false;
                        TS4.Enabled = false;
                        TS5.Enabled = false;
                        TS6.Enabled = false;
                        TS7.Enabled = false;
                        TS8.Enabled = false;
                        //TxBSepCom.Enabled = false;
                        //TxBSepIng.Enabled = false;

                        TS10.Enabled = false;
                        TS11.Enabled = false;
                        TS12.Enabled = false;
                        TS13.Enabled = false;
                        TS14.Enabled = false;
                        TS15.Enabled = false;
                        TS16.Enabled = false;
                        TS17.Enabled = false;
                        TS18.Enabled = false;

                        TS23.Enabled = false;

                        //Deshabilita los textbox de Octubre
                        TO1.Enabled = false;
                        TO2.Enabled = false;
                        TO3.Enabled = false;
                        TO4.Enabled = false;
                        TO5.Enabled = false;
                        TO6.Enabled = false;
                        TO7.Enabled = false;
                        TO8.Enabled = false;
                        //TxBOctCom.Enabled = false;
                        //TxBOctIng.Enabled = false;

                        T10.Enabled = false;
                        TO11.Enabled = false;
                        TO12.Enabled = false;
                        TO13.Enabled = false;
                        TO14.Enabled = false;
                        TO15.Enabled = false;
                        TO16.Enabled = false;
                        TO17.Enabled = false;
                        TO18.Enabled = false;
                        txt8.Enabled = false;
                        txt9.Enabled = false;
                        txt7.Enabled = false;

                        TO23.Enabled = false;

                        //Deshabilita los textbox de Noviembre
                        TN1.Enabled = false;
                        TN2.Enabled = false;
                        TN3.Enabled = false;
                        TN4.Enabled = false;
                        TN5.Enabled = false;
                        TN6.Enabled = false;
                        TN7.Enabled = false;
                        TN8.Enabled = false;
                        //TxBNovCom.Enabled = false;
                        //TxBNovIng.Enabled = false;

                        TN10.Enabled = false;
                        TN11.Enabled = false;
                        TN12.Enabled = false;
                        TN13.Enabled = false;
                        TN14.Enabled = false;
                        TN15.Enabled = false;
                        TN16.Enabled = false;
                        TN17.Enabled = false;
                        TN18.Enabled = false;
                        txt10.Enabled = false;
                        txt11.Enabled = false;
                        txt12.Enabled = false;

                        TN23.Enabled = false;

                        //Deshabilita los textbox de Diciembre
                        TDD1.Enabled = false;
                        TDD2.Enabled = false;
                        TDD3.Enabled = false;
                        TDD4.Enabled = false;
                        TDD5.Enabled = false;
                        TDD6.Enabled = false;
                        TDD7.Enabled = false;
                        TDD8.Enabled = false;
                        //TxBDicCom.Enabled = false;
                        //TxBDicIng.Enabled = false;

                        TDD10.Enabled = false;
                        TDD11.Enabled = false;
                        TDD12.Enabled = false;
                        TDD13.Enabled = false;
                        TDD14.Enabled = false;
                        TDD15.Enabled = false;
                        TDD16.Enabled = false;
                        TDD17.Enabled = false;
                        TDD18.Enabled = false;
                        txt13.Enabled = false;
                        txt14.Enabled = false;
                        txt15.Enabled = false;

                        TDD23.Enabled = false;

                        //Deshabilita los textbox de Enero
                        TE1.Enabled = false;
                        TE2.Enabled = false;
                        TE3.Enabled = false;
                        TE4.Enabled = false;
                        TE5.Enabled = false;
                        TE6.Enabled = false;
                        TE7.Enabled = false;
                        TE8.Enabled = false;
                        //TxBEneCom.Enabled = false;
                        //TxBEneIng.Enabled = false;

                        TE10.Enabled = false;
                        TE11.Enabled = false;
                        TE12.Enabled = false;
                        TE13.Enabled = false;
                        TE14.Enabled = false;
                        TE15.Enabled = false;
                        TE16.Enabled = false;
                        TE17.Enabled = false;
                        TE18.Enabled = false;
                        txt16.Enabled = false;
                        txt17.Enabled = false;
                        txt18.Enabled = false;

                        TE23.Enabled = false;

                        //Deshabilita los textbox de Febrero
                        TF1.Enabled = false;
                        TF2.Enabled = false;
                        TF3.Enabled = false;
                        TF4.Enabled = false;
                        TF5.Enabled = false;
                        TF6.Enabled = false;
                        TF7.Enabled = false;
                        TF8.Enabled = false;
                        //TxBFebCom.Enabled = false;
                        //TxBFebIng.Enabled = false;

                        TF10.Enabled = false;
                        TF11.Enabled = false;
                        TF12.Enabled = false;
                        TF13.Enabled = false;
                        TF14.Enabled = false;
                        TF15.Enabled = false;
                        TF16.Enabled = false;
                        TF17.Enabled = false;
                        TF18.Enabled = false;
                        textBox31.Enabled = false;
                        textBox32.Enabled = false;
                        textBox33.Enabled = false;

                        TF23.Enabled = false;

                        //Deshabilita los textbox de Marzo
                        TM1.Enabled = true;
                        TM2.Enabled = true;
                        TM3.Enabled = true;
                        TM4.Enabled = true;
                        TM5.Enabled = true;
                        TM6.Enabled = true;
                        TM7.Enabled = true;
                        TM8.Enabled = true;
                        //TxBMarCom.Enabled = true;
                        //TxBMarIng.Enabled = true;

                        TM10.Enabled = true;
                        TM11.Enabled = true;
                        TM12.Enabled = true;
                        TM13.Enabled = true;
                        TM14.Enabled = true;
                        TM15.Enabled = true;
                        TM16.Enabled = true;
                        TM17.Enabled = true;
                        TM18.Enabled = true;
                        textBox28.Enabled = true;
                        textBox29.Enabled = true;
                        textBox30.Enabled = true;

                        TM23.Enabled = true;

                        //Deshabilita los textbox de Abril
                        TA1.Enabled = false;
                        TA2.Enabled = false;
                        TA3.Enabled = false;
                        TA4.Enabled = false;
                        TA5.Enabled = false;
                        TA6.Enabled = false;
                        TA7.Enabled = false;
                        TA8.Enabled = false;
                        //TxBAbrCom.Enabled = false;
                        //TxBAbrIng.Enabled = false;

                        TA10.Enabled = false;
                        TA11.Enabled = false;
                        TA12.Enabled = false;
                        TA13.Enabled = false;
                        TA14.Enabled = false;
                        TA15.Enabled = false;
                        TA16.Enabled = false;
                        TA17.Enabled = false;
                        TA18.Enabled = false;
                        textBox25.Enabled = false;
                        textBox26.Enabled = false;
                        textBox27.Enabled = false;

                        TA23.Enabled = false;

                        //Deshabilita los textbox de Mayo
                        TMA1.Enabled = false;
                        TMA2.Enabled = false;
                        TMA3.Enabled = false;
                        TMA4.Enabled = false;
                        TMA5.Enabled = false;
                        TMA6.Enabled = false;
                        TMA7.Enabled = false;
                        TMA8.Enabled = false;
                        //TxBMayCom.Enabled = false;
                        //TxBMayIng.Enabled = false;

                        TMA10.Enabled = false;
                        TMA11.Enabled = false;
                        TMA12.Enabled = false;
                        TMA13.Enabled = false;
                        TMA14.Enabled = false;
                        TMA15.Enabled = false;
                        TMA16.Enabled = false;
                        TMA17.Enabled = false;
                        TMA18.Enabled = false;
                        textBox22.Enabled = false;
                        textBox23.Enabled = false;
                        textBox24.Enabled = false;

                        TMA23.Enabled = false;


                        //Deshabilita los textbox de Junio
                        TJ1.Enabled = false;
                        TJ2.Enabled = false;
                        TJ3.Enabled = false;
                        TJ4.Enabled = false;
                        TJ5.Enabled = false;
                        TJ6.Enabled = false;
                        TJ7.Enabled = false;
                        TJ8.Enabled = false;
                        //TxBJunCom.Enabled = false;
                        //TxBJunIng.Enabled = false;

                        TJ10.Enabled = false;
                        TJ11.Enabled = false;
                        TJ12.Enabled = false;
                        TJ13.Enabled = false;
                        TJ14.Enabled = false;
                        TJ15.Enabled = false;
                        TJ16.Enabled = false;
                        TJ17.Enabled = false;
                        TJ18.Enabled = false;
                        textBox19.Enabled = false;
                        textBox20.Enabled = false;
                        textBox21.Enabled = false;

                        TJ23.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Este mes no se puede modificar");
                    }
                }
            }
            if (CBMes.Text == "ABRIL")
            {
                label6.Visible = false;
                CBMes.Visible = false;
                if (TM1.Text == "" ||
                TM2.Text == "" ||
                TM3.Text == "" ||
                TM4.Text == "" ||
                TM5.Text == "" ||
                TM6.Text == "" ||
                TM7.Text == "" ||
                TM8.Text == "" ||

                TM10.Text == "" ||
                TM11.Text == "" ||
                TM12.Text == "" ||
                TM13.Text == "" ||
                TM14.Text == "" ||
                TM15.Text == "" ||
                TM16.Text == "" ||
                TM17.Text == "" ||
                TM18.Text == "" ||
                textBox28.Text == "" ||
                textBox29.Text == "" ||
                textBox30.Text == "" ||

                TM23.Text == "")
                {
                    MessageBox.Show("Debe llenar primero Marzo");
                }
                else
                {
                    if (
                    TA1.Text == "" ||
                    TA2.Text == "" ||
                    TA3.Text == "" ||
                    TA4.Text == "" ||
                    TA5.Text == "" ||
                    TA6.Text == "" ||
                    TA7.Text == "" ||
                    TA8.Text == "" ||

                    TA10.Text == "" ||
                    TA11.Text == "" ||
                    TA12.Text == "" ||
                    TA13.Text == "" ||
                    TA14.Text == "" ||
                    TA15.Text == "" ||
                    TA16.Text == "" ||
                    TA17.Text == "" ||
                    TA18.Text == "" ||
                    textBox25.Text == "" ||
                    textBox26.Text == "" ||
                    textBox27.Text == "" ||

                    TA23.Text == "")
                    {
                        TD3.Enabled = false;
                        TD1.Enabled = false;
                        TD3.Enabled = false;
                        TD4.Enabled = false;
                        TD5.Enabled = false;
                        TD6.Enabled = false;
                        TD7.Enabled = false;
                        TD8.Enabled = false;
                        //TxBDiaCom.Enabled = false;
                        //TxBDiaIng.Enabled = false;

                        TD10.Enabled = false;
                        TD11.Enabled = false;
                        TD12.Enabled = false;
                        TD13.Enabled = false;
                        TD14.Enabled = false;
                        TD15.Enabled = false;
                        TD16.Enabled = false;
                        TD17.Enabled = false;
                        TD18.Enabled = false;

                        TD23.Enabled = false;


                        //Deshabilita los textbox de Septiembre
                        TS1.Enabled = false;
                        TS2.Enabled = false;
                        TS3.Enabled = false;
                        TS4.Enabled = false;
                        TS5.Enabled = false;
                        TS6.Enabled = false;
                        TS7.Enabled = false;
                        TS8.Enabled = false;
                        //TxBSepCom.Enabled = false;
                        //TxBSepIng.Enabled = false;

                        TS10.Enabled = false;
                        TS11.Enabled = false;
                        TS12.Enabled = false;
                        TS13.Enabled = false;
                        TS14.Enabled = false;
                        TS15.Enabled = false;
                        TS16.Enabled = false;
                        TS17.Enabled = false;
                        TS18.Enabled = false;

                        TS23.Enabled = false;

                        //Deshabilita los textbox de Octubre
                        TO1.Enabled = false;
                        TO2.Enabled = false;
                        TO3.Enabled = false;
                        TO4.Enabled = false;
                        TO5.Enabled = false;
                        TO6.Enabled = false;
                        TO7.Enabled = false;
                        TO8.Enabled = false;
                        //TxBOctCom.Enabled = false;
                        //TxBOctIng.Enabled = false;

                        T10.Enabled = false;
                        TO11.Enabled = false;
                        TO12.Enabled = false;
                        TO13.Enabled = false;
                        TO14.Enabled = false;
                        TO15.Enabled = false;
                        TO16.Enabled = false;
                        TO17.Enabled = false;
                        TO18.Enabled = false;
                        txt8.Enabled = false;
                        txt9.Enabled = false;
                        txt7.Enabled = false;

                        TO23.Enabled = false;

                        //Deshabilita los textbox de Noviembre
                        TN1.Enabled = false;
                        TN2.Enabled = false;
                        TN3.Enabled = false;
                        TN4.Enabled = false;
                        TN5.Enabled = false;
                        TN6.Enabled = false;
                        TN7.Enabled = false;
                        TN8.Enabled = false;
                        //TxBNovCom.Enabled = false;
                        //TxBNovIng.Enabled = false;

                        TN10.Enabled = false;
                        TN11.Enabled = false;
                        TN12.Enabled = false;
                        TN13.Enabled = false;
                        TN14.Enabled = false;
                        TN15.Enabled = false;
                        TN16.Enabled = false;
                        TN17.Enabled = false;
                        TN18.Enabled = false;
                        txt10.Enabled = false;
                        txt11.Enabled = false;
                        txt12.Enabled = false;

                        TN23.Enabled = false;

                        //Deshabilita los textbox de Diciembre
                        TDD1.Enabled = false;
                        TDD2.Enabled = false;
                        TDD3.Enabled = false;
                        TDD4.Enabled = false;
                        TDD5.Enabled = false;
                        TDD6.Enabled = false;
                        TDD7.Enabled = false;
                        TDD8.Enabled = false;
                        //TxBDicCom.Enabled = false;
                        //TxBDicIng.Enabled = false;

                        TDD10.Enabled = false;
                        TDD11.Enabled = false;
                        TDD12.Enabled = false;
                        TDD13.Enabled = false;
                        TDD14.Enabled = false;
                        TDD15.Enabled = false;
                        TDD16.Enabled = false;
                        TDD17.Enabled = false;
                        TDD18.Enabled = false;
                        txt13.Enabled = false;
                        txt14.Enabled = false;
                        txt15.Enabled = false;

                        TDD23.Enabled = false;

                        //Deshabilita los textbox de Enero
                        TE1.Enabled = false;
                        TE2.Enabled = false;
                        TE3.Enabled = false;
                        TE4.Enabled = false;
                        TE5.Enabled = false;
                        TE6.Enabled = false;
                        TE7.Enabled = false;
                        TE8.Enabled = false;
                        //TxBEneCom.Enabled = false;
                        //TxBEneIng.Enabled = false;

                        TE10.Enabled = false;
                        TE11.Enabled = false;
                        TE12.Enabled = false;
                        TE13.Enabled = false;
                        TE14.Enabled = false;
                        TE15.Enabled = false;
                        TE16.Enabled = false;
                        TE17.Enabled = false;
                        TE18.Enabled = false;
                        txt16.Enabled = false;
                        txt17.Enabled = false;
                        txt18.Enabled = false;

                        TE23.Enabled = false;

                        //Deshabilita los textbox de Febrero
                        TF1.Enabled = false;
                        TF2.Enabled = false;
                        TF3.Enabled = false;
                        TF4.Enabled = false;
                        TF5.Enabled = false;
                        TF6.Enabled = false;
                        TF7.Enabled = false;
                        TF8.Enabled = false;
                        //TxBFebCom.Enabled = false;
                        //TxBFebIng.Enabled = false;

                        TF10.Enabled = false;
                        TF11.Enabled = false;
                        TF12.Enabled = false;
                        TF13.Enabled = false;
                        TF14.Enabled = false;
                        TF15.Enabled = false;
                        TF16.Enabled = false;
                        TF17.Enabled = false;
                        TF18.Enabled = false;
                        textBox31.Enabled = false;
                        textBox32.Enabled = false;
                        textBox33.Enabled = false;

                        TF23.Enabled = false;

                        //Deshabilita los textbox de Marzo
                        TM1.Enabled = false;
                        TM2.Enabled = false;
                        TM3.Enabled = false;
                        TM4.Enabled = false;
                        TM5.Enabled = false;
                        TM6.Enabled = false;
                        TM7.Enabled = false;
                        TM8.Enabled = false;
                        //TxBMarCom.Enabled = false;
                        //TxBMarIng.Enabled = false;

                        TM10.Enabled = false;
                        TM11.Enabled = false;
                        TM12.Enabled = false;
                        TM13.Enabled = false;
                        TM14.Enabled = false;
                        TM15.Enabled = false;
                        TM16.Enabled = false;
                        TM17.Enabled = false;
                        TM18.Enabled = false;
                        textBox28.Enabled = false;
                        textBox29.Enabled = false;
                        textBox30.Enabled = false;


                        TM23.Enabled = false;

                        //Deshabilita los textbox de Abril
                        TA1.Enabled = true;
                        TA2.Enabled = true;
                        TA3.Enabled = true;
                        TA4.Enabled = true;
                        TA5.Enabled = true;
                        TA6.Enabled = true;
                        TA7.Enabled = true;
                        TA8.Enabled = true;
                        //TxBAbrCom.Enabled = true;
                        //TxBAbrIng.Enabled = true;

                        TA10.Enabled = true;
                        TA11.Enabled = true;
                        TA12.Enabled = true;
                        TA13.Enabled = true;
                        TA14.Enabled = true;
                        TA15.Enabled = true;
                        TA16.Enabled = true;
                        TA17.Enabled = true;
                        TA18.Enabled = true;
                        textBox25.Enabled = true;
                        textBox26.Enabled = true;
                        textBox27.Enabled = true;

                        TA23.Enabled = true;

                        //Deshabilita los textbox de Mayo
                        TMA1.Enabled = false;
                        TMA2.Enabled = false;
                        TMA3.Enabled = false;
                        TMA4.Enabled = false;
                        TMA5.Enabled = false;
                        TMA6.Enabled = false;
                        TMA7.Enabled = false;
                        TMA8.Enabled = false;
                        //TxBMayCom.Enabled = false;
                        //TxBMayIng.Enabled = false;

                        TMA10.Enabled = false;
                        TMA11.Enabled = false;
                        TMA12.Enabled = false;
                        TMA13.Enabled = false;
                        TMA14.Enabled = false;
                        TMA15.Enabled = false;
                        TMA16.Enabled = false;
                        TMA17.Enabled = false;
                        TMA18.Enabled = false;
                        textBox22.Enabled = false;
                        textBox23.Enabled = false;
                        textBox24.Enabled = false;

                        TMA23.Enabled = false;

                        //Deshabilita los textbox de Junio
                        TJ1.Enabled = false;
                        TJ2.Enabled = false;
                        TJ3.Enabled = false;
                        TJ4.Enabled = false;
                        TJ5.Enabled = false;
                        TJ6.Enabled = false;
                        TJ7.Enabled = false;
                        TJ8.Enabled = false;

                        TJ10.Enabled = false;
                        TJ11.Enabled = false;
                        TJ12.Enabled = false;
                        TJ13.Enabled = false;
                        TJ14.Enabled = false;
                        TJ15.Enabled = false;
                        TJ16.Enabled = false;
                        TJ17.Enabled = false;
                        TJ18.Enabled = false;
                        textBox19.Enabled = false;
                        textBox20.Enabled = false;
                        textBox21.Enabled = false;

                        TJ23.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Este mes no se puede modificar");
                    }
                }
            }

            if (CBMes.Text == "MAYO")
            {
                label6.Visible = false;
                CBMes.Visible = false;
                if (TA1.Text == "" ||
                TA2.Text == "" ||
                TA3.Text == "" ||
                TA4.Text == "" ||
                TA5.Text == "" ||
                TA6.Text == "" ||
                TA7.Text == "" ||
                TA8.Text == "" ||

                TA10.Text == "" ||
                TA11.Text == "" ||
                TA12.Text == "" ||
                TA13.Text == "" ||
                TA14.Text == "" ||
                TA15.Text == "" ||
                TA16.Text == "" ||
                TA17.Text == "" ||
                TA18.Text == "" ||
                textBox25.Text == "" ||
                textBox26.Text == "" ||
                textBox27.Text == "" ||

                TA23.Text == "")
                {
                    MessageBox.Show("Primero debe de llenar Abril");
                }
                else
                {
                    if (
                    TMA1.Text == "" ||
                    TMA2.Text == "" ||
                    TMA3.Text == "" ||
                    TMA4.Text == "" ||
                    TMA5.Text == "" ||
                    TMA6.Text == "" ||
                    TMA7.Text == "" ||
                    TMA8.Text == "" ||

                    TMA10.Text == "" ||
                    TMA11.Text == "" ||
                    TMA12.Text == "" ||
                    TMA13.Text == "" ||
                    TMA14.Text == "" ||
                    TMA15.Text == "" ||
                    TMA16.Text == "" ||
                    TMA17.Text == "" ||
                    TMA18.Text == "" ||
                    textBox22.Text == "" ||
                    textBox23.Text == "" ||
                    textBox24.Text == "" ||

                    TMA23.Text == "")
                    {

                        TD3.Enabled = false;
                        TD1.Enabled = false;
                        TD3.Enabled = false;
                        TD4.Enabled = false;
                        TD5.Enabled = false;
                        TD6.Enabled = false;
                        TD7.Enabled = false;
                        TD8.Enabled = false;

                        TD10.Enabled = false;
                        TD11.Enabled = false;
                        TD12.Enabled = false;
                        TD13.Enabled = false;
                        TD14.Enabled = false;
                        TD15.Enabled = false;
                        TD16.Enabled = false;
                        TD17.Enabled = false;
                        TD18.Enabled = false;

                        TD23.Enabled = false;


                        //Deshabilita los textbox de Septiembre
                        TS1.Enabled = false;
                        TS2.Enabled = false;
                        TS3.Enabled = false;
                        TS4.Enabled = false;
                        TS5.Enabled = false;
                        TS6.Enabled = false;
                        TS7.Enabled = false;
                        TS8.Enabled = false;
                        //TxBSepCom.Enabled = false;
                        //TxBSepIng.Enabled = false;

                        TS10.Enabled = false;
                        TS11.Enabled = false;
                        TS12.Enabled = false;
                        TS13.Enabled = false;
                        TS14.Enabled = false;
                        TS15.Enabled = false;
                        TS16.Enabled = false;
                        TS17.Enabled = false;
                        TS18.Enabled = false;

                        TS23.Enabled = false;

                        //Deshabilita los textbox de Octubre
                        TO1.Enabled = false;
                        TO2.Enabled = false;
                        TO3.Enabled = false;
                        TO4.Enabled = false;
                        TO5.Enabled = false;
                        TO6.Enabled = false;
                        TO7.Enabled = false;
                        TO8.Enabled = false;
                        //TxBOctCom.Enabled = false;
                        //TxBOctIng.Enabled = false;

                        T10.Enabled = false;
                        TO11.Enabled = false;
                        TO12.Enabled = false;
                        TO13.Enabled = false;
                        TO14.Enabled = false;
                        TO15.Enabled = false;
                        TO16.Enabled = false;
                        TO17.Enabled = false;
                        TO18.Enabled = false;
                        txt8.Enabled = false;
                        txt9.Enabled = false;
                        txt7.Enabled = false;

                        TO23.Enabled = false;

                        //Deshabilita los textbox de Noviembre
                        TN1.Enabled = false;
                        TN2.Enabled = false;
                        TN3.Enabled = false;
                        TN4.Enabled = false;
                        TN5.Enabled = false;
                        TN6.Enabled = false;
                        TN7.Enabled = false;
                        TN8.Enabled = false;
                        //TxBNovCom.Enabled = false;
                        //TxBNovIng.Enabled = false;

                        TN10.Enabled = false;
                        TN11.Enabled = false;
                        TN12.Enabled = false;
                        TN13.Enabled = false;
                        TN14.Enabled = false;
                        TN15.Enabled = false;
                        TN16.Enabled = false;
                        TN17.Enabled = false;
                        TN18.Enabled = false;
                        txt10.Enabled = false;
                        txt11.Enabled = false;
                        txt12.Enabled = false;

                        TN23.Enabled = false;

                        //Deshabilita los textbox de Diciembre
                        TDD1.Enabled = false;
                        TDD2.Enabled = false;
                        TDD3.Enabled = false;
                        TDD4.Enabled = false;
                        TDD5.Enabled = false;
                        TDD6.Enabled = false;
                        TDD7.Enabled = false;
                        TDD8.Enabled = false;
                        //TxBDicCom.Enabled = false;
                        //TxBDicIng.Enabled = false;

                        TDD10.Enabled = false;
                        TDD11.Enabled = false;
                        TDD12.Enabled = false;
                        TDD13.Enabled = false;
                        TDD14.Enabled = false;
                        TDD15.Enabled = false;
                        TDD16.Enabled = false;
                        TDD17.Enabled = false;
                        TDD18.Enabled = false;
                        txt10.Enabled = false;
                        txt11.Enabled = false;
                        txt12.Enabled = false;

                        TDD23.Enabled = false;

                        //Deshabilita los textbox de Enero
                        TE1.Enabled = false;
                        TE2.Enabled = false;
                        TE3.Enabled = false;
                        TE4.Enabled = false;
                        TE5.Enabled = false;
                        TE6.Enabled = false;
                        TE7.Enabled = false;
                        TE8.Enabled = false;
                        //TxBEneCom.Enabled = false;
                        //TxBEneIng.Enabled = false;

                        TE10.Enabled = false;
                        TE11.Enabled = false;
                        TE12.Enabled = false;
                        TE13.Enabled = false;
                        TE14.Enabled = false;
                        TE15.Enabled = false;
                        TE16.Enabled = false;
                        TE17.Enabled = false;
                        TE18.Enabled = false;
                        txt16.Enabled = false;
                        txt17.Enabled = false;
                        txt18.Enabled = false;

                        TE23.Enabled = false;

                        //Deshabilita los textbox de Febrero
                        TF1.Enabled = false;
                        TF2.Enabled = false;
                        TF3.Enabled = false;
                        TF4.Enabled = false;
                        TF5.Enabled = false;
                        TF6.Enabled = false;
                        TF7.Enabled = false;
                        TF8.Enabled = false;
                        //TxBFebCom.Enabled = false;
                        //TxBFebIng.Enabled = false;

                        TF10.Enabled = false;
                        TF11.Enabled = false;
                        TF12.Enabled = false;
                        TF13.Enabled = false;
                        TF14.Enabled = false;
                        TF15.Enabled = false;
                        TF16.Enabled = false;
                        TF17.Enabled = false;
                        TF18.Enabled = false;
                        textBox31.Enabled = false;
                        textBox32.Enabled = false;
                        textBox33.Enabled = false;

                        TF23.Enabled = false;

                        //Deshabilita los textbox de Marzo
                        TM1.Enabled = false;
                        TM2.Enabled = false;
                        TM3.Enabled = false;
                        TM4.Enabled = false;
                        TM5.Enabled = false;
                        TM6.Enabled = false;
                        TM7.Enabled = false;
                        TM8.Enabled = false;
                        //TxBMarCom.Enabled = false;
                        //TxBMarIng.Enabled = false;

                        TM10.Enabled = false;
                        TM11.Enabled = false;
                        TM12.Enabled = false;
                        TM13.Enabled = false;
                        TM14.Enabled = false;
                        TM15.Enabled = false;
                        TM16.Enabled = false;
                        TM17.Enabled = false;
                        TM18.Enabled = false;
                        textBox28.Enabled = false;
                        textBox29.Enabled = false;
                        textBox30.Enabled = false;

                        TM23.Enabled = false;

                        //Deshabilita los textbox de Abril
                        TA1.Enabled = false;
                        TA2.Enabled = false;
                        TA3.Enabled = false;
                        TA4.Enabled = false;
                        TA5.Enabled = false;
                        TA6.Enabled = false;
                        TA7.Enabled = false;
                        TA8.Enabled = false;
                        //TxBAbrCom.Enabled = false;
                        //TxBAbrIng.Enabled = false;

                        TA10.Enabled = false;
                        TA11.Enabled = false;
                        TA12.Enabled = false;
                        TA13.Enabled = false;
                        TA14.Enabled = false;
                        TA15.Enabled = false;
                        TA16.Enabled = false;
                        TA17.Enabled = false;
                        TA18.Enabled = false;
                        textBox25.Enabled = false;
                        textBox26.Enabled = false;
                        textBox27.Enabled = false;

                        TA23.Enabled = false;

                        //Deshabilita los textbox de Mayo
                        TMA1.Enabled = true;
                        TMA2.Enabled = true;
                        TMA3.Enabled = true;
                        TMA4.Enabled = true;
                        TMA5.Enabled = true;
                        TMA6.Enabled = true;
                        TMA7.Enabled = true;
                        TMA8.Enabled = true;
                        //TxBMayCom.Enabled = true;
                        //TxBMayIng.Enabled = true;

                        TMA10.Enabled = true;
                        TMA11.Enabled = true;
                        TMA12.Enabled = true;
                        TMA13.Enabled = true;
                        TMA14.Enabled = true;
                        TMA15.Enabled = true;
                        TMA16.Enabled = true;
                        TMA17.Enabled = true;
                        TMA18.Enabled = true;
                        textBox22.Enabled = true;
                        textBox23.Enabled = true;
                        textBox24.Enabled = true;

                        TMA23.Enabled = true;


                        //Deshabilita los textbox de Junio
                        TJ1.Enabled = false;
                        TJ2.Enabled = false;
                        TJ3.Enabled = false;
                        TJ4.Enabled = false;
                        TJ5.Enabled = false;
                        TJ6.Enabled = false;
                        TJ7.Enabled = false;
                        TJ8.Enabled = false;
                        //TxBJunCom.Enabled = false;
                        //TxBJunIng.Enabled = false;

                        TJ10.Enabled = false;
                        TJ11.Enabled = false;
                        TJ12.Enabled = false;
                        TJ13.Enabled = false;
                        TJ14.Enabled = false;
                        TJ15.Enabled = false;
                        TJ16.Enabled = false;
                        TJ17.Enabled = false;
                        TJ18.Enabled = false;
                        textBox19.Enabled = false;
                        textBox20.Enabled = false;
                        textBox21.Enabled = false;

                        TJ23.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Este mes no se puede modificar");
                    }
                }
            }

            if (CBMes.Text == "JUNIO")
            {
                label6.Visible = false;
                CBMes.Visible = false;
                if (TMA1.Text == "" ||
                TMA2.Text == "" ||
                TMA3.Text == "" ||
                TMA4.Text == "" ||
                TMA5.Text == "" ||
                TMA6.Text == "" ||
                TMA7.Text == "" ||
                TMA8.Text == "" ||

                TMA10.Text == "" ||
                TMA11.Text == "" ||
                TMA12.Text == "" ||
                TMA13.Text == "" ||
                TMA14.Text == "" ||
                TMA15.Text == "" ||
                TMA16.Text == "" ||
                TMA17.Text == "" ||
                TMA18.Text == "" ||
                textBox22.Text == "" ||
                textBox23.Text == "" ||
                textBox24.Text == "" ||

                TMA23.Text == "")
                {
                    MessageBox.Show("Debe llenar primero Mayo");
                }
                else
                {
                    if (
                    TJ1.Text == "" ||
                    TJ2.Text == "" ||
                    TJ3.Text == "" ||
                    TJ4.Text == "" ||
                    TJ5.Text == "" ||
                    TJ6.Text == "" ||
                    TJ7.Text == "" ||
                    TJ8.Text == "" ||

                    TJ10.Text == "" ||
                    TJ11.Text == "" ||
                    TJ12.Text == "" ||
                    TJ13.Text == "" ||
                    TJ14.Text == "" ||
                    TJ15.Text == "" ||
                    TJ16.Text == "" ||
                    TJ17.Text == "" ||
                    TJ18.Text == "" ||
                    textBox19.Text == "" ||
                    textBox20.Text == "" ||
                    textBox21.Text == "" ||

                    TJ23.Text == "")
                    {
                        TD3.Enabled = false;
                        TD1.Enabled = false;
                        TD3.Enabled = false;
                        TD4.Enabled = false;
                        TD5.Enabled = false;
                        TD6.Enabled = false;
                        TD7.Enabled = false;
                        TD8.Enabled = false;
                        //TxBDiaCom.Enabled = false;
                        //TxBDiaIng.Enabled = false;

                        TD10.Enabled = false;
                        TD11.Enabled = false;
                        TD12.Enabled = false;
                        TD13.Enabled = false;
                        TD14.Enabled = false;
                        TD15.Enabled = false;
                        TD16.Enabled = false;
                        TD17.Enabled = false;
                        TD18.Enabled = false;

                        TD23.Enabled = false;


                        //Deshabilita los textbox de Septiembre
                        TS1.Enabled = false;
                        TS2.Enabled = false;
                        TS3.Enabled = false;
                        TS4.Enabled = false;
                        TS5.Enabled = false;
                        TS6.Enabled = false;
                        TS7.Enabled = false;
                        TS8.Enabled = false;
                        //TxBSepCom.Enabled = false;
                        //TxBSepIng.Enabled = false;

                        TS10.Enabled = false;
                        TS11.Enabled = false;
                        TS12.Enabled = false;
                        TS13.Enabled = false;
                        TS14.Enabled = false;
                        TS15.Enabled = false;
                        TS16.Enabled = false;
                        TS17.Enabled = false;
                        TS18.Enabled = false;

                        TS23.Enabled = false;

                        //Deshabilita los textbox de Octubre
                        TO1.Enabled = false;
                        TO2.Enabled = false;
                        TO3.Enabled = false;
                        TO4.Enabled = false;
                        TO5.Enabled = false;
                        TO6.Enabled = false;
                        TO7.Enabled = false;
                        TO8.Enabled = false;
                        //TxBOctCom.Enabled = false;
                        //TxBOctIng.Enabled = false;

                        T10.Enabled = false;
                        TO11.Enabled = false;
                        TO12.Enabled = false;
                        TO13.Enabled = false;
                        TO14.Enabled = false;
                        TO15.Enabled = false;
                        TO16.Enabled = false;
                        TO17.Enabled = false;
                        TO18.Enabled = false;
                        txt8.Enabled = false;
                        txt9.Enabled = false;
                        txt7.Enabled = false;

                        TO23.Enabled = false;

                        //Deshabilita los textbox de Noviembre
                        TN1.Enabled = false;
                        TN2.Enabled = false;
                        TN3.Enabled = false;
                        TN4.Enabled = false;
                        TN5.Enabled = false;
                        TN6.Enabled = false;
                        TN7.Enabled = false;
                        TN8.Enabled = false;
                        //TxBNovCom.Enabled = false;
                        //TxBNovIng.Enabled = false;

                        TN10.Enabled = false;
                        TN11.Enabled = false;
                        TN12.Enabled = false;
                        TN13.Enabled = false;
                        TN14.Enabled = false;
                        TN15.Enabled = false;
                        TN16.Enabled = false;
                        TN17.Enabled = false;
                        TN18.Enabled = false;
                        txt10.Enabled = false;
                        txt11.Enabled = false;
                        txt12.Enabled = false;

                        TN23.Enabled = false;

                        //Deshabilita los textbox de Diciembre
                        TDD1.Enabled = false;
                        TDD2.Enabled = false;
                        TDD3.Enabled = false;
                        TDD4.Enabled = false;
                        TDD5.Enabled = false;
                        TDD6.Enabled = false;
                        TDD7.Enabled = false;
                        TDD8.Enabled = false;
                        //TxBDicCom.Enabled = false;
                        //TxBDicIng.Enabled = false;

                        TDD10.Enabled = false;
                        TDD11.Enabled = false;
                        TDD12.Enabled = false;
                        TDD13.Enabled = false;
                        TDD14.Enabled = false;
                        TDD15.Enabled = false;
                        TDD16.Enabled = false;
                        TDD17.Enabled = false;
                        TDD18.Enabled = false;
                        txt13.Enabled = false;
                        txt14.Enabled = false;
                        txt15.Enabled = false;

                        TDD23.Enabled = false;

                        //Deshabilita los textbox de Enero
                        TE1.Enabled = false;
                        TE2.Enabled = false;
                        TE3.Enabled = false;
                        TE4.Enabled = false;
                        TE5.Enabled = false;
                        TE6.Enabled = false;
                        TE7.Enabled = false;
                        TE8.Enabled = false;
                        //TxBEneCom.Enabled = false;
                        //TxBEneIng.Enabled = false;

                        TE10.Enabled = false;
                        TE11.Enabled = false;
                        TE12.Enabled = false;
                        TE13.Enabled = false;
                        TE14.Enabled = false;
                        TE15.Enabled = false;
                        TE16.Enabled = false;
                        TE17.Enabled = false;
                        TE18.Enabled = false;
                        txt16.Enabled = false;
                        txt17.Enabled = false;
                        txt18.Enabled = false;
                        TE23.Enabled = false;

                        //Deshabilita los textbox de Febrero
                        TF1.Enabled = false;
                        TF2.Enabled = false;
                        TF3.Enabled = false;
                        TF4.Enabled = false;
                        TF5.Enabled = false;
                        TF6.Enabled = false;
                        TF7.Enabled = false;
                        TF8.Enabled = false;
                        //TxBFebCom.Enabled = false;
                        //TxBFebIng.Enabled = false;

                        TF10.Enabled = false;
                        TF11.Enabled = false;
                        TF12.Enabled = false;
                        TF13.Enabled = false;
                        TF14.Enabled = false;
                        TF15.Enabled = false;
                        TF16.Enabled = false;
                        TF17.Enabled = false;
                        TF18.Enabled = false;
                        textBox31.Enabled = false;
                        textBox32.Enabled = false;
                        textBox33.Enabled = false;

                        TF23.Enabled = false;

                        //Deshabilita los textbox de Marzo
                        TM1.Enabled = false;
                        TM2.Enabled = false;
                        TM3.Enabled = false;
                        TM4.Enabled = false;
                        TM5.Enabled = false;
                        TM6.Enabled = false;
                        TM7.Enabled = false;
                        TM8.Enabled = false;
                        //TxBMarCom.Enabled = false;
                        //TxBMarIng.Enabled = false;

                        TM10.Enabled = false;
                        TM11.Enabled = false;
                        TM12.Enabled = false;
                        TM13.Enabled = false;
                        TM14.Enabled = false;
                        TM15.Enabled = false;
                        TM16.Enabled = false;
                        TM17.Enabled = false;
                        TM18.Enabled = false;
                        textBox28.Enabled = false;
                        textBox29.Enabled = false;
                        textBox30.Enabled = false;

                        TM23.Enabled = false;

                        //Deshabilita los textbox de Abril
                        TA1.Enabled = false;
                        TA2.Enabled = false;
                        TA3.Enabled = false;
                        TA4.Enabled = false;
                        TA5.Enabled = false;
                        TA6.Enabled = false;
                        TA7.Enabled = false;
                        TA8.Enabled = false;
                        //TxBAbrCom.Enabled = false;
                        //TxBAbrIng.Enabled = false;

                        TA10.Enabled = false;
                        TA11.Enabled = false;
                        TA12.Enabled = false;
                        TA13.Enabled = false;
                        TA14.Enabled = false;
                        TA15.Enabled = false;
                        TA16.Enabled = false;
                        TA17.Enabled = false;
                        TA18.Enabled = false;
                        textBox25.Enabled = false;
                        textBox26.Enabled = false;
                        textBox27.Enabled = false;

                        TA23.Enabled = false;

                        //Deshabilita los textbox de Mayo
                        TMA1.Enabled = false;
                        TMA2.Enabled = false;
                        TMA3.Enabled = false;
                        TMA4.Enabled = false;
                        TMA5.Enabled = false;
                        TMA6.Enabled = false;
                        TMA7.Enabled = false;
                        TMA8.Enabled = false;
                        //TxBMayCom.Enabled = false;
                        //TxBMayIng.Enabled = false;

                        TMA10.Enabled = false;
                        TMA11.Enabled = false;
                        TMA12.Enabled = false;
                        TMA13.Enabled = false;
                        TMA14.Enabled = false;
                        TMA15.Enabled = false;
                        TMA16.Enabled = false;
                        TMA17.Enabled = false;
                        TMA18.Enabled = false;
                        textBox22.Enabled = false;
                        textBox23.Enabled = false;
                        textBox24.Enabled = false;

                        TMA23.Enabled = false;


                        //Deshabilita los textbox de Junio
                        TJ1.Enabled = true;
                        TJ2.Enabled = true;
                        TJ3.Enabled = true;
                        TJ4.Enabled = true;
                        TJ5.Enabled = true;
                        TJ6.Enabled = true;
                        TJ7.Enabled = true;
                        TJ8.Enabled = true;
                        //TxBJunCom.Enabled = true;
                        //TxBJunIng.Enabled = true;

                        TJ10.Enabled = true;
                        TJ11.Enabled = true;
                        TJ12.Enabled = true;
                        TJ13.Enabled = true;
                        TJ14.Enabled = true;
                        TJ15.Enabled = true;
                        TJ16.Enabled = true;
                        TJ17.Enabled = true;
                        TJ18.Enabled = true;
                        textBox19.Enabled = true;
                        textBox20.Enabled = true;
                        textBox21.Enabled = true;

                        TJ23.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Este mes no se puede modificar");
                    }
                }
            }

        }

        private void TxBDiaLec_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxBSepTotPun_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxBNovTotPun_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxBEneProGral_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxBFebProSep_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxBFebProGral_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxB3BimTar_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxB4BimExp_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxB4BimProGral_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxBPromPun_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxBPromProCom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void TD8_TextChanged(object sender, EventArgs e)
        {


        }

        private void TD211_TextChanged(object sender, EventArgs e)
        {
            //double total;

            //total = double.Parse(TD10.Text) + double.Parse(TD11.Text) + double.Parse(TD12.Text) + double.Parse(TD13.Text) + double.Parse(TD14.Text) + double.Parse(TD15.Text) + double.Parse(TD7.Text) + double.Parse(TD16.Text) + double.Parse(TD17.Text) + double.Parse(TD18.Text) + double.Parse(TD19.Text) + double.Parse(textBox40.Text) + double.Parse(textBox48.Text)+double.Parse(textBox47.Text);
            //TD19.Text= Convert.ToString(total / 12);
        }

        private void TD8_Leave(object sender, EventArgs e)
        {
            if (TD8.Text == "")
            {
            }
            else
            {
                if (double.Parse(TD8.Text) <= 5.9)
                {
                    TD8.ForeColor = Color.Red;

                    if (double.Parse(TD8.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD8.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TD8.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD8.Text = "";
                    }
                    TD8.ForeColor = Color.Black;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TD8.Text == "")
            {

            }
            else
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = false;
                }

                else
                {
                    MessageBox.Show("Por Favor, solo se aceptan numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Focus();
                    e.Handled = true;
                }
            }
        }

        private void TD7_TextChanged(object sender, EventArgs e)
        {
            if (TD7.Text == "")
            {
            }
            else
            {
                if (double.Parse(TD7.Text) <= 5.9)
                {
                    TD7.ForeColor = Color.Red;
                    if (double.Parse(TD7.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD7.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TD7.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD7.Text = "";
                    }
                    TD7.ForeColor = Color.Black;
                }
            }

        }

        private void TD6_TextChanged(object sender, EventArgs e)
        {
            if (TD6.Text == "")
            {
            }
            else
            {
                if (double.Parse(TD6.Text) <= 5.9)
                {
                    TD6.ForeColor = Color.Red;
                    if (double.Parse(TD6.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD6.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TD6.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD6.Text = "";
                    }
                    TD6.ForeColor = Color.Black;
                }
            }
        }

        private void TD5_TextChanged(object sender, EventArgs e)
        {
            if (TD5.Text == "")
            {
            }
            else
            {
                if (double.Parse(TD5.Text) <= 5.9)
                {
                    TD5.ForeColor = Color.Red;
                    if (double.Parse(TD5.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD5.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TD5.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD5.Text = "";
                    }
                    TD5.ForeColor = Color.Black;
                }
            }
        }

        private void TD4_TextChanged(object sender, EventArgs e)
        {
            if (TD4.Text == "")
            {
            }
            else
            {
                if (double.Parse(TD4.Text) <= 5.9)
                {
                    TD4.ForeColor = Color.Red;
                    if (double.Parse(TD4.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD4.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TD4.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD4.Text = "";
                    }
                    TD4.ForeColor = Color.Black;
                }
            }
        }

        private void TD3_TextChanged(object sender, EventArgs e)
        {
            if (TD3.Text == "")
            {
            }
            else
            {
                if (double.Parse(TD3.Text) <= 5.9)
                {
                    TD3.ForeColor = Color.Red;
                    if (double.Parse(TD3.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD3.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TD3.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD3.Text = "";
                    }
                    TD3.ForeColor = Color.Black;
                }
            }
        }

        private void TD2_TextChanged(object sender, EventArgs e)
        {
            if (TD2.Text == "")
            {
            }
            else
            {
                if (double.Parse(TD2.Text) <= 5.9)
                {
                    TD2.ForeColor = Color.Red;
                    if (double.Parse(TD2.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD2.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TD2.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD2.Text = "";
                    }
                    TD2.ForeColor = Color.Black;
                }
            }
        }

        private void TD1_TextChanged(object sender, EventArgs e)
        {
            if (TD1.Text == "")
            {
            }
            else
            {
                if (double.Parse(TD1.Text) <= 5.9)
                {
                    TD1.ForeColor = Color.Red;
                    if (double.Parse(TD1.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD1.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TD1.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD1.Text = "";
                    }
                    TD1.ForeColor = Color.Black;
                }
            }

        }


        private void TD10_Leave(object sender, EventArgs e)
        {
            if (TD10.Text == "")
            {
            }
            else
            {
                if (double.Parse(TD10.Text) <= 5.9)
                {
                    TD10.ForeColor = Color.Red;
                    if (double.Parse(TD10.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD10.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TD10.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD10.Text = "";
                    }
                    TD10.ForeColor = Color.Black;
                }
            }
        }

        private void TD11_TextChanged(object sender, EventArgs e)
        {
            if (TD11.Text == "")
            {
            }
            else
            {
                if (double.Parse(TD11.Text) <= 5.9)
                {
                    TD11.ForeColor = Color.Red;
                    if (double.Parse(TD11.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD11.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TD11.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD11.Text = "";
                    }
                    TD11.ForeColor = Color.Black;
                }
            }
        }

        private void TD12_TextChanged(object sender, EventArgs e)
        {
            if (TD12.Text == "")
            {
            }
            else
            {
                if (double.Parse(TD12.Text) <= 5.9)
                {
                    TD12.ForeColor = Color.Red;
                    if (double.Parse(TD12.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD12.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TD12.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD12.Text = "";
                    }
                    TD12.ForeColor = Color.Black;
                }
            }

        }

        private void TD13_Leave(object sender, EventArgs e)
        {
            if (TD13.Text == "")
            {
            }
            else
            {
                if (double.Parse(TD13.Text) <= 5.9)
                {
                    TD13.ForeColor = Color.Red;
                    if (double.Parse(TD13.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD13.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TD13.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD13.Text = "";
                    }
                    TD13.ForeColor = Color.Black;
                }
            }
        }

        private void TD14_Leave(object sender, EventArgs e)
        {
            if (TD14.Text == "")
            {
            }
            else
            {
                if (double.Parse(TD14.Text) <= 5.9)
                {
                    TD14.ForeColor = Color.Red;
                    if (double.Parse(TD14.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD14.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TD14.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD14.Text = "";
                    }
                    TD14.ForeColor = Color.Black;
                }
            }
        }

        private void TD15_Leave(object sender, EventArgs e)
        {
            if (TD15.Text == "")
            {
            }
            else
            {
                if (double.Parse(TD15.Text) <= 5.9)
                {
                    TD15.ForeColor = Color.Red;
                    if (double.Parse(TD15.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD15.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TD13.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD15.Text = "";
                    }
                    TD15.ForeColor = Color.Black;
                }
            }

        }

        private void TD16_Leave(object sender, EventArgs e)
        {
            if (TD16.Text == "")
            {
            }
            else
            {
                if (double.Parse(TD16.Text) <= 5.9)
                {
                    TD16.ForeColor = Color.Red;
                    if (double.Parse(TD16.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD16.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TD16.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD16.Text = "";
                    }
                    TD16.ForeColor = Color.Black;
                }
            }
        }

        private void TD17_Leave(object sender, EventArgs e)
        {
            if (TD17.Text == "")
            {
            }
            else
            {
                if (double.Parse(TD17.Text) <= 5.9)
                {
                    TD17.ForeColor = Color.Red;
                    if (double.Parse(TD17.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD17.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TD17.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD17.Text = "";
                    }
                    TD17.ForeColor = Color.Black;
                }
            }
        }

        private void TD18_TextChanged(object sender, EventArgs e)
        {
            if (TD18.Text == "")
            {
            }
            else
            {
                if (double.Parse(TD18.Text) <= 5.9)
                {
                    TD18.ForeColor = Color.Red;
                    if (double.Parse(TD18.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD18.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TD13.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TD18.Text = "";
                    }
                    TD18.ForeColor = Color.Black;
                }
            }
        }

        private void textBox40_Leave(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
            }
            else
            {
                if (double.Parse(txt1.Text) <= 5.9)
                {
                    txt1.ForeColor = Color.Red;
                    if (double.Parse(txt1.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt1.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(txt1.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt1.Text = "";
                    }
                    txt1.ForeColor = Color.Black;
                }
            }
        }

        private void textBox48_Leave(object sender, EventArgs e)
        {
            if (txt2.Text == "")
            {
            }
            else
            {
                if (double.Parse(txt2.Text) <= 5.9)
                {
                    txt2.ForeColor = Color.Red;
                    if (double.Parse(txt2.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt2.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(txt2.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt2.Text = "";
                    }
                    txt2.ForeColor = Color.Black;
                }
            }
        }

        private void textBox47_Leave(object sender, EventArgs e)
        {
            if (txt3.Text == "")
            {
            }
            else
            {
                if (double.Parse(txt3.Text) <= 5.9)
                {
                    txt3.ForeColor = Color.Red;
                    if (double.Parse(txt3.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt3.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(txt3.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt3.Text = "";
                    }
                    txt3.ForeColor = Color.Black;
                }
            }
        }

        private void TD1_TextChanged_1(object sender, EventArgs e)
        {

            if (TD2.Text == "" ||
                TD1.Text == "" ||
                TD3.Text == "" ||
                TD4.Text == "" ||
                TD5.Text == "" ||
                TD6.Text == "" ||
                TD7.Text == "" ||
                TD8.Text == "")
            {
            }
            else
            {
                double total = double.Parse(TD1.Text) + double.Parse(TD2.Text) + double.Parse(TD3.Text) + double.Parse(TD4.Text) + double.Parse(TD5.Text) + double.Parse(TD6.Text) + double.Parse(TD7.Text) + double.Parse(TD8.Text);
                TD9.Text = Convert.ToString(total / 8);

            }
        }

        private void TD9_TextChanged(object sender, EventArgs e)
        {

        }

        private void TS1_Leave(object sender, EventArgs e)
        {
            if (TS1.Text == "")
            {
            }
            else
            {
                if (double.Parse(TS1.Text) <= 5.9)
                {
                    TS1.ForeColor = Color.Red;
                    if (double.Parse(TS1.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS1.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TS1.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS1.Text = "";
                    }
                    TS1.ForeColor = Color.Black;
                }
            }
        }

        private void TS2_Leave(object sender, EventArgs e)
        {
            if (TS1.Text == "")
            {
            }
            else
            {
                if (double.Parse(TS2.Text) <= 5.9)
                {
                    TS2.ForeColor = Color.Red;
                    if (double.Parse(TS2.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS2.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TS2.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS2.Text = "";
                    }
                    TS2.ForeColor = Color.Black;
                }
            }
        }

        private void TS3_Leave(object sender, EventArgs e)
        {
            if (TS3.Text == "")
            {
            }
            else
            {
                if (double.Parse(TS3.Text) <= 5.9)
                {
                    TS3.ForeColor = Color.Red;
                    if (double.Parse(TS3.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS3.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TS3.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS3.Text = "";
                    }
                    TS3.ForeColor = Color.Black;
                }
            }
        }

        private void TS4_Leave(object sender, EventArgs e)
        {
            if (TS4.Text == "")
            {
            }
            else
            {
                if (double.Parse(TS4.Text) <= 5.9)
                {
                    TS4.ForeColor = Color.Red;
                    if (double.Parse(TS4.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS4.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TS4.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS4.Text = "";
                    }
                    TS4.ForeColor = Color.Black;
                }
            }
        }

        private void TS5_Leave(object sender, EventArgs e)
        {
            if (TS5.Text == "")
            {
            }
            else
            {
                if (double.Parse(TS5.Text) <= 5.9)
                {
                    TS5.ForeColor = Color.Red;
                    if (double.Parse(TS5.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS5.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TS5.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS5.Text = "";
                    }
                    TS5.ForeColor = Color.Black;
                }
            }
        }

        private void TS6_Leave(object sender, EventArgs e)
        {
            if (TS6.Text == "")
            {
            }
            else
            {
                if (double.Parse(TS6.Text) <= 5.9)
                {
                    TS6.ForeColor = Color.Red;
                    if (double.Parse(TS6.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS6.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TS6.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS6.Text = "";
                    }
                    TS6.ForeColor = Color.Black;
                }
            }
        }

        private void TS7_Leave(object sender, EventArgs e)
        {
            if (TS7.Text == "")
            {
            }
            else
            {
                if (double.Parse(TS7.Text) <= 5.9)
                {
                    TS7.ForeColor = Color.Red;
                    if (double.Parse(TS7.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS7.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TS7.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS7.Text = "";
                    }
                    TS7.ForeColor = Color.Black;
                }
            }
        }

        private void TS8_Leave(object sender, EventArgs e)
        {
            if (TS8.Text == "")
            {
            }
            else
            {
                if (double.Parse(TS8.Text) <= 5.9)
                {
                    TS8.ForeColor = Color.Red;
                    if (double.Parse(TS8.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS8.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TS8.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS8.Text = "";
                    }
                    TS8.ForeColor = Color.Black;
                }
            }
        }

        private void TS10_Leave(object sender, EventArgs e)
        {
            if (TS10.Text == "")
            {
            }
            else
            {
                if (double.Parse(TS10.Text) <= 5.9)
                {
                    TS10.ForeColor = Color.Red;
                    if (double.Parse(TS10.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS10.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TS10.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS10.Text = "";
                    }
                    TS10.ForeColor = Color.Black;
                }
            }
        }

        private void TS11_Leave(object sender, EventArgs e)
        {
            if (TS11.Text == "")
            {
            }
            else
            {
                if (double.Parse(TS11.Text) <= 5.9)
                {
                    TS11.ForeColor = Color.Red;
                    if (double.Parse(TS11.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS11.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TS11.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS11.Text = "";
                    }
                    TS11.ForeColor = Color.Black;
                }
            }
        }

        private void TS12_Leave(object sender, EventArgs e)
        {
            if (TS12.Text == "")
            {
            }
            else
            {
                if (double.Parse(TS12.Text) <= 5.9)
                {
                    TS12.ForeColor = Color.Red;
                    if (double.Parse(TS12.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS12.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TS12.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS12.Text = "";
                    }
                    TS12.ForeColor = Color.Black;
                }
            }
        }

        private void TS13_Leave(object sender, EventArgs e)
        {
            if (TS13.Text == "")
            {
            }
            else
            {
                if (double.Parse(TS13.Text) <= 5.9)
                {
                    TS13.ForeColor = Color.Red;
                    if (double.Parse(TS13.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS13.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TS13.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS13.Text = "";
                    }
                    TS13.ForeColor = Color.Black;
                }
            }
        }

        private void TS14_Leave(object sender, EventArgs e)
        {
            if (TS14.Text == "")
            {
            }
            else
            {
                if (double.Parse(TS14.Text) <= 5.9)
                {
                    TS14.ForeColor = Color.Red;
                    if (double.Parse(TS14.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS14.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TS14.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS14.Text = "";
                    }
                    TS14.ForeColor = Color.Black;
                }
            }
        }

        private void TS15_Leave(object sender, EventArgs e)
        {
            if (TS15.Text == "")
            {
            }
            else
            {
                if (double.Parse(TS15.Text) <= 5.9)
                {
                    TS15.ForeColor = Color.Red;
                    if (double.Parse(TS15.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS15.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TS15.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS15.Text = "";
                    }
                    TS15.ForeColor = Color.Black;
                }
            }
        }

        private void TS16_Leave(object sender, EventArgs e)
        {
            if (TS16.Text == "")
            {
            }
            else
            {
                if (double.Parse(TS16.Text) <= 5.9)
                {
                    TS16.ForeColor = Color.Red;
                    if (double.Parse(TS16.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS16.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TS16.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS16.Text = "";
                    }
                    TS16.ForeColor = Color.Black;
                }

            }
        }

        private void textBox45_Leave(object sender, EventArgs e)
        {
            if (txt5.Text == "")
            {
            }
            else
            {
                if (double.Parse(txt5.Text) <= 5.9)
                {
                    txt5.ForeColor = Color.Red;
                    if (double.Parse(txt5.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt5.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(txt5.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt5.Text = "";
                    }
                    txt5.ForeColor = Color.Black;
                }
            }
        }

        private void TS17_Leave(object sender, EventArgs e)
        {
            if (TS17.Text == "")
            {
            }
            else
            {
                if (double.Parse(TS17.Text) <= 5.9)
                {
                    TS17.ForeColor = Color.Red;
                    if (double.Parse(TS17.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS17.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TS17.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS17.Text = "";
                    }
                    TS17.ForeColor = Color.Black;
                }
            }
        }

        private void TS18_Leave(object sender, EventArgs e)
        {
            if (TS18.Text == "")
            {
            }
            else
            {
                if (double.Parse(TS18.Text) <= 5.9)
                {
                    TS18.ForeColor = Color.Red;
                    if (double.Parse(TS18.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS18.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TS18.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TS18.Text = "";
                    }
                    TS18.ForeColor = Color.Black;
                }
            }
        }

        private void textBox46_Leave(object sender, EventArgs e)
        {
            if (txt4.Text == "")
            {
            }
            else
            {
                if (double.Parse(txt4.Text) <= 5.9)
                {
                    txt4.ForeColor = Color.Red;
                    if (double.Parse(txt4.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt4.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(txt4.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt4.Text = "";
                    }
                    txt4.ForeColor = Color.Black;
                }
            }
        }

        private void textBox44_Leave(object sender, EventArgs e)
        {
            if (txt6.Text == "")
            {
            }
            else
            {
                if (double.Parse(txt6.Text) <= 5.9)
                {
                    txt6.ForeColor = Color.Red;
                    if (double.Parse(txt6.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt6.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(txt6.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt6.Text = "";
                    }
                    txt6.ForeColor = Color.Black;
                }
            }
        }

        private void TS20_Leave(object sender, EventArgs e)
        {

        }

        private void TS21_Leave(object sender, EventArgs e)
        {

        }

        private void TO1_Leave(object sender, EventArgs e)
        {
            if (TO1.Text == "")
            {
            }
            else
            {
                if (double.Parse(TO1.Text) <= 5.9)
                {
                    TO1.ForeColor = Color.Red;
                    if (double.Parse(TO1.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO1.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TO1.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO1.Text = "";
                    }
                    TO1.ForeColor = Color.Black;
                }
            }
        }

        private void TO2_Leave(object sender, EventArgs e)
        {
            if (TO2.Text == "")
            {
            }
            else
            {
                if (double.Parse(TO2.Text) <= 5.9)
                {
                    TO2.ForeColor = Color.Red;
                    if (double.Parse(TO2.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO2.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TO2.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO2.Text = "";
                    }
                    TO2.ForeColor = Color.Black;
                }
            }
        }

        private void TO3_Leave(object sender, EventArgs e)
        {
            if (TO3.Text == "")
            {
            }
            else
            {
                if (double.Parse(TO3.Text) <= 5.9)
                {
                    TO3.ForeColor = Color.Red;
                    if (double.Parse(TO3.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO3.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TO3.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO3.Text = "";
                    }
                    TO3.ForeColor = Color.Black;
                }
            }
        }

        private void TO4_Leave(object sender, EventArgs e)
        {
            if (TO4.Text == "")
            {
            }
            else
            {
                if (double.Parse(TO4.Text) <= 5.9)
                {
                    TO4.ForeColor = Color.Red;
                    if (double.Parse(TO4.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO4.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TO4.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO4.Text = "";
                    }
                    TO4.ForeColor = Color.Black;
                }
            }
        }

        private void TO5_Leave(object sender, EventArgs e)
        {
            if (TO5.Text == "")
            {
            }
            else
            {
                if (double.Parse(TO5.Text) <= 5.9)
                {
                    TO5.ForeColor = Color.Red;
                    if (double.Parse(TO5.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO5.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TO5.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO5.Text = "";
                    }
                    TO5.ForeColor = Color.Black;
                }
            }
        }

        private void TO6_Leave(object sender, EventArgs e)
        {
            if (TO6.Text == "")
            {
            }
            else
            {
                if (double.Parse(TO6.Text) <= 5.9)
                {
                    TO6.ForeColor = Color.Red;
                    if (double.Parse(TO6.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO6.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TO6.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO6.Text = "";
                    }
                    TO6.ForeColor = Color.Black;
                }
            }
        }

        private void TO7_Leave(object sender, EventArgs e)
        {
            if (TO7.Text == "")
            {
            }
            else
            {
                if (double.Parse(TO7.Text) <= 5.9)
                {
                    TO7.ForeColor = Color.Red;
                    if (double.Parse(TO7.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO7.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TO7.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO7.Text = "";
                    }
                    TO7.ForeColor = Color.Black;
                }
            }
        }

        private void TO8_Leave(object sender, EventArgs e)
        {
            if (TO8.Text == "")
            {
            }
            else
            {
                if (double.Parse(TO8.Text) <= 5.9)
                {
                    TO8.ForeColor = Color.Red;
                    if (double.Parse(TO8.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO8.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TO8.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO8.Text = "";
                    }
                    TO8.ForeColor = Color.Black;
                }
            }
        }

        private void T10_Leave(object sender, EventArgs e)
        {
            if (T10.Text == "")
            {
            }
            else
            {
                if (double.Parse(T10.Text) <= 5.9)
                {
                    T10.ForeColor = Color.Red;
                    if (double.Parse(T10.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        T10.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(T10.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        T10.Text = "";
                    }
                    T10.ForeColor = Color.Black;
                }
            }
        }

        private void TO11_Leave(object sender, EventArgs e)
        {
            if (TO11.Text == "")
            {
            }
            else
            {
                if (double.Parse(TO11.Text) <= 5.9)
                {
                    TO11.ForeColor = Color.Red;
                    if (double.Parse(TO11.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO11.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TO11.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO11.Text = "";
                    }
                    TO11.ForeColor = Color.Black;
                }
            }
        }

        private void TO12_Leave(object sender, EventArgs e)
        {
            if (TO12.Text == "")
            {
            }
            else
            {
                if (double.Parse(TO12.Text) <= 5.9)
                {
                    TO12.ForeColor = Color.Red;
                    if (double.Parse(TO12.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO12.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TO12.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO12.Text = "";
                    }
                    TO12.ForeColor = Color.Black;
                }
            }
        }

        private void TO13_Leave(object sender, EventArgs e)
        {
            if (TO13.Text == "")
            {
            }
            else
            {
                if (double.Parse(TO13.Text) <= 5.9)
                {
                    TO13.ForeColor = Color.Red;
                    if (double.Parse(TO13.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO13.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TO13.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO13.Text = "";
                    }
                    TO13.ForeColor = Color.Black;
                }
            }
        }

        private void TO14_Leave(object sender, EventArgs e)
        {
            if (TO14.Text == "")
            {
            }
            else
            {
                if (double.Parse(TO14.Text) <= 5.9)
                {
                    TO14.ForeColor = Color.Red;
                    if (double.Parse(TO14.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO14.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TO14.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO14.Text = "";
                    }
                    TO14.ForeColor = Color.Black;
                }
            }
        }

        private void TO15_Leave(object sender, EventArgs e)
        {
            if (TO15.Text == "")
            {
            }
            else
            {
                if (double.Parse(TO15.Text) <= 5.9)
                {
                    TO15.ForeColor = Color.Red;
                    if (double.Parse(TO15.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO15.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TO15.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO15.Text = "";
                    }
                    TO15.ForeColor = Color.Black;
                }
            }
        }

        private void TO16_Leave(object sender, EventArgs e)
        {
            if (TO16.Text == "")
            {
            }
            else
            {
                if (double.Parse(TO16.Text) <= 5.9)
                {
                    TO16.ForeColor = Color.Red;
                    if (double.Parse(TO16.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO16.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TO16.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO16.Text = "";
                    }
                    TO16.ForeColor = Color.Black;
                }
            }
        }

        private void TO17_Leave(object sender, EventArgs e)
        {
            if (TO17.Text == "")
            {
            }
            else
            {
                if (double.Parse(TO17.Text) <= 5.9)
                {
                    TO17.ForeColor = Color.Red;
                    if (double.Parse(TO17.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO17.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TO17.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO17.Text = "";
                    }
                    TO17.ForeColor = Color.Black;
                }
            }
        }

        private void TO18_Leave(object sender, EventArgs e)
        {
            if (TO18.Text == "")
            {
            }
            else
            {
                if (double.Parse(TO18.Text) <= 5.9)
                {
                    TO18.ForeColor = Color.Red;
                    if (double.Parse(TO18.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO18.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TO18.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TO18.Text = "";
                    }
                    TO18.ForeColor = Color.Black;
                }
            }
        }

        private void textBox43_Leave(object sender, EventArgs e)
        {
            if (txt7.Text == "")
            {
            }
            else
            {
                if (double.Parse(txt7.Text) <= 5.9)
                {
                    txt7.ForeColor = Color.Red;
                    if (double.Parse(txt7.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt7.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(txt7.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt7.Text = "";
                    }
                    txt7.ForeColor = Color.Black;
                }
            }
        }

        private void textBox41_Leave(object sender, EventArgs e)
        {
            if (txt8.Text == "")
            {
            }
            else
            {
                if (double.Parse(txt8.Text) <= 5.9)
                {
                    txt8.ForeColor = Color.Red;
                    if (double.Parse(txt8.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt8.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(txt8.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt8.Text = "";
                    }
                    txt8.ForeColor = Color.Black;
                }
            }
        }

        private void textBox42_Leave(object sender, EventArgs e)
        {
            if (txt9.Text == "")
            {
            }
            else
            {
                if (double.Parse(txt9.Text) <= 5.9)
                {
                    txt9.ForeColor = Color.Red;
                    if (double.Parse(txt9.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt9.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(txt9.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt9.Text = "";
                    }
                    txt9.ForeColor = Color.Black;
                }
            }
        }

        private void TN1_Leave(object sender, EventArgs e)
        {
            if (TN1.Text == "")
            {
            }
            else
            {
                if (double.Parse(TN1.Text) <= 5.9)
                {
                    TN1.ForeColor = Color.Red;
                    if (double.Parse(TN1.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN1.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TN1.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN1.Text = "";
                    }
                    TN1.ForeColor = Color.Black;
                }
            }
        }

        private void TN2_Leave(object sender, EventArgs e)
        {
            if (TN2.Text == "")
            {
            }
            else
            {
                if (double.Parse(TN2.Text) <= 5.9)
                {
                    TN2.ForeColor = Color.Red;
                    if (double.Parse(TN2.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN2.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TN2.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN2.Text = "";
                    }
                    TN2.ForeColor = Color.Black;
                }
            }
        }

        private void TN3_Leave(object sender, EventArgs e)
        {
            if (TN3.Text == "")
            {
            }
            else
            {
                if (double.Parse(TN3.Text) <= 5.9)
                {
                    TN3.ForeColor = Color.Red;
                    if (double.Parse(TN3.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN3.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TN3.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN3.Text = "";
                    }
                    TN3.ForeColor = Color.Black;
                }
            }
        }

        private void TN4_Leave(object sender, EventArgs e)
        {
            if (TN4.Text == "")
            {
            }
            else
            {
                if (double.Parse(TN4.Text) <= 5.9)
                {
                    TN4.ForeColor = Color.Red;
                    if (double.Parse(TN4.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN4.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TN4.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN4.Text = "";
                    }
                    TN4.ForeColor = Color.Black;
                }
            }
        }

        private void TN5_Leave(object sender, EventArgs e)
        {
            if (TN5.Text == "")
            {
            }
            else
            {
                if (double.Parse(TN5.Text) <= 5.9)
                {
                    TN5.ForeColor = Color.Red;
                    if (double.Parse(TN5.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN5.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TN5.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN5.Text = "";
                    }
                    TN5.ForeColor = Color.Black;
                }
            }
        }

        private void TN6_Leave(object sender, EventArgs e)
        {
            if (TN6.Text == "")
            {
            }
            else
            {
                if (double.Parse(TN6.Text) <= 5.9)
                {
                    TN6.ForeColor = Color.Red;
                    if (double.Parse(TN6.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN6.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TN6.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN6.Text = "";
                    }
                    TN6.ForeColor = Color.Black;
                }
            }
        }

        private void TN7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TN7_Leave(object sender, EventArgs e)
        {
            if (TN7.Text == "")
            {
            }
            else
            {
                if (double.Parse(TN7.Text) <= 5.9)
                {
                    TN7.ForeColor = Color.Red;
                    if (double.Parse(TN7.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN7.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TN7.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN7.Text = "";
                    }
                    TN7.ForeColor = Color.Black;
                }
            }
        }

        private void TN8_Leave(object sender, EventArgs e)
        {
            if (TN8.Text == "")
            {
            }
            else
            {
                if (double.Parse(TN8.Text) <= 5.9)
                {
                    TN8.ForeColor = Color.Red;
                    if (double.Parse(TN8.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN8.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TN8.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN8.Text = "";
                    }
                    TN8.ForeColor = Color.Black;
                }
            }
        }

        private void TN10_Leave(object sender, EventArgs e)
        {
            if (TN10.Text == "")
            {
            }
            else
            {
                if (double.Parse(TN10.Text) <= 5.9)
                {
                    TN10.ForeColor = Color.Red;
                    if (double.Parse(TN10.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN10.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TN10.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN10.Text = "";
                    }
                    TN10.ForeColor = Color.Black;
                }
            }
        }

        private void TN11_Leave(object sender, EventArgs e)
        {
            if (TN11.Text == "")
            {
            }
            else
            {
                if (double.Parse(TN11.Text) <= 5.9)
                {
                    TN11.ForeColor = Color.Red;
                    if (double.Parse(TN11.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN11.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TN11.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN11.Text = "";
                    }
                    TN11.ForeColor = Color.Black;
                }
            }
        }

        private void TN12_Leave(object sender, EventArgs e)
        {
            if (TN12.Text == "")
            {
            }
            else
            {
                if (double.Parse(TN12.Text) <= 5.9)
                {
                    TN12.ForeColor = Color.Red;
                    if (double.Parse(TN12.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN12.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TN12.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN12.Text = "";
                    }
                    TN12.ForeColor = Color.Black;
                }
            }
        }

        private void TN13_Leave(object sender, EventArgs e)
        {
            if (TN13.Text == "")
            {
            }
            else
            {
                if (double.Parse(TN13.Text) <= 5.9)
                {
                    TN13.ForeColor = Color.Red;
                    if (double.Parse(TN13.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN13.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TN13.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN13.Text = "";
                    }
                    TN13.ForeColor = Color.Black;
                }
            }
        }

        private void TN14_Leave(object sender, EventArgs e)
        {
            if (TN14.Text == "")
            {
            }
            else
            {
                if (double.Parse(TN14.Text) <= 5.9)
                {
                    TN14.ForeColor = Color.Red;
                    if (double.Parse(TN14.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN14.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TN14.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN14.Text = "";
                    }
                    TN14.ForeColor = Color.Black;
                }
            }
        }

        private void TN15_Leave(object sender, EventArgs e)
        {
            if (TN15.Text == "")
            {
            }
            else
            {
                if (double.Parse(TN15.Text) <= 5.9)
                {
                    TN15.ForeColor = Color.Red;
                    if (double.Parse(TN15.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN15.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TN15.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN15.Text = "";
                    }
                    TN15.ForeColor = Color.Black;
                }
            }
        }

        private void TN16_Leave(object sender, EventArgs e)
        {
            if (TN16.Text == "")
            {
            }
            else
            {
                if (double.Parse(TN16.Text) <= 5.9)
                {
                    TN16.ForeColor = Color.Red;
                    if (double.Parse(TN16.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN16.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TN16.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN16.Text = "";
                    }
                    TN16.ForeColor = Color.Black;
                }
            }
        }

        private void TN17_Leave(object sender, EventArgs e)
        {
            if (TN17.Text == "")
            {
            }
            else
            {
                if (double.Parse(TN17.Text) <= 5.9)
                {
                    TN17.ForeColor = Color.Red;
                    if (double.Parse(TN17.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN17.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TN17.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN17.Text = "";
                    }
                    TN17.ForeColor = Color.Black;
                }
            }
        }

        private void TN18_Leave(object sender, EventArgs e)
        {
            if (TN18.Text == "")
            {
            }
            else
            {
                if (double.Parse(TN18.Text) <= 5.9)
                {
                    TN18.ForeColor = Color.Red;
                    if (double.Parse(TN18.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN18.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TN18.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TN18.Text = "";
                    }
                    TN18.ForeColor = Color.Black;
                }
            }
        }

        private void textBox37_Leave(object sender, EventArgs e)
        {
            if (txt10.Text == "")
            {
            }
            else
            {
                if (double.Parse(txt10.Text) <= 5.9)
                {
                    txt10.ForeColor = Color.Red;
                    if (double.Parse(txt10.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt10.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(txt10.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt10.Text = "";
                    }
                    txt10.ForeColor = Color.Black;
                }
            }
        }

        private void textBox38_Leave(object sender, EventArgs e)
        {
            if (txt11.Text == "")
            {
            }
            else
            {
                if (double.Parse(txt11.Text) <= 5.9)
                {
                    txt11.ForeColor = Color.Red;
                    if (double.Parse(txt11.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt11.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(txt11.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt11.Text = "";
                    }
                    txt11.ForeColor = Color.Black;
                }
            }
        }

        private void textBox39_Leave(object sender, EventArgs e)
        {
            if (txt12.Text == "")
            {
            }
            else
            {
                if (double.Parse(txt12.Text) <= 5.9)
                {
                    txt12.ForeColor = Color.Red;
                    if (double.Parse(txt12.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt12.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(txt12.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt12.Text = "";
                    }
                    txt12.ForeColor = Color.Black;
                }
            }
        }

        private void TDD1_Leave(object sender, EventArgs e)
        {
            if (TDD1.Text == "")
            {
            }
            else
            {
                if (double.Parse(TDD1.Text) <= 5.9)
                {
                    TDD1.ForeColor = Color.Red;
                    if (double.Parse(TDD1.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD1.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TDD1.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD1.Text = "";
                    }
                    TDD1.ForeColor = Color.Black;
                }
            }
        }

        private void TDD2_Leave(object sender, EventArgs e)
        {
            if (TDD2.Text == "")
            {
            }
            else
            {
                if (double.Parse(TDD2.Text) <= 5.9)
                {
                    TDD2.ForeColor = Color.Red;
                    if (double.Parse(TDD2.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD2.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TDD2.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD2.Text = "";
                    }
                    TDD2.ForeColor = Color.Black;
                }
            }
        }

        private void TDD3_Leave(object sender, EventArgs e)
        {
            if (TDD3.Text == "")
            {
            }
            else
            {
                if (double.Parse(TDD3.Text) <= 5.9)
                {
                    TDD3.ForeColor = Color.Red;
                    if (double.Parse(TDD3.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD3.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TDD3.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD3.Text = "";
                    }
                    TDD3.ForeColor = Color.Black;
                }
            }
        }

        private void TDD4_Leave(object sender, EventArgs e)
        {
            if (TDD4.Text == "")
            {
            }
            else
            {
                if (double.Parse(TDD4.Text) <= 5.9)
                {
                    TDD4.ForeColor = Color.Red;
                    if (double.Parse(TDD4.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD4.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TDD4.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD4.Text = "";
                    }
                    TDD4.ForeColor = Color.Black;
                }
            }
        }

        private void TDD5_Leave(object sender, EventArgs e)
        {
            if (TDD5.Text == "")
            {
            }
            else
            {
                if (double.Parse(TDD5.Text) <= 5.9)
                {
                    TDD5.ForeColor = Color.Red;
                    if (double.Parse(TDD5.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD5.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TDD5.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD5.Text = "";
                    }
                    TDD5.ForeColor = Color.Black;
                }
            }
        }

        private void TDD6_Leave(object sender, EventArgs e)
        {
            if (TDD6.Text == "")
            {
            }
            else
            {
                if (double.Parse(TDD6.Text) <= 5.9)
                {
                    TDD6.ForeColor = Color.Red;
                    if (double.Parse(TDD6.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD6.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TDD6.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD6.Text = "";
                    }
                    TDD6.ForeColor = Color.Black;
                }
            }
        }

        private void TDD7_Leave(object sender, EventArgs e)
        {
            if (TDD7.Text == "")
            {
            }
            else
            {
                if (double.Parse(TDD7.Text) <= 5.9)
                {
                    TDD7.ForeColor = Color.Red;
                    if (double.Parse(TDD7.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD7.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TDD7.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD7.Text = "";
                    }
                    TDD7.ForeColor = Color.Black;
                }
            }
        }

        private void TDD8_Leave(object sender, EventArgs e)
        {
            if (TDD8.Text == "")
            {
            }
            else
            {
                if (double.Parse(TDD8.Text) <= 5.9)
                {
                    TDD8.ForeColor = Color.Red;
                    if (double.Parse(TDD8.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD8.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TDD8.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD8.Text = "";
                    }
                    TDD8.ForeColor = Color.Black;
                }
            }
        }

        private void TDD10_Leave(object sender, EventArgs e)
        {
            if (TDD10.Text == "")
            {
            }
            else
            {
                if (double.Parse(TDD10.Text) <= 5.9)
                {
                    TDD10.ForeColor = Color.Red;
                    if (double.Parse(TDD10.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD10.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TDD10.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD10.Text = "";
                    }
                    TDD10.ForeColor = Color.Black;
                }
            }
        }

        private void TDD11_Leave(object sender, EventArgs e)
        {
            if (TDD11.Text == "")
            {
            }
            else
            {
                if (double.Parse(TDD11.Text) <= 5.9)
                {
                    TDD11.ForeColor = Color.Red;
                    if (double.Parse(TDD11.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD11.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TDD11.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD11.Text = "";
                    }
                    TDD11.ForeColor = Color.Black;
                }
            }
        }

        private void TDD12_Leave(object sender, EventArgs e)
        {
            if (TDD12.Text == "")
            {
            }
            else
            {
                if (double.Parse(TDD12.Text) <= 5.9)
                {
                    TDD12.ForeColor = Color.Red;
                    if (double.Parse(TDD12.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD12.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TDD12.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD12.Text = "";
                    }
                    TDD12.ForeColor = Color.Black;
                }
            }
        }

        private void TDD13_Leave(object sender, EventArgs e)
        {
            if (TDD13.Text == "")
            {
            }
            else
            {
                if (double.Parse(TDD13.Text) <= 5.9)
                {
                    TDD13.ForeColor = Color.Red;
                    if (double.Parse(TDD13.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD13.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TDD13.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD13.Text = "";
                    }
                    TDD13.ForeColor = Color.Black;
                }
            }
        }

        private void TDD14_Leave(object sender, EventArgs e)
        {
            if (TDD14.Text == "")
            {
            }
            else
            {
                if (double.Parse(TDD14.Text) <= 5.9)
                {
                    TDD14.ForeColor = Color.Red;
                    if (double.Parse(TDD14.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD14.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TDD14.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD14.Text = "";
                    }
                    TDD14.ForeColor = Color.Black;
                }
            }
        }

        private void TDD15_Leave(object sender, EventArgs e)
        {
            if (TDD15.Text == "")
            {
            }
            else
            {
                if (double.Parse(TDD15.Text) <= 5.9)
                {
                    TDD15.ForeColor = Color.Red;
                    if (double.Parse(TDD15.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD15.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TDD15.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD15.Text = "";
                    }
                    TDD15.ForeColor = Color.Black;
                }
            }
        }

        private void TDD16_Leave(object sender, EventArgs e)
        {
            if (TDD16.Text == "")
            {
            }
            else
            {
                if (double.Parse(TDD16.Text) <= 5.9)
                {
                    TDD16.ForeColor = Color.Red;
                    if (double.Parse(TDD16.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD16.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TDD16.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD16.Text = "";
                    }
                    TDD16.ForeColor = Color.Black;
                }
            }
        }

        private void TDD17_Leave(object sender, EventArgs e)
        {
            if (TDD17.Text == "")
            {
            }
            else
            {
                if (double.Parse(TDD17.Text) <= 5.9)
                {
                    TDD17.ForeColor = Color.Red;
                    if (double.Parse(TDD17.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD17.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TDD17.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD17.Text = "";
                    }
                    TDD17.ForeColor = Color.Black;
                }
            }
        }

        private void TDD18_Leave(object sender, EventArgs e)
        {
            if (TDD18.Text == "")
            {
            }
            else
            {
                if (double.Parse(TDD18.Text) <= 5.9)
                {
                    TDD18.ForeColor = Color.Red;
                    if (double.Parse(TDD18.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD18.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TDD18.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TDD18.Text = "";
                    }
                    TDD18.ForeColor = Color.Black;
                }
            }
        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox49_Leave(object sender, EventArgs e)
        {
            if (txt13.Text == "")
            {
            }
            else
            {
                if (double.Parse(txt13.Text) <= 5.9)
                {
                    txt13.ForeColor = Color.Red;
                    if (double.Parse(txt13.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt13.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(txt13.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt13.Text = "";
                    }
                    txt13.ForeColor = Color.Black;
                }
            }
        }

        private void textBox50_Leave(object sender, EventArgs e)
        {
            if (txt14.Text == "")
            {
            }
            else
            {
                if (double.Parse(txt14.Text) <= 5.9)
                {
                    txt14.ForeColor = Color.Red;
                    if (double.Parse(txt14.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt14.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(txt14.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt14.Text = "";
                    }
                    txt14.ForeColor = Color.Black;
                }
            }
        }

        private void textBox51_Leave(object sender, EventArgs e)
        {
            if (txt15.Text == "")
            {
            }
            else
            {
                if (double.Parse(txt15.Text) <= 5.9)
                {
                    txt15.ForeColor = Color.Red;
                    if (double.Parse(txt15.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt15.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(txt15.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        txt15.Text = "";
                    }
                    txt15.ForeColor = Color.Black;
                }
            }
        }

        private void TE1_Leave(object sender, EventArgs e)
        {
            if (TE1.Text == "")
            {
            }
            else
            {
                if (double.Parse(TE1.Text) <= 5.9)
                {
                    TE1.ForeColor = Color.Red;
                    if (double.Parse(TE1.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TE1.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TE1.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TE1.Text = "";
                    }
                    TE1.ForeColor = Color.Black;
                }
            }
        }

        private void TE2_Leave(object sender, EventArgs e)
        {
            if (TE2.Text == "")
            {
            }
            else
            {
                if (double.Parse(TE2.Text) <= 5.9)
                {
                    TE2.ForeColor = Color.Red;
                    if (double.Parse(TE2.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TE2.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TE2.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TE2.Text = "";
                    }
                    TE2.ForeColor = Color.Black;
                }
            }
        }

        private void TE3_Leave(object sender, EventArgs e)
        {
            if (TE3.Text == "")
            {
            }
            else
            {
                if (double.Parse(TE3.Text) <= 5.9)
                {
                    TE3.ForeColor = Color.Red;
                    if (double.Parse(TE3.Text) <= 4.9)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TE3.Text = "";
                    }
                }
                else
                {
                    if (double.Parse(TE3.Text) > 10)
                    {
                        MessageBox.Show("Calificacion no valida");
                        TE3.Text = "";
                    }
                    TE3.ForeColor = Color.Black;
                }
            }
        }

        private void TD10_TextChanged(object sender, EventArgs e)
        {

            if (TD10.Text == "" ||
                TD11.Text == "" ||
                TD12.Text == "" ||
                TD13.Text == "" ||
                TD14.Text == "" ||
                TD15.Text == "" ||
                TD16.Text == "" ||
                TD17.Text == "" ||
                TD18.Text == "" ||
                txt1.Text == "" ||
                txt3.Text == "" ||
                txt2.Text == "")
            {
            }
            else
            {
                double total = double.Parse(TD10.Text) + double.Parse(TD11.Text) + double.Parse(TD12.Text) + double.Parse(TD13.Text) + double.Parse(TD14.Text) + double.Parse(TD15.Text) + double.Parse(TD16.Text) + double.Parse(TD17.Text) + double.Parse(TD18.Text) + double.Parse(txt2.Text) + double.Parse(txt3.Text) + double.Parse(txt1.Text);
                TD19.Text = Convert.ToString(total / 12);

                double promedio = double.Parse(TD9.Text) + double.Parse(TD19.Text); ;
                TD20.Text = Convert.ToString(promedio / 2);

                if (TD2.Text == "" ||
                TD1.Text == "" ||
                TD3.Text == "" ||
                TD4.Text == "" ||
                TD5.Text == "" ||
                TD6.Text == "" ||
                TD7.Text == "" ||
                TD8.Text == "" ||

                TD10.Text == "" ||
                TD11.Text == "" ||
                TD12.Text == "" ||
                TD13.Text == "" ||
                TD14.Text == "" ||
                TD15.Text == "" ||
                TD16.Text == "" ||
                TD17.Text == "" ||
                TD18.Text == "" ||
                txt1.Text == "" ||
                txt2.Text == "" ||
                txt3.Text == "")
                {

                }
                else
                {
                    double puntos = double.Parse(TD10.Text) + double.Parse(TD11.Text) + double.Parse(TD12.Text) + double.Parse(TD13.Text) + double.Parse(TD14.Text) + double.Parse(TD15.Text) + double.Parse(TD16.Text) + double.Parse(TD17.Text) + double.Parse(TD18.Text) + double.Parse(txt2.Text) + double.Parse(txt3.Text) + double.Parse(txt1.Text) +
                        double.Parse(TD1.Text) + double.Parse(TD2.Text) + double.Parse(TD3.Text) + double.Parse(TD4.Text) + double.Parse(TD5.Text) + double.Parse(TD6.Text) + double.Parse(TD7.Text) + double.Parse(TD8.Text);
                    TD21.Text = Convert.ToString(puntos);
                }
            }
        }

        private void TS1_TextChanged(object sender, EventArgs e)
        {
            if (TS1.Text == "" ||
                    TS2.Text == "" ||
                    TS3.Text == "" ||
                    TS4.Text == "" ||
                    TS5.Text == "" ||
                    TS6.Text == "" ||
                    TS7.Text == "" ||
                    TS8.Text == "")
            {

            }
            else
            {
                double total = double.Parse(TS1.Text) + double.Parse(TS2.Text) + double.Parse(TS3.Text) + double.Parse(TS4.Text) + double.Parse(TS5.Text) + double.Parse(TS6.Text) + double.Parse(TS7.Text) + double.Parse(TS8.Text);
                TS9.Text = Convert.ToString(total / 8);
            }
        }

        private void TS10_TextChanged(object sender, EventArgs e)
        {
            if (TS10.Text == "" ||
                    TS11.Text == "" ||
                    TS12.Text == "" ||
                    TS13.Text == "" ||
                    TS14.Text == "" ||
                    TS15.Text == "" ||
                    TS16.Text == "" ||
                    TS17.Text == "" ||
                    TS18.Text == "" ||
                    txt6.Text == "" ||
                    txt5.Text == "" ||
                    txt4.Text == "")
            {

            }
            else
            {
                double total = double.Parse(TS10.Text) + double.Parse(TS11.Text) + double.Parse(TS12.Text) + double.Parse(TS13.Text) + double.Parse(TS14.Text) + double.Parse(TS15.Text) + double.Parse(TS16.Text) + double.Parse(TS17.Text) + double.Parse(TS18.Text) + double.Parse(txt6.Text) + double.Parse(txt5.Text) + double.Parse(txt4.Text);
                TS19.Text = Convert.ToString(total / 12);

                if (TS9.Text == "" || TS19.Text == "")
                {

                }
                else
                {
                    double promedio = double.Parse(TS9.Text) + double.Parse(TS19.Text); ;
                    TS20.Text = Convert.ToString(promedio / 2);

                    if (TS1.Text == "" ||
                TS2.Text == "" ||
                TS3.Text == "" ||
                TS4.Text == "" ||
                TS5.Text == "" ||
                TS6.Text == "" ||
                TS7.Text == "" ||
                TS8.Text == "" ||

                TS10.Text == "" ||
                TS11.Text == "" ||
                TS12.Text == "" ||
                TS13.Text == "" ||
                TS14.Text == "" ||
                TS15.Text == "" ||
                TS16.Text == "" ||
                TS17.Text == "" ||
                TS18.Text == "" ||
                txt6.Text == "" ||
                txt5.Text == "" ||
                txt4.Text == "")
                    {

                    }
                    else
                    {
                        double puntos = double.Parse(TS1.Text) + double.Parse(TS2.Text) + double.Parse(TS3.Text) + double.Parse(TS4.Text) + double.Parse(TS5.Text) + double.Parse(TS6.Text) + double.Parse(TS7.Text) + double.Parse(TS8.Text) +
                            double.Parse(TS10.Text) + double.Parse(TS11.Text) + double.Parse(TS12.Text) + double.Parse(TS13.Text) + double.Parse(TS14.Text) + double.Parse(TS15.Text) + double.Parse(TS16.Text) + double.Parse(TS17.Text) + double.Parse(TS18.Text) + double.Parse(txt6.Text) + double.Parse(txt5.Text) + double.Parse(txt4.Text);
                        TS21.Text = Convert.ToString(puntos);
                    }
                }
            }
        }

        private void TO1_TextChanged(object sender, EventArgs e)
        {
            if (TO1.Text == "" ||
                   TO2.Text == "" ||
                   TO3.Text == "" ||
                   TO4.Text == "" ||
                   TO5.Text == "" ||
                   TO6.Text == "" ||
                   TO7.Text == "" ||
                   TO8.Text == "")
            {

            }
            else
            {
                double total = double.Parse(TO1.Text) + double.Parse(TO2.Text) + double.Parse(TO3.Text) + double.Parse(TO4.Text) + double.Parse(TO5.Text) + double.Parse(TO6.Text) + double.Parse(TO7.Text) + double.Parse(TO8.Text);
                TO9.Text = Convert.ToString(total / 8);

                double PROM1 = double.Parse(TS1.Text) + double.Parse(TO1.Text);
                double PROM2 = double.Parse(TS2.Text) + double.Parse(TO2.Text);
                double PROM3 = double.Parse(TS3.Text) + double.Parse(TO3.Text);
                double PROM4 = double.Parse(TS4.Text) + double.Parse(TO4.Text);
                double PROM5 = double.Parse(TS5.Text) + double.Parse(TO5.Text);
                double PROM6 = double.Parse(TS6.Text) + double.Parse(TO6.Text);
                double PROM7 = double.Parse(TS7.Text) + double.Parse(TO7.Text);
                double PROM8 = double.Parse(TS8.Text) + double.Parse(TO8.Text);

                B11.Text = Convert.ToString(PROM1 / 2);
                B12.Text = Convert.ToString(PROM2 / 2);
                B13.Text = Convert.ToString(PROM3 / 2);
                B14.Text = Convert.ToString(PROM4 / 2);
                B15.Text = Convert.ToString(PROM5 / 2);
                B16.Text = Convert.ToString(PROM6 / 2);
                B17.Text = Convert.ToString(PROM7 / 2);
                B18.Text = Convert.ToString(PROM8 / 2);
            }

        }

        private void T10_TextChanged(object sender, EventArgs e)
        {
            if (T10.Text == "" ||
                    TO11.Text == "" ||
                    TO12.Text == "" ||
                    TO13.Text == "" ||
                    TO14.Text == "" ||
                    TO15.Text == "" ||
                    TO16.Text == "" ||
                    TO17.Text == "" ||
                    TO18.Text == "" ||
                    txt9.Text == "" ||
                    txt8.Text == "" ||
                    txt7.Text == "")
            {

            }
            else
            {
                double total = double.Parse(T10.Text) + double.Parse(TO11.Text) + double.Parse(TO12.Text) + double.Parse(TO13.Text) + double.Parse(TO14.Text) + double.Parse(TO15.Text) + double.Parse(TO16.Text) + double.Parse(TO17.Text) + double.Parse(TO18.Text) + double.Parse(txt8.Text) + double.Parse(txt9.Text) + double.Parse(txt7.Text);
                TO19.Text = Convert.ToString(total / 12);

                double PROM1 = double.Parse(T10.Text) + double.Parse(TS10.Text);
                double PROM2 = double.Parse(TO11.Text) + double.Parse(TS11.Text);
                double PROM3 = double.Parse(TO12.Text) + double.Parse(TS12.Text);
                double PROM4 = double.Parse(TO13.Text) + double.Parse(TS13.Text);
                double PROM5 = double.Parse(TO14.Text) + double.Parse(TS14.Text);
                double PROM6 = double.Parse(TO15.Text) + double.Parse(TS15.Text);
                double PROM7 = double.Parse(TO16.Text) + double.Parse(TS16.Text);
                double PROM8 = double.Parse(TO17.Text) + double.Parse(TS17.Text);
                double PROM9 = double.Parse(TO18.Text) + double.Parse(TS18.Text);
                double PROM10 = double.Parse(txt7.Text) + double.Parse(txt4.Text);
                double PROM11 = double.Parse(txt8.Text) + double.Parse(txt5.Text);
                double PROM12 = double.Parse(txt9.Text) + double.Parse(txt6.Text);

                B110.Text = Convert.ToString(PROM1 / 2);
                B111.Text = Convert.ToString(PROM2 / 2);
                B112.Text = Convert.ToString(PROM3 / 2);
                B113.Text = Convert.ToString(PROM4 / 2);
                B114.Text = Convert.ToString(PROM5 / 2);
                B115.Text = Convert.ToString(PROM6 / 2);
                B116.Text = Convert.ToString(PROM7 / 2);
                B117.Text = Convert.ToString(PROM8 / 2);
                B118.Text = Convert.ToString(PROM9 / 2);
                textBox16.Text = Convert.ToString(PROM10 / 2);
                textBox17.Text = Convert.ToString(PROM11 / 2);
                textBox18.Text = Convert.ToString(PROM12 / 2);

                if (TO9.Text == "" || TO19.Text == "")
                {

                }
                else
                {
                    double promedio = double.Parse(TO9.Text) + double.Parse(TO19.Text); ;
                    TO20.Text = Convert.ToString(promedio / 2);
                }
                if (TO1.Text == "" ||
                    TO2.Text == "" ||
                    TO3.Text == "" ||
                    TO4.Text == "" ||
                    TO5.Text == "" ||
                    TO6.Text == "" ||
                    TO7.Text == "" ||
                    TO8.Text == "" ||
                    T10.Text == "" ||
                     TO11.Text == "" ||
                     TO12.Text == "" ||
                     TO13.Text == "" ||
                     TO14.Text == "" ||
                     TO15.Text == "" ||
                     TO16.Text == "" ||
                     TO17.Text == "" ||
                     TO18.Text == "" ||
                     txt9.Text == "" ||
                     txt8.Text == "" ||
                     txt7.Text == "")
                {

                }
                else
                {
                    double puntos = double.Parse(TO1.Text) + double.Parse(TO2.Text) + double.Parse(TO3.Text) + double.Parse(TO4.Text) + double.Parse(TO5.Text) + double.Parse(TO6.Text) + double.Parse(TO7.Text) + double.Parse(TO8.Text) +
                        double.Parse(T10.Text) + double.Parse(TO11.Text) + double.Parse(TO12.Text) + double.Parse(TO13.Text) + double.Parse(TO14.Text) + double.Parse(TO15.Text) + double.Parse(TO16.Text) + double.Parse(TO17.Text) + double.Parse(TO18.Text) + double.Parse(txt8.Text) + double.Parse(txt9.Text) + double.Parse(txt7.Text);
                    TO21.Text = Convert.ToString(puntos);

                    double tolpuntos = double.Parse(TS21.Text) + double.Parse(TO21.Text);
                    B121.Text = Convert.ToString(tolpuntos);

                    double propuntos = double.Parse(B121.Text);
                    P21.Text = Convert.ToString(propuntos);


                }

                if (TS20.Text == "" || TO20.Text == "")
                {

                }
                else
                {
                    double promedio = double.Parse(TS20.Text) + double.Parse(TO20.Text); ;
                    B120.Text = Convert.ToString(promedio / 2);

                    double general = double.Parse(B120.Text);
                    P20.Text = Convert.ToString(general);
                }
            }
        }

        private void TN10_TextChanged_1(object sender, EventArgs e)
        {

            if (TN10.Text == "" ||
                    TN11.Text == "" ||
                    TN12.Text == "" ||
                    TN13.Text == "" ||
                    TN14.Text == "" ||
                    TN15.Text == "" ||
                    TN16.Text == "" ||
                    TN17.Text == "" ||
                    TN18.Text == "" ||
                    txt10.Text == "" ||
                    txt11.Text == "" ||
                    txt12.Text == "")
            {

            }
            else
            {
                double total = double.Parse(TN10.Text) + double.Parse(TN11.Text) + double.Parse(TN12.Text) + double.Parse(TN13.Text) + double.Parse(TN14.Text) + double.Parse(TN15.Text) + double.Parse(TN16.Text) + double.Parse(TN17.Text) + double.Parse(TN18.Text) + double.Parse(txt10.Text) + double.Parse(txt11.Text) + double.Parse(txt12.Text);
                TN19.Text = Convert.ToString(total / 12);

                if (TN9.Text == "" || TN19.Text == "")
                {

                }
                else
                {
                    double promedio = double.Parse(TN9.Text) + double.Parse(TN19.Text); ;
                    TN20.Text = Convert.ToString(promedio / 2);

                    if (TN1.Text == "" ||
                    TN2.Text == "" ||
                    TN3.Text == "" ||
                    TN4.Text == "" ||
                    TN5.Text == "" ||
                    TN6.Text == "" ||
                    TN7.Text == "" ||
                    TN8.Text == "" ||
                    TN10.Text == "" ||
                    TN11.Text == "" ||
                    TN12.Text == "" ||
                    TN13.Text == "" ||
                    TN14.Text == "" ||
                    TN15.Text == "" ||
                    TN16.Text == "" ||
                    TN17.Text == "" ||
                    TN18.Text == "" ||
                    txt10.Text == "" ||
                    txt11.Text == "" ||
                    txt12.Text == "")
                    {

                    }
                    else
                    {
                        double puntos = double.Parse(TN1.Text) + double.Parse(TN2.Text) + double.Parse(TN3.Text) + double.Parse(TN4.Text) + double.Parse(TN5.Text) + double.Parse(TN6.Text) + double.Parse(TN7.Text) + double.Parse(TN8.Text) +
                            double.Parse(TN10.Text) + double.Parse(TN11.Text) + double.Parse(TN12.Text) + double.Parse(TN13.Text) + double.Parse(TN14.Text) + double.Parse(TN15.Text) + double.Parse(TN16.Text) + double.Parse(TN17.Text) + double.Parse(TN18.Text) + double.Parse(txt10.Text) + double.Parse(txt11.Text) + double.Parse(txt12.Text);
                        TN21.Text = Convert.ToString(puntos);

                    }
                }
            }
        }

        private void TN1_TextChanged(object sender, EventArgs e)
        {
            if (TN1.Text == "" ||
                    TN2.Text == "" ||
                    TN3.Text == "" ||
                    TN4.Text == "" ||
                    TN5.Text == "" ||
                    TN6.Text == "" ||
                    TN7.Text == "" ||
                    TN8.Text == "")
            {

            }
            else
            {
                double total = double.Parse(TN1.Text) + double.Parse(TN2.Text) + double.Parse(TN3.Text) + double.Parse(TN4.Text) + double.Parse(TN5.Text) + double.Parse(TN6.Text) + double.Parse(TN7.Text) + double.Parse(TN8.Text);
                TN9.Text = Convert.ToString(total / 8);
            }
        }

        private void TDD1_TextChanged(object sender, EventArgs e)
        {
            if (TDD1.Text == "" ||
                    TDD2.Text == "" ||
                    TDD3.Text == "" ||
                    TDD4.Text == "" ||
                    TDD5.Text == "" ||
                    TDD6.Text == "" ||
                    TDD7.Text == "" ||
                    TDD8.Text == "")
            {

            }
            else
            {
                double total = double.Parse(TDD1.Text) + double.Parse(TDD2.Text) + double.Parse(TDD3.Text) + double.Parse(TDD4.Text) + double.Parse(TDD5.Text) + double.Parse(TDD6.Text) + double.Parse(TDD7.Text) + double.Parse(TDD8.Text);
                TDD9.Text = Convert.ToString(total / 8);

                double PROM1 = double.Parse(TN1.Text) + double.Parse(TDD1.Text);
                double PROM2 = double.Parse(TN2.Text) + double.Parse(TDD2.Text);
                double PROM3 = double.Parse(TN3.Text) + double.Parse(TDD3.Text);
                double PROM4 = double.Parse(TN4.Text) + double.Parse(TDD4.Text);
                double PROM5 = double.Parse(TN5.Text) + double.Parse(TDD5.Text);
                double PROM6 = double.Parse(TN6.Text) + double.Parse(TDD6.Text);
                double PROM7 = double.Parse(TN7.Text) + double.Parse(TDD7.Text);
                double PROM8 = double.Parse(TN8.Text) + double.Parse(TDD8.Text);

                B21.Text = Convert.ToString(PROM1 / 2);
                B22.Text = Convert.ToString(PROM2 / 2);
                B23.Text = Convert.ToString(PROM3 / 2);
                B24.Text = Convert.ToString(PROM4 / 2);
                B25.Text = Convert.ToString(PROM5 / 2);
                B26.Text = Convert.ToString(PROM6 / 2);
                B27.Text = Convert.ToString(PROM7 / 2);
                B28.Text = Convert.ToString(PROM8 / 2);
            }

        }

        private void TE1_TextChanged(object sender, EventArgs e)
        {
            if (TE1.Text == "" ||
                    TE2.Text == "" ||
                    TE3.Text == "" ||
                    TE4.Text == "" ||
                    TE5.Text == "" ||
                    TE6.Text == "" ||
                    TE7.Text == "" ||
                    TE8.Text == "")
            {

            }
            else
            {
                double total = double.Parse(TE1.Text) + double.Parse(TE2.Text) + double.Parse(TE3.Text) + double.Parse(TE4.Text) + double.Parse(TE5.Text) + double.Parse(TE6.Text) + double.Parse(TE7.Text) + double.Parse(TE8.Text);
                TE9.Text = Convert.ToString(total / 8);
            }

        }

        private void TF1_TextChanged(object sender, EventArgs e)
        {
            if (TF1.Text == "" ||
                    TF2.Text == "" ||
                    TF3.Text == "" ||
                    TF4.Text == "" ||
                    TF5.Text == "" ||
                    TF6.Text == "" ||
                    TF7.Text == "" ||
                    TF8.Text == "")
            {

            }
            else
            {
                double total = double.Parse(TF1.Text) + double.Parse(TF2.Text) + double.Parse(TF3.Text) + double.Parse(TF4.Text) + double.Parse(TF5.Text) + double.Parse(TF6.Text) + double.Parse(TF7.Text) + double.Parse(TF8.Text);
                TF9.Text = Convert.ToString(total / 8);

                double PROM1 = double.Parse(TE1.Text) + double.Parse(TF1.Text);
                double PROM2 = double.Parse(TE2.Text) + double.Parse(TF2.Text);
                double PROM3 = double.Parse(TE3.Text) + double.Parse(TF3.Text);
                double PROM4 = double.Parse(TE4.Text) + double.Parse(TF4.Text);
                double PROM5 = double.Parse(TE5.Text) + double.Parse(TF5.Text);
                double PROM6 = double.Parse(TE6.Text) + double.Parse(TF6.Text);
                double PROM7 = double.Parse(TE7.Text) + double.Parse(TF7.Text);
                double PROM8 = double.Parse(TE8.Text) + double.Parse(TF8.Text);

                B31.Text = Convert.ToString(PROM1 / 2);
                B32.Text = Convert.ToString(PROM2 / 2);
                B33.Text = Convert.ToString(PROM3 / 2);
                B34.Text = Convert.ToString(PROM4 / 2);
                B35.Text = Convert.ToString(PROM5 / 2);
                B36.Text = Convert.ToString(PROM6 / 2);
                B37.Text = Convert.ToString(PROM7 / 2);
                B38.Text = Convert.ToString(PROM8 / 2);
            }

        }

        private void TM1_TextChanged(object sender, EventArgs e)
        {
            if (TM1.Text == "" ||
                    TM2.Text == "" ||
                    TM3.Text == "" ||
                    TM4.Text == "" ||
                    TM5.Text == "" ||
                    TM6.Text == "" ||
                    TM7.Text == "" ||
                    TM8.Text == "")
            {

            }
            else
            {
                double total = double.Parse(TM1.Text) + double.Parse(TM2.Text) + double.Parse(TM3.Text) + double.Parse(TM4.Text) + double.Parse(TM5.Text) + double.Parse(TM6.Text) + double.Parse(TM7.Text) + double.Parse(TM8.Text);
                TM9.Text = Convert.ToString(total / 8);
            }
        }

        private void TA1_TextChanged(object sender, EventArgs e)
        {
            if (TA1.Text == "" ||
                    TA2.Text == "" ||
                    TA3.Text == "" ||
                    TA4.Text == "" ||
                    TA5.Text == "" ||
                    TA6.Text == "" ||
                    TA7.Text == "" ||
                    TA8.Text == "")
            {

            }
            else
            {
                double total = double.Parse(TA1.Text) + double.Parse(TA2.Text) + double.Parse(TA3.Text) + double.Parse(TA4.Text) + double.Parse(TA5.Text) + double.Parse(TA6.Text) + double.Parse(TA7.Text) + double.Parse(TA8.Text);
                TA9.Text = Convert.ToString(total / 8);

                double PROM1 = double.Parse(TM1.Text) + double.Parse(TA1.Text);
                double PROM2 = double.Parse(TM2.Text) + double.Parse(TA2.Text);
                double PROM3 = double.Parse(TM3.Text) + double.Parse(TA3.Text);
                double PROM4 = double.Parse(TM4.Text) + double.Parse(TA4.Text);
                double PROM5 = double.Parse(TM5.Text) + double.Parse(TA5.Text);
                double PROM6 = double.Parse(TM6.Text) + double.Parse(TA6.Text);
                double PROM7 = double.Parse(TM7.Text) + double.Parse(TA7.Text);
                double PROM8 = double.Parse(TM8.Text) + double.Parse(TA8.Text);

                B41.Text = Convert.ToString(PROM1 / 2);
                B42.Text = Convert.ToString(PROM2 / 2);
                B43.Text = Convert.ToString(PROM3 / 2);
                B44.Text = Convert.ToString(PROM4 / 2);
                B45.Text = Convert.ToString(PROM5 / 2);
                B46.Text = Convert.ToString(PROM6 / 2);
                B47.Text = Convert.ToString(PROM7 / 2);
                B48.Text = Convert.ToString(PROM8 / 2);
            }
        }

        private void TMA1_TextChanged(object sender, EventArgs e)
        {
            if (TMA1.Text == "" ||
                    TMA2.Text == "" ||
                    TMA3.Text == "" ||
                    TMA4.Text == "" ||
                    TMA5.Text == "" ||
                    TMA6.Text == "" ||
                    TMA7.Text == "" ||
                    TMA8.Text == "")
            {

            }
            else
            {
                double total = double.Parse(TMA1.Text) + double.Parse(TMA2.Text) + double.Parse(TMA3.Text) + double.Parse(TMA4.Text) + double.Parse(TMA5.Text) + double.Parse(TMA6.Text) + double.Parse(TMA7.Text) + double.Parse(TMA8.Text);
                TMA9.Text = Convert.ToString(total / 8);
            }
        }

        private void TJ1_TextChanged(object sender, EventArgs e)
        {
            if (TJ1.Text == "" ||
                   TJ2.Text == "" ||
                   TJ3.Text == "" ||
                   TJ4.Text == "" ||
                   TJ5.Text == "" ||
                   TJ6.Text == "" ||
                   TJ7.Text == "" ||
                   TJ8.Text == "")
            {

            }
            else
            {
                double total = double.Parse(TJ1.Text) + double.Parse(TJ2.Text) + double.Parse(TJ3.Text) + double.Parse(TJ4.Text) + double.Parse(TJ5.Text) + double.Parse(TJ6.Text) + double.Parse(TJ7.Text) + double.Parse(TJ8.Text);
                TJ9.Text = Convert.ToString(total / 8);

                double PROM1 = double.Parse(TMA1.Text) + double.Parse(TJ1.Text);
                double PROM2 = double.Parse(TMA2.Text) + double.Parse(TJ2.Text);
                double PROM3 = double.Parse(TMA3.Text) + double.Parse(TJ3.Text);
                double PROM4 = double.Parse(TMA4.Text) + double.Parse(TJ4.Text);
                double PROM5 = double.Parse(TMA5.Text) + double.Parse(TJ5.Text);
                double PROM6 = double.Parse(TMA6.Text) + double.Parse(TJ6.Text);
                double PROM7 = double.Parse(TMA7.Text) + double.Parse(TJ7.Text);
                double PROM8 = double.Parse(TMA8.Text) + double.Parse(TJ8.Text);

                B51.Text = Convert.ToString(PROM1 / 2);
                B52.Text = Convert.ToString(PROM2 / 2);
                B53.Text = Convert.ToString(PROM3 / 2);
                B54.Text = Convert.ToString(PROM4 / 2);
                B55.Text = Convert.ToString(PROM5 / 2);
                B56.Text = Convert.ToString(PROM6 / 2);
                B57.Text = Convert.ToString(PROM7 / 2);
                B58.Text = Convert.ToString(PROM8 / 2);
            }
        }

        private void TDD10_TextChanged(object sender, EventArgs e)
        {

            if (TDD10.Text == "" ||
                    TDD11.Text == "" ||
                    TDD12.Text == "" ||
                    TDD13.Text == "" ||
                    TDD14.Text == "" ||
                    TDD15.Text == "" ||
                    TDD16.Text == "" ||
                    TDD17.Text == "" ||
                    TDD18.Text == "" ||
                    txt13.Text == "" ||
                    txt14.Text == "" ||
                    txt15.Text == "")
            {

            }
            else
            {
                double total = double.Parse(TDD10.Text) + double.Parse(TDD11.Text) + double.Parse(TDD12.Text) + double.Parse(TDD13.Text) + double.Parse(TDD14.Text) + double.Parse(TDD15.Text) + double.Parse(TDD16.Text) + double.Parse(TDD17.Text) + double.Parse(TDD18.Text) + double.Parse(txt13.Text) + double.Parse(txt14.Text) + double.Parse(txt15.Text);
                TDD19.Text = Convert.ToString(total / 12);

                double PROM1 = double.Parse(TN10.Text) + double.Parse(TDD10.Text);
                double PROM2 = double.Parse(TN11.Text) + double.Parse(TDD11.Text);
                double PROM3 = double.Parse(TN12.Text) + double.Parse(TDD12.Text);
                double PROM4 = double.Parse(TN13.Text) + double.Parse(TDD13.Text);
                double PROM5 = double.Parse(TN14.Text) + double.Parse(TDD14.Text);
                double PROM6 = double.Parse(TN15.Text) + double.Parse(TDD15.Text);
                double PROM7 = double.Parse(TN16.Text) + double.Parse(TDD16.Text);
                double PROM8 = double.Parse(TN17.Text) + double.Parse(TDD17.Text);
                double PROM9 = double.Parse(TN18.Text) + double.Parse(TDD18.Text);
                double PROM10 = double.Parse(txt7.Text) + double.Parse(txt10.Text);
                double PROM11 = double.Parse(txt8.Text) + double.Parse(txt11.Text);
                double PROM12 = double.Parse(txt9.Text) + double.Parse(txt12.Text);

                B210.Text = Convert.ToString(PROM1 / 2);
                B211.Text = Convert.ToString(PROM2 / 2);
                B212.Text = Convert.ToString(PROM3 / 2);
                B213.Text = Convert.ToString(PROM4 / 2);
                B214.Text = Convert.ToString(PROM5 / 2);
                B215.Text = Convert.ToString(PROM6 / 2);
                B216.Text = Convert.ToString(PROM7 / 2);
                B217.Text = Convert.ToString(PROM8 / 2);
                B218.Text = Convert.ToString(PROM9 / 2);
                textBox13.Text = Convert.ToString(PROM10 / 2);
                textBox14.Text = Convert.ToString(PROM11 / 2);
                textBox15.Text = Convert.ToString(PROM12 / 2);

                if (TDD9.Text == "" || TDD19.Text == "")
                {

                }
                else
                {
                    double promedio = double.Parse(TDD9.Text) + double.Parse(TDD19.Text); ;
                    TDD20.Text = Convert.ToString(promedio / 2);
                }

                if (TDD1.Text == "" ||
                    TDD2.Text == "" ||
                    TDD3.Text == "" ||
                    TDD4.Text == "" ||
                    TDD5.Text == "" ||
                    TDD6.Text == "" ||
                    TDD7.Text == "" ||
                    TDD8.Text == "" ||
                    TDD10.Text == "" ||
                    TDD11.Text == "" ||
                    TDD12.Text == "" ||
                    TDD13.Text == "" ||
                    TDD14.Text == "" ||
                    TDD15.Text == "" ||
                    TDD16.Text == "" ||
                    TDD17.Text == "" ||
                    TDD18.Text == "" ||
                    txt13.Text == "" ||
                    txt14.Text == "" ||
                    txt15.Text == "")
                {

                }
                else
                {
                    double puntos = double.Parse(TDD1.Text) + double.Parse(TDD2.Text) + double.Parse(TDD3.Text) + double.Parse(TDD4.Text) + double.Parse(TDD5.Text) + double.Parse(TDD6.Text) + double.Parse(TDD7.Text) + double.Parse(TDD8.Text) +
                         double.Parse(TDD10.Text) + double.Parse(TDD11.Text) + double.Parse(TDD12.Text) + double.Parse(TDD13.Text) + double.Parse(TDD14.Text) + double.Parse(TDD15.Text) + double.Parse(TDD16.Text) + double.Parse(TDD17.Text) + double.Parse(TDD18.Text) + double.Parse(txt13.Text) + double.Parse(txt14.Text) + double.Parse(txt15.Text);
                    TDD21.Text = Convert.ToString(puntos);

                    double tolpuntos = double.Parse(TN21.Text) + double.Parse(TDD21.Text);
                    B221.Text = Convert.ToString(tolpuntos);

                    double propuntos = double.Parse(B121.Text) + double.Parse(B221.Text);
                    P21.Text = Convert.ToString(propuntos);
                }
                if (TN20.Text == "" || TDD20.Text == "")
                {

                }
                else
                {
                    double promedio = double.Parse(TN20.Text) + double.Parse(TDD20.Text); ;
                    B220.Text = Convert.ToString(promedio / 2);
                }
            }
        }

        private void TE10_TextChanged(object sender, EventArgs e)
        {
            if (TE10.Text == "" ||
                    TE11.Text == "" ||
                    TE12.Text == "" ||
                    TE13.Text == "" ||
                    TE14.Text == "" ||
                    TE15.Text == "" ||
                    TE16.Text == "" ||
                    TE17.Text == "" ||
                    TE18.Text == "" ||
                    txt16.Text == "" ||
                    txt17.Text == "" ||
                    txt18.Text == "")
            {

            }
            else
            {
                double total = double.Parse(TE10.Text) + double.Parse(TE11.Text) + double.Parse(TE12.Text) + double.Parse(TE13.Text) + double.Parse(TE14.Text) + double.Parse(TE15.Text) + double.Parse(TE16.Text) + double.Parse(TE17.Text) + double.Parse(TE18.Text) + double.Parse(txt16.Text) + double.Parse(txt17.Text) + double.Parse(txt18.Text);
                TE19.Text = Convert.ToString(total / 12);

                if (TE9.Text == "" || TE19.Text == "")
                {

                }
                else
                {
                    double promedio = double.Parse(TE9.Text) + double.Parse(TE19.Text);
                    TE20.Text = Convert.ToString(promedio / 2);
                }

                if (TE1.Text == "" ||
                    TE2.Text == "" ||
                    TE3.Text == "" ||
                    TE4.Text == "" ||
                    TE5.Text == "" ||
                    TE6.Text == "" ||
                    TE7.Text == "" ||
                    TE8.Text == "" ||
                    TE10.Text == "" ||
                    TE11.Text == "" ||
                    TE12.Text == "" ||
                    TE13.Text == "" ||
                    TE14.Text == "" ||
                    TE15.Text == "" ||
                    TE16.Text == "" ||
                    TE17.Text == "" ||
                    TE18.Text == "" ||
                    txt16.Text == "" ||
                    txt17.Text == "" ||
                    txt18.Text == "")
                {

                }
                else
                {
                    double puntos = double.Parse(TE1.Text) + double.Parse(TE2.Text) + double.Parse(TE3.Text) + double.Parse(TE4.Text) + double.Parse(TE5.Text) + double.Parse(TE6.Text) + double.Parse(TE7.Text) + double.Parse(TE8.Text) +
                       double.Parse(TE10.Text) + double.Parse(TE11.Text) + double.Parse(TE12.Text) + double.Parse(TE13.Text) + double.Parse(TE14.Text) + double.Parse(TE15.Text) + double.Parse(TE16.Text) + double.Parse(TE17.Text) + double.Parse(TE18.Text) + double.Parse(txt16.Text) + double.Parse(txt17.Text) + double.Parse(txt18.Text);
                    TE21.Text = Convert.ToString(puntos);
                }
            }
        }

        private void TF10_TextChanged_1(object sender, EventArgs e)
        {
            if (TF10.Text == "" ||
                    TF11.Text == "" ||
                    TF12.Text == "" ||
                    TF13.Text == "" ||
                    TF14.Text == "" ||
                    TF15.Text == "" ||
                    TF16.Text == "" ||
                    TF17.Text == "" ||
                    TF18.Text == "" ||
                    textBox31.Text == "" ||
                    textBox32.Text == "" ||
                    textBox33.Text == "")
            {

            }
            else
            {
                double total = double.Parse(TF10.Text) + double.Parse(TF11.Text) + double.Parse(TF12.Text) + double.Parse(TF13.Text) + double.Parse(TF14.Text) + double.Parse(TF15.Text) + double.Parse(TF16.Text) + double.Parse(TF17.Text) + double.Parse(TF18.Text) + double.Parse(textBox31.Text) + double.Parse(textBox32.Text) + double.Parse(textBox33.Text);
                TF19.Text = Convert.ToString(total / 12);

                double PROM1 = double.Parse(TN10.Text) + double.Parse(TF10.Text);
                double PROM2 = double.Parse(TN11.Text) + double.Parse(TF11.Text);
                double PROM3 = double.Parse(TN12.Text) + double.Parse(TF12.Text);
                double PROM4 = double.Parse(TN13.Text) + double.Parse(TF13.Text);
                double PROM5 = double.Parse(TN14.Text) + double.Parse(TF14.Text);
                double PROM6 = double.Parse(TN15.Text) + double.Parse(TF15.Text);
                double PROM7 = double.Parse(TN16.Text) + double.Parse(TF16.Text);
                double PROM8 = double.Parse(TN17.Text) + double.Parse(TF17.Text);
                double PROM9 = double.Parse(TN18.Text) + double.Parse(TF18.Text);
                double PROM10 = double.Parse(txt16.Text) + double.Parse(textBox31.Text);
                double PROM11 = double.Parse(txt17.Text) + double.Parse(textBox32.Text);
                double PROM12 = double.Parse(txt18.Text) + double.Parse(textBox33.Text);

                B310.Text = Convert.ToString(PROM1 / 2);
                B311.Text = Convert.ToString(PROM2 / 2);
                B312.Text = Convert.ToString(PROM3 / 2);
                B313.Text = Convert.ToString(PROM4 / 2);
                B314.Text = Convert.ToString(PROM5 / 2);
                B315.Text = Convert.ToString(PROM6 / 2);
                B316.Text = Convert.ToString(PROM7 / 2);
                B317.Text = Convert.ToString(PROM8 / 2);
                B318.Text = Convert.ToString(PROM9 / 2);
                textBox10.Text = Convert.ToString(PROM10 / 2);
                textBox11.Text = Convert.ToString(PROM11 / 2);
                textBox12.Text = Convert.ToString(PROM12 / 2);

                if (TF9.Text == "" || TF19.Text == "")
                {

                }
                else
                {
                    double promedio = double.Parse(TF9.Text) + double.Parse(TF19.Text);
                    TF20.Text = Convert.ToString(promedio / 2);
                }

                if (TF1.Text == "" ||
                    TF2.Text == "" ||
                    TF3.Text == "" ||
                    TF4.Text == "" ||
                    TF5.Text == "" ||
                    TF6.Text == "" ||
                    TF7.Text == "" ||
                    TF8.Text == "" ||
                    TF10.Text == "" ||
                    TF11.Text == "" ||
                    TF12.Text == "" ||
                    TF13.Text == "" ||
                    TF14.Text == "" ||
                    TF15.Text == "" ||
                    TF16.Text == "" ||
                    TF17.Text == "" ||
                    TF18.Text == "" ||
                    textBox31.Text == "" ||
                    textBox32.Text == "" ||
                    textBox33.Text == "")
                {

                }
                else
                {
                    double puntos = double.Parse(TF1.Text) + double.Parse(TF2.Text) + double.Parse(TF3.Text) + double.Parse(TF4.Text) + double.Parse(TF5.Text) + double.Parse(TF6.Text) + double.Parse(TF7.Text) + double.Parse(TF8.Text) +
                         double.Parse(TF10.Text) + double.Parse(TF11.Text) + double.Parse(TF12.Text) + double.Parse(TF13.Text) + double.Parse(TF14.Text) + double.Parse(TF15.Text) + double.Parse(TF16.Text) + double.Parse(TF17.Text) + double.Parse(TF18.Text) + double.Parse(textBox31.Text) + double.Parse(textBox32.Text) + double.Parse(textBox33.Text);
                    TF21.Text = Convert.ToString(puntos);

                    double tolpuntos = double.Parse(TE21.Text) + double.Parse(TF21.Text);
                    B321.Text = Convert.ToString(tolpuntos);

                    double propuntos = double.Parse(B121.Text) + double.Parse(B221.Text) + double.Parse(B321.Text);
                    P21.Text = Convert.ToString(propuntos);
                }
                if (TE20.Text == "" || TF20.Text == "")
                {

                }
                else
                {
                    double promedio = double.Parse(TE20.Text) + double.Parse(TF20.Text); ;
                    B320.Text = Convert.ToString(promedio / 2);

                    double general = double.Parse(B120.Text) + double.Parse(B220.Text) + double.Parse(B320.Text);
                    P20.Text = Convert.ToString(general / 3);
                }
            }
        }

        private void TM10_TextChanged(object sender, EventArgs e)
        {
            if (TM10.Text == "" ||
                    TM11.Text == "" ||
                    TM12.Text == "" ||
                    TM13.Text == "" ||
                    TM14.Text == "" ||
                    TM15.Text == "" ||
                    TM16.Text == "" ||
                    TM17.Text == "" ||
                    TM18.Text == "" ||
                    textBox28.Text == "" ||
                    textBox29.Text == "" ||
                    textBox30.Text == "")
            {

            }
            else
            {
                double total = double.Parse(TM10.Text) + double.Parse(TM11.Text) + double.Parse(TM12.Text) + double.Parse(TM13.Text) + double.Parse(TM14.Text) + double.Parse(TM15.Text) + double.Parse(TM16.Text) + double.Parse(TM17.Text) + double.Parse(TM18.Text) + double.Parse(textBox28.Text) + double.Parse(textBox29.Text) + double.Parse(textBox30.Text);
                TM19.Text = Convert.ToString(total / 12);

                if (TM9.Text == "" || TM19.Text == "")
                {

                }
                else
                {
                    double promedio = double.Parse(TM9.Text) + double.Parse(TM19.Text); ;
                    TM20.Text = Convert.ToString(promedio / 2);
                }
                if (TM1.Text == "" ||
                    TM2.Text == "" ||
                    TM3.Text == "" ||
                    TM4.Text == "" ||
                    TM5.Text == "" ||
                    TM6.Text == "" ||
                    TM7.Text == "" ||
                    TM8.Text == "" ||
                    TM10.Text == "" ||
                    TM11.Text == "" ||
                    TM12.Text == "" ||
                    TM13.Text == "" ||
                    TM14.Text == "" ||
                    TM15.Text == "" ||
                    TM16.Text == "" ||
                    TM17.Text == "" ||
                    TM18.Text == "" ||
                    textBox28.Text == "" ||
                    textBox29.Text == "" ||
                    textBox30.Text == "")
                {

                }
                else
                {
                    double puntos = double.Parse(TM1.Text) + double.Parse(TM2.Text) + double.Parse(TM3.Text) + double.Parse(TM4.Text) + double.Parse(TM5.Text) + double.Parse(TM6.Text) + double.Parse(TM7.Text) + double.Parse(TM8.Text) +
                        double.Parse(TM10.Text) + double.Parse(TM11.Text) + double.Parse(TM12.Text) + double.Parse(TM13.Text) + double.Parse(TM14.Text) + double.Parse(TM15.Text) + double.Parse(TM16.Text) + double.Parse(TM17.Text) + double.Parse(TM18.Text) + double.Parse(textBox28.Text) + double.Parse(textBox29.Text) + double.Parse(textBox30.Text);
                    TM21.Text = Convert.ToString(puntos);
                }
            }
        }

        private void TA10_TextChanged(object sender, EventArgs e)
        {
            if (TA10.Text == "" ||
                    TA11.Text == "" ||
                    TA12.Text == "" ||
                    TA13.Text == "" ||
                    TA14.Text == "" ||
                    TA15.Text == "" ||
                    TA16.Text == "" ||
                    TA17.Text == "" ||
                    TA18.Text == "" ||
                    textBox25.Text == "" ||
                    textBox26.Text == "" ||
                    textBox27.Text == "")
            {

            }
            else
            {
                double total = double.Parse(TA10.Text) + double.Parse(TA11.Text) + double.Parse(TA12.Text) + double.Parse(TA13.Text) + double.Parse(TA14.Text) + double.Parse(TA15.Text) + double.Parse(TA16.Text) + double.Parse(TA17.Text) + double.Parse(TA18.Text) + double.Parse(textBox25.Text) + double.Parse(textBox26.Text) + double.Parse(textBox27.Text);
                TA19.Text = Convert.ToString(total / 12);

                double PROM1 = double.Parse(TM10.Text) + double.Parse(TA10.Text);
                double PROM2 = double.Parse(TM11.Text) + double.Parse(TA11.Text);
                double PROM3 = double.Parse(TM12.Text) + double.Parse(TA12.Text);
                double PROM4 = double.Parse(TM13.Text) + double.Parse(TA13.Text);
                double PROM5 = double.Parse(TM14.Text) + double.Parse(TA14.Text);
                double PROM6 = double.Parse(TM15.Text) + double.Parse(TA15.Text);
                double PROM7 = double.Parse(TM16.Text) + double.Parse(TA16.Text);
                double PROM8 = double.Parse(TM17.Text) + double.Parse(TA17.Text);
                double PROM9 = double.Parse(TM18.Text) + double.Parse(TA18.Text);
                double PROM10 = double.Parse(textBox28.Text) + double.Parse(textBox25.Text);
                double PROM11 = double.Parse(textBox29.Text) + double.Parse(textBox26.Text);
                double PROM12 = double.Parse(textBox30.Text) + double.Parse(textBox27.Text);

                B410.Text = Convert.ToString(PROM1 / 2);
                B411.Text = Convert.ToString(PROM2 / 2);
                B412.Text = Convert.ToString(PROM3 / 2);
                B413.Text = Convert.ToString(PROM4 / 2);
                B414.Text = Convert.ToString(PROM5 / 2);
                B415.Text = Convert.ToString(PROM6 / 2);
                B416.Text = Convert.ToString(PROM7 / 2);
                B417.Text = Convert.ToString(PROM8 / 2);
                B418.Text = Convert.ToString(PROM9 / 2);
                textBox7.Text = Convert.ToString(PROM10 / 2);
                textBox8.Text = Convert.ToString(PROM11 / 2);
                textBox9.Text = Convert.ToString(PROM12 / 2);

                if (TA9.Text == "" || TA19.Text == "")
                {

                }
                else
                {
                    double promedio = double.Parse(TA9.Text) + double.Parse(TA19.Text); ;
                    TA20.Text = Convert.ToString(promedio / 2);
                }
                if (TA1.Text == "" ||
                    TA2.Text == "" ||
                    TA3.Text == "" ||
                    TA4.Text == "" ||
                    TA5.Text == "" ||
                    TA6.Text == "" ||
                    TA7.Text == "" ||
                    TA8.Text == "" ||
                    TA10.Text == "" ||
                    TA11.Text == "" ||
                    TA12.Text == "" ||
                    TA13.Text == "" ||
                    TA14.Text == "" ||
                    TA15.Text == "" ||
                    TA16.Text == "" ||
                    TA17.Text == "" ||
                    TA18.Text == "" ||
                    textBox25.Text == "" ||
                    textBox26.Text == "" ||
                    textBox27.Text == "")
                {

                }
                else
                {
                    double puntos = double.Parse(TA1.Text) + double.Parse(TA2.Text) + double.Parse(TA3.Text) + double.Parse(TA4.Text) + double.Parse(TA5.Text) + double.Parse(TA6.Text) + double.Parse(TA7.Text) + double.Parse(TA8.Text) +
                        double.Parse(TA10.Text) + double.Parse(TA11.Text) + double.Parse(TA12.Text) + double.Parse(TA13.Text) + double.Parse(TA14.Text) + double.Parse(TA15.Text) + double.Parse(TA16.Text) + double.Parse(TA17.Text) + double.Parse(TA18.Text) + double.Parse(textBox25.Text) + double.Parse(textBox26.Text) + double.Parse(textBox27.Text);
                    TA21.Text = Convert.ToString(puntos);

                    double tolpuntos = double.Parse(TM21.Text) + double.Parse(TA21.Text);
                    B421.Text = Convert.ToString(tolpuntos);

                    double propuntos = double.Parse(B121.Text) + double.Parse(B221.Text) + double.Parse(B321.Text) + double.Parse(B421.Text);
                    P21.Text = Convert.ToString(propuntos);


                }
                if (TM20.Text == "" || TA20.Text == "")
                {

                }
                else
                {
                    double promedio = double.Parse(TM20.Text) + double.Parse(TA20.Text); ;
                    B420.Text = Convert.ToString(promedio / 2);

                    double general = double.Parse(B120.Text) + double.Parse(B220.Text) + double.Parse(B320.Text) + double.Parse(B420.Text);
                    P20.Text = Convert.ToString(general / 4);
                }
            }
        }

        private void TMA10_TextChanged(object sender, EventArgs e)
        {
            if (TMA10.Text == "" ||
                    TMA11.Text == "" ||
                    TMA12.Text == "" ||
                    TMA13.Text == "" ||
                    TMA14.Text == "" ||
                    TMA15.Text == "" ||
                    TMA16.Text == "" ||
                    TMA17.Text == "" ||
                    TMA18.Text == "" ||
                    textBox22.Text == "" ||
                    textBox23.Text == "" ||
                    textBox24.Text == "")
            {

            }
            else
            {
                double total = double.Parse(TMA10.Text) + double.Parse(TMA11.Text) + double.Parse(TMA12.Text) + double.Parse(TMA13.Text) + double.Parse(TMA14.Text) + double.Parse(TMA15.Text) + double.Parse(TMA16.Text) + double.Parse(TMA17.Text) + double.Parse(TMA18.Text) + double.Parse(textBox22.Text) + double.Parse(textBox23.Text) + double.Parse(textBox24.Text);
                TMA19.Text = Convert.ToString(total / 12);

                if (TMA9.Text == "" || TMA19.Text == "")
                {

                }
                else
                {
                    double promedio = double.Parse(TMA9.Text) + double.Parse(TMA19.Text); ;
                    TMA20.Text = Convert.ToString(promedio / 2);
                }
                if (TMA1.Text == "" ||
                    TMA2.Text == "" ||
                    TMA3.Text == "" ||
                    TMA4.Text == "" ||
                    TMA5.Text == "" ||
                    TMA6.Text == "" ||
                    TMA7.Text == "" ||
                    TMA8.Text == "" ||
                    TMA10.Text == "" ||
                    TMA11.Text == "" ||
                    TMA12.Text == "" ||
                    TMA13.Text == "" ||
                    TMA14.Text == "" ||
                    TMA15.Text == "" ||
                    TMA16.Text == "" ||
                    TMA17.Text == "" ||
                    TMA18.Text == "" ||
                    textBox22.Text == "" ||
                    textBox23.Text == "" ||
                    textBox24.Text == "")
                {

                }
                else
                {
                    double puntos = double.Parse(TMA1.Text) + double.Parse(TMA2.Text) + double.Parse(TMA3.Text) + double.Parse(TMA4.Text) + double.Parse(TMA5.Text) + double.Parse(TMA6.Text) + double.Parse(TMA7.Text) + double.Parse(TMA8.Text) +
                        double.Parse(TMA10.Text) + double.Parse(TMA11.Text) + double.Parse(TMA12.Text) + double.Parse(TMA13.Text) + double.Parse(TMA14.Text) + double.Parse(TMA15.Text) + double.Parse(TMA16.Text) + double.Parse(TMA17.Text) + double.Parse(TMA18.Text) + double.Parse(textBox22.Text) + double.Parse(textBox23.Text) + double.Parse(textBox24.Text);
                    TMA21.Text = Convert.ToString(puntos);
                }
            }
        }

        private void TJ10_TextChanged(object sender, EventArgs e)
        {
            if (TJ10.Text == "" ||
                    TJ11.Text == "" ||
                    TJ12.Text == "" ||
                    TJ13.Text == "" ||
                    TJ14.Text == "" ||
                    TJ15.Text == "" ||
                    TJ16.Text == "" ||
                    TJ17.Text == "" ||
                    TJ18.Text == "" ||
                    textBox19.Text == "" ||
                    textBox20.Text == "" ||
                    textBox21.Text == "")
            {

            }
            else
            {
                double total = double.Parse(TJ10.Text) + double.Parse(TJ11.Text) + double.Parse(TJ12.Text) + double.Parse(TJ13.Text) + double.Parse(TJ14.Text) + double.Parse(TJ15.Text) + double.Parse(TJ16.Text) + double.Parse(TJ17.Text) + double.Parse(TJ18.Text) + double.Parse(textBox19.Text) + double.Parse(textBox20.Text) + double.Parse(textBox21.Text);
                TJ19.Text = Convert.ToString(total / 12);

                double PROM1 = double.Parse(TMA10.Text) + double.Parse(TJ10.Text);
                double PROM2 = double.Parse(TMA11.Text) + double.Parse(TJ11.Text);
                double PROM3 = double.Parse(TMA12.Text) + double.Parse(TJ12.Text);
                double PROM4 = double.Parse(TMA13.Text) + double.Parse(TJ13.Text);
                double PROM5 = double.Parse(TMA14.Text) + double.Parse(TJ14.Text);
                double PROM6 = double.Parse(TMA15.Text) + double.Parse(TJ15.Text);
                double PROM7 = double.Parse(TMA16.Text) + double.Parse(TJ16.Text);
                double PROM8 = double.Parse(TMA17.Text) + double.Parse(TJ17.Text);
                double PROM9 = double.Parse(TMA18.Text) + double.Parse(TJ18.Text);
                double PROM10 = double.Parse(textBox22.Text) + double.Parse(textBox19.Text);
                double PROM11 = double.Parse(textBox23.Text) + double.Parse(textBox20.Text);
                double PROM12 = double.Parse(textBox24.Text) + double.Parse(textBox21.Text);

                B510.Text = Convert.ToString(PROM1 / 2);
                B511.Text = Convert.ToString(PROM2 / 2);
                B512.Text = Convert.ToString(PROM3 / 2);
                B513.Text = Convert.ToString(PROM4 / 2);
                B514.Text = Convert.ToString(PROM5 / 2);
                B515.Text = Convert.ToString(PROM6 / 2);
                B516.Text = Convert.ToString(PROM7 / 2);
                B517.Text = Convert.ToString(PROM8 / 2);
                B518.Text = Convert.ToString(PROM9 / 2);
                textBox4.Text = Convert.ToString(PROM10 / 2);
                textBox5.Text = Convert.ToString(PROM11 / 2);
                textBox6.Text = Convert.ToString(PROM12 / 2);

                if (TJ9.Text == "" || TJ19.Text == "")
                {

                }
                else
                {
                    double promedio = double.Parse(TJ9.Text) + double.Parse(TJ19.Text); ;
                    TJ20.Text = Convert.ToString(promedio / 2);
                }
                if (TJ1.Text == "" ||
                    TJ2.Text == "" ||
                    TJ3.Text == "" ||
                    TJ4.Text == "" ||
                    TJ5.Text == "" ||
                    TJ6.Text == "" ||
                    TJ7.Text == "" ||
                    TJ8.Text == "" ||
                    TJ10.Text == "" ||
                    TJ11.Text == "" ||
                    TJ12.Text == "" ||
                    TJ13.Text == "" ||
                    TJ14.Text == "" ||
                    TJ15.Text == "" ||
                    TJ16.Text == "" ||
                    TJ17.Text == "" ||
                    TJ18.Text == "" ||
                    textBox19.Text == "" ||
                    textBox20.Text == "" ||
                    textBox21.Text == "")
                {

                }
                else
                {
                    double puntos = double.Parse(TJ1.Text) + double.Parse(TJ2.Text) + double.Parse(TJ3.Text) + double.Parse(TJ4.Text) + double.Parse(TJ5.Text) + double.Parse(TJ6.Text) + double.Parse(TJ7.Text) + double.Parse(TJ8.Text) +
                        double.Parse(TJ10.Text) + double.Parse(TJ11.Text) + double.Parse(TJ12.Text) + double.Parse(TJ13.Text) + double.Parse(TJ14.Text) + double.Parse(TJ15.Text) + double.Parse(TJ16.Text) + double.Parse(TJ17.Text) + double.Parse(TJ18.Text) + double.Parse(textBox19.Text) + double.Parse(textBox20.Text) + double.Parse(textBox21.Text);
                    TJ21.Text = Convert.ToString(puntos);

                    double tolpuntos = double.Parse(TMA21.Text) + double.Parse(TJ21.Text);
                    B521.Text = Convert.ToString(tolpuntos);

                    double propuntos = double.Parse(B121.Text) + double.Parse(B221.Text) + double.Parse(B321.Text) + double.Parse(B421.Text) + double.Parse(B521.Text);
                    P21.Text = Convert.ToString(propuntos);
                }

                if (TMA20.Text == "" || TJ20.Text == "")
                {

                }
                else
                {
                    double promedio = double.Parse(TMA20.Text) + double.Parse(TJ20.Text); ;
                    B520.Text = Convert.ToString(promedio / 2);

                    double general = double.Parse(B120.Text) + double.Parse(B220.Text) + double.Parse(B320.Text) + double.Parse(B420.Text) + double.Parse(B420.Text);
                    P20.Text = Convert.ToString(general / 5);
                }
            }
        }

        private void B11_TextChanged(object sender, EventArgs e)
        {
            if (B11.Text == "" ||
                    B12.Text == "" ||
                    B13.Text == "" ||
                    B14.Text == "" ||
                    B15.Text == "" ||
                    B16.Text == "" ||
                    B17.Text == "" ||
                    B18.Text == "")
            {

            }
            else
            {
                double total = double.Parse(B11.Text) + double.Parse(B12.Text) + double.Parse(B13.Text) + double.Parse(B14.Text) + double.Parse(B15.Text) + double.Parse(B16.Text) + double.Parse(B17.Text) + double.Parse(B18.Text);
                B19.Text = Convert.ToString((total / 8));

                double PROM1 = double.Parse(B11.Text);
                double PROM2 = double.Parse(B12.Text);
                double PROM3 = double.Parse(B13.Text);
                double PROM4 = double.Parse(B14.Text);
                double PROM5 = double.Parse(B15.Text);
                double PROM6 = double.Parse(B16.Text);
                double PROM7 = double.Parse(B17.Text);
                double PROM8 = double.Parse(B18.Text);

                P1.Text = Convert.ToString(PROM1);
                P2.Text = Convert.ToString(PROM2);
                P3.Text = Convert.ToString(PROM3);
                P4.Text = Convert.ToString(PROM4);
                P5.Text = Convert.ToString(PROM5);
                P6.Text = Convert.ToString(PROM6);
                P7.Text = Convert.ToString(PROM7);
                P8.Text = Convert.ToString(PROM8);
            }
        }

        private void B21_TextChanged(object sender, EventArgs e)
        {

            if (B21.Text == "" ||
                    B22.Text == "" ||
                    B23.Text == "" ||
                    B24.Text == "" ||
                    B25.Text == "" ||
                    B26.Text == "" ||
                    B27.Text == "" ||
                    B28.Text == "")
            {

            }
            else
            {
                double total = double.Parse(B21.Text) + double.Parse(B22.Text) + double.Parse(B23.Text) + double.Parse(B24.Text) + double.Parse(B25.Text) + double.Parse(B26.Text) + double.Parse(B27.Text) + double.Parse(B28.Text);
                B29.Text = Convert.ToString((total / 8));

                double PROM1 = double.Parse(B11.Text) + double.Parse(B21.Text);
                double PROM2 = double.Parse(B12.Text) + double.Parse(B22.Text);
                double PROM3 = double.Parse(B13.Text) + double.Parse(B23.Text);
                double PROM4 = double.Parse(B14.Text) + double.Parse(B24.Text);
                double PROM5 = double.Parse(B15.Text) + double.Parse(B25.Text);
                double PROM6 = double.Parse(B16.Text) + double.Parse(B26.Text);
                double PROM7 = double.Parse(B17.Text) + double.Parse(B27.Text);
                double PROM8 = double.Parse(B18.Text) + double.Parse(B28.Text);

                P1.Text = Convert.ToString(PROM1 / 2);
                P2.Text = Convert.ToString(PROM2 / 2);
                P3.Text = Convert.ToString(PROM3 / 2);
                P4.Text = Convert.ToString(PROM4 / 2);
                P5.Text = Convert.ToString(PROM5 / 2);
                P6.Text = Convert.ToString(PROM6 / 2);
                P7.Text = Convert.ToString(PROM7 / 2);
                P8.Text = Convert.ToString(PROM8 / 2);
            }
        }

        private void B31_TextChanged(object sender, EventArgs e)
        {

            if (B31.Text == "" ||
                    B32.Text == "" ||
                    B33.Text == "" ||
                    B34.Text == "" ||
                    B35.Text == "" ||
                    B36.Text == "" ||
                    B37.Text == "" ||
                    B38.Text == "")
            {

            }
            else
            {
                double total = double.Parse(B31.Text) + double.Parse(B32.Text) + double.Parse(B33.Text) + double.Parse(B34.Text) + double.Parse(B35.Text) + double.Parse(B36.Text) + double.Parse(B37.Text) + double.Parse(B38.Text);
                B39.Text = Convert.ToString((total / 8));

                double PROM1 = double.Parse(B11.Text) + double.Parse(B21.Text) + double.Parse(B21.Text);
                double PROM2 = double.Parse(B12.Text) + double.Parse(B22.Text) + double.Parse(B32.Text);
                double PROM3 = double.Parse(B13.Text) + double.Parse(B23.Text) + double.Parse(B33.Text);
                double PROM4 = double.Parse(B14.Text) + double.Parse(B24.Text) + double.Parse(B34.Text);
                double PROM5 = double.Parse(B15.Text) + double.Parse(B25.Text) + double.Parse(B35.Text);
                double PROM6 = double.Parse(B16.Text) + double.Parse(B26.Text) + double.Parse(B36.Text);
                double PROM7 = double.Parse(B17.Text) + double.Parse(B27.Text) + double.Parse(B37.Text);
                double PROM8 = double.Parse(B18.Text) + double.Parse(B28.Text) + double.Parse(B38.Text);

                P1.Text = Convert.ToString(PROM1 / 3);
                P2.Text = Convert.ToString(PROM2 / 3);
                P3.Text = Convert.ToString(PROM3 / 3);
                P4.Text = Convert.ToString(PROM4 / 3);
                P5.Text = Convert.ToString(PROM5 / 3);
                P6.Text = Convert.ToString(PROM6 / 3);
                P7.Text = Convert.ToString(PROM7 / 3);
                P8.Text = Convert.ToString(PROM8 / 3);
            }
        }

        private void B41_TextChanged(object sender, EventArgs e)
        {

            if (B41.Text == "" ||
                    B42.Text == "" ||
                    B43.Text == "" ||
                    B44.Text == "" ||
                    B45.Text == "" ||
                    B46.Text == "" ||
                    B47.Text == "" ||
                    B48.Text == "")
            {

            }
            else
            {
                double total = double.Parse(B41.Text) + double.Parse(B42.Text) + double.Parse(B43.Text) + double.Parse(B44.Text) + double.Parse(B45.Text) + double.Parse(B46.Text) + double.Parse(B47.Text) + double.Parse(B48.Text);
                B49.Text = Convert.ToString((total / 8));

                double PROM1 = double.Parse(B11.Text) + double.Parse(B21.Text) + double.Parse(B21.Text) + double.Parse(B41.Text);
                double PROM2 = double.Parse(B12.Text) + double.Parse(B22.Text) + double.Parse(B32.Text) + double.Parse(B42.Text);
                double PROM3 = double.Parse(B13.Text) + double.Parse(B23.Text) + double.Parse(B33.Text) + double.Parse(B43.Text);
                double PROM4 = double.Parse(B14.Text) + double.Parse(B24.Text) + double.Parse(B34.Text) + double.Parse(B44.Text);
                double PROM5 = double.Parse(B15.Text) + double.Parse(B25.Text) + double.Parse(B35.Text) + double.Parse(B45.Text);
                double PROM6 = double.Parse(B16.Text) + double.Parse(B26.Text) + double.Parse(B36.Text) + double.Parse(B46.Text);
                double PROM7 = double.Parse(B17.Text) + double.Parse(B27.Text) + double.Parse(B37.Text) + double.Parse(B47.Text);
                double PROM8 = double.Parse(B18.Text) + double.Parse(B28.Text) + double.Parse(B38.Text) + double.Parse(B48.Text);

                P1.Text = Convert.ToString(PROM1 / 4);
                P2.Text = Convert.ToString(PROM2 / 4);
                P3.Text = Convert.ToString(PROM3 / 4);
                P4.Text = Convert.ToString(PROM4 / 4);
                P5.Text = Convert.ToString(PROM5 / 4);
                P6.Text = Convert.ToString(PROM6 / 4);
                P7.Text = Convert.ToString(PROM7 / 4);
                P8.Text = Convert.ToString(PROM8 / 4);
            }
        }

        private void B51_TextChanged(object sender, EventArgs e)
        {

            if (B51.Text == "" ||
                    B52.Text == "" ||
                    B53.Text == "" ||
                    B54.Text == "" ||
                    B55.Text == "" ||
                    B56.Text == "" ||
                    B57.Text == "" ||
                    B58.Text == "")
            {

            }
            else
            {
                double total = double.Parse(B51.Text) + double.Parse(B52.Text) + double.Parse(B53.Text) + double.Parse(B54.Text) + double.Parse(B55.Text) + double.Parse(B56.Text) + double.Parse(B57.Text) + double.Parse(B58.Text);
                B59.Text = Convert.ToString((total / 8));

                double PROM1 = double.Parse(B11.Text) + double.Parse(B21.Text) + double.Parse(B21.Text) + double.Parse(B41.Text) + double.Parse(B51.Text);
                double PROM2 = double.Parse(B12.Text) + double.Parse(B22.Text) + double.Parse(B32.Text) + double.Parse(B42.Text) + double.Parse(B52.Text);
                double PROM3 = double.Parse(B13.Text) + double.Parse(B23.Text) + double.Parse(B33.Text) + double.Parse(B43.Text) + double.Parse(B53.Text);
                double PROM4 = double.Parse(B14.Text) + double.Parse(B24.Text) + double.Parse(B34.Text) + double.Parse(B44.Text) + double.Parse(B54.Text);
                double PROM5 = double.Parse(B15.Text) + double.Parse(B25.Text) + double.Parse(B35.Text) + double.Parse(B45.Text) + double.Parse(B55.Text);
                double PROM6 = double.Parse(B16.Text) + double.Parse(B26.Text) + double.Parse(B36.Text) + double.Parse(B46.Text) + double.Parse(B56.Text);
                double PROM7 = double.Parse(B17.Text) + double.Parse(B27.Text) + double.Parse(B37.Text) + double.Parse(B47.Text) + double.Parse(B57.Text);
                double PROM8 = double.Parse(B18.Text) + double.Parse(B28.Text) + double.Parse(B38.Text) + double.Parse(B48.Text) + double.Parse(B58.Text);

                P1.Text = Convert.ToString(PROM1 / 5);
                P2.Text = Convert.ToString(PROM2 / 5);
                P3.Text = Convert.ToString(PROM3 / 5);
                P4.Text = Convert.ToString(PROM4 / 5);
                P5.Text = Convert.ToString(PROM5 / 5);
                P6.Text = Convert.ToString(PROM6 / 5);
                P7.Text = Convert.ToString(PROM7 / 5);
                P8.Text = Convert.ToString(PROM8 / 5);
            }
        }

        private void B110_TextChanged(object sender, EventArgs e)
        {
            if (B110.Text == "" ||
                    B111.Text == "" ||
                    B112.Text == "" ||
                    B113.Text == "" ||
                    B114.Text == "" ||
                    B115.Text == "" ||
                    B116.Text == "" ||
                    B117.Text == "" ||
                    B118.Text == "" ||
                    textBox16.Text == "" ||
                    textBox17.Text == "" ||
                    textBox18.Text == "")
            {
            }
            else
            {
                double total = double.Parse(B110.Text) + double.Parse(B111.Text) + double.Parse(B112.Text) + double.Parse(B113.Text) + double.Parse(B114.Text) + double.Parse(B115.Text) + double.Parse(B116.Text) + double.Parse(B117.Text) + double.Parse(B118.Text) + double.Parse(textBox16.Text) + double.Parse(textBox17.Text) + double.Parse(textBox18.Text);
                B119.Text = Convert.ToString(total / 12);

                double PROM1 = double.Parse(B110.Text);
                double PROM2 = double.Parse(B111.Text);
                double PROM3 = double.Parse(B112.Text);
                double PROM4 = double.Parse(B113.Text);
                double PROM5 = double.Parse(B114.Text);
                double PROM6 = double.Parse(B115.Text);
                double PROM7 = double.Parse(B116.Text);
                double PROM8 = double.Parse(B117.Text);
                double PROM9 = double.Parse(B118.Text);
                double PROM10 = double.Parse(textBox16.Text);
                double PROM11 = double.Parse(textBox17.Text);
                double PROM12 = double.Parse(textBox18.Text);

                P10.Text = Convert.ToString(PROM1);
                P11.Text = Convert.ToString(PROM2);
                P12.Text = Convert.ToString(PROM3);
                P13.Text = Convert.ToString(PROM4);
                P14.Text = Convert.ToString(PROM5);
                P15.Text = Convert.ToString(PROM6);
                P16.Text = Convert.ToString(PROM7);
                P17.Text = Convert.ToString(PROM8);
                P18.Text = Convert.ToString(PROM9);
                textBox1.Text = Convert.ToString(PROM10);
                textBox2.Text = Convert.ToString(PROM11);
                textBox3.Text = Convert.ToString(PROM12);
            }
        }
        private void B210_TextChanged(object sender, EventArgs e)
        {
            if (B210.Text == "" ||
                    B211.Text == "" ||
                    B212.Text == "" ||
                    B213.Text == "" ||
                    B214.Text == "" ||
                    B215.Text == "" ||
                    B216.Text == "" ||
                    B217.Text == "" ||
                    B218.Text == "" ||
                    textBox13.Text == "" ||
                    textBox14.Text == "" ||
                    textBox15.Text == "")
            {
            }
            else
            {
                double total = double.Parse(B210.Text) + double.Parse(B211.Text) + double.Parse(B212.Text) + double.Parse(B213.Text) + double.Parse(B214.Text) + double.Parse(B215.Text) + double.Parse(B216.Text) + double.Parse(B217.Text) + double.Parse(B218.Text) + double.Parse(textBox13.Text) + double.Parse(textBox14.Text) + double.Parse(textBox15.Text);
                B219.Text = Convert.ToString(total / 12);

                double PROM1 = double.Parse(B110.Text) + double.Parse(B210.Text);
                double PROM2 = double.Parse(B111.Text) + double.Parse(B211.Text);
                double PROM3 = double.Parse(B112.Text) + double.Parse(B212.Text);
                double PROM4 = double.Parse(B113.Text) + double.Parse(B213.Text);
                double PROM5 = double.Parse(B114.Text) + double.Parse(B214.Text);
                double PROM6 = double.Parse(B115.Text) + double.Parse(B215.Text);
                double PROM7 = double.Parse(B116.Text) + double.Parse(B216.Text);
                double PROM8 = double.Parse(B117.Text) + double.Parse(B217.Text);
                double PROM9 = double.Parse(B118.Text) + double.Parse(B218.Text);
                double PROM10 = double.Parse(textBox16.Text) + double.Parse(textBox13.Text);
                double PROM11 = double.Parse(textBox17.Text) + double.Parse(textBox14.Text);
                double PROM12 = double.Parse(textBox18.Text) + double.Parse(textBox15.Text);

                P10.Text = Convert.ToString(PROM1 / 2);
                P11.Text = Convert.ToString(PROM2 / 2);
                P12.Text = Convert.ToString(PROM3 / 2);
                P13.Text = Convert.ToString(PROM4 / 2);
                P14.Text = Convert.ToString(PROM5 / 2);
                P15.Text = Convert.ToString(PROM6 / 2);
                P16.Text = Convert.ToString(PROM7 / 2);
                P17.Text = Convert.ToString(PROM8 / 2);
                P18.Text = Convert.ToString(PROM9 / 2);
                textBox1.Text = Convert.ToString(PROM10 / 2);
                textBox2.Text = Convert.ToString(PROM11 / 2);
                textBox3.Text = Convert.ToString(PROM12 / 2);
            }

        }

        private void B310_TextChanged(object sender, EventArgs e)
        {
            if (B310.Text == "" ||
                       B311.Text == "" ||
                       B312.Text == "" ||
                       B313.Text == "" ||
                       B314.Text == "" ||
                       B315.Text == "" ||
                       B316.Text == "" ||
                       B317.Text == "" ||
                       B318.Text == "" ||
                       textBox10.Text == "" ||
                       textBox11.Text == "" ||
                       textBox12.Text == "")
            {
            }
            else
            {
                double total = double.Parse(B310.Text) + double.Parse(B311.Text) + double.Parse(B312.Text) + double.Parse(B313.Text) + double.Parse(B314.Text) + double.Parse(B315.Text) + double.Parse(B316.Text) + double.Parse(B317.Text) + double.Parse(B318.Text) + double.Parse(textBox10.Text) + double.Parse(textBox11.Text) + double.Parse(textBox12.Text);
                B319.Text = Convert.ToString(total / 12);

                double PROM1 = double.Parse(B110.Text) + double.Parse(B210.Text) + double.Parse(B310.Text);
                double PROM2 = double.Parse(B111.Text) + double.Parse(B211.Text) + double.Parse(B311.Text);
                double PROM3 = double.Parse(B112.Text) + double.Parse(B212.Text) + double.Parse(B312.Text);
                double PROM4 = double.Parse(B113.Text) + double.Parse(B213.Text) + double.Parse(B313.Text);
                double PROM5 = double.Parse(B114.Text) + double.Parse(B214.Text) + double.Parse(B314.Text);
                double PROM6 = double.Parse(B115.Text) + double.Parse(B215.Text) + double.Parse(B315.Text);
                double PROM7 = double.Parse(B116.Text) + double.Parse(B216.Text) + double.Parse(B316.Text);
                double PROM8 = double.Parse(B117.Text) + double.Parse(B217.Text) + double.Parse(B317.Text);
                double PROM9 = double.Parse(B118.Text) + double.Parse(B218.Text) + double.Parse(B318.Text);
                double PROM10 = double.Parse(textBox16.Text) + double.Parse(textBox13.Text) + double.Parse(textBox10.Text);
                double PROM11 = double.Parse(textBox17.Text) + double.Parse(textBox14.Text) + double.Parse(textBox11.Text);
                double PROM12 = double.Parse(textBox18.Text) + double.Parse(textBox15.Text) + double.Parse(textBox12.Text);

                P10.Text = Convert.ToString(PROM1 / 3);
                P11.Text = Convert.ToString(PROM2 / 3);
                P12.Text = Convert.ToString(PROM3 / 3);
                P13.Text = Convert.ToString(PROM4 / 3);
                P14.Text = Convert.ToString(PROM5 / 3);
                P15.Text = Convert.ToString(PROM6 / 3);
                P16.Text = Convert.ToString(PROM7 / 3);
                P17.Text = Convert.ToString(PROM8 / 3);
                P18.Text = Convert.ToString(PROM9 / 3);
                textBox1.Text = Convert.ToString(PROM10 / 3);
                textBox2.Text = Convert.ToString(PROM11 / 3);
                textBox3.Text = Convert.ToString(PROM12 / 3);
            }

        }

        private void B410_TextChanged(object sender, EventArgs e)
        {
            if (B410.Text == "" ||
                       B411.Text == "" ||
                       B412.Text == "" ||
                       B413.Text == "" ||
                       B414.Text == "" ||
                       B415.Text == "" ||
                       B416.Text == "" ||
                       B417.Text == "" ||
                       B418.Text == "" ||
                       textBox7.Text == "" ||
                       textBox8.Text == "" ||
                       textBox9.Text == "")
            {
            }
            else
            {
                double total = double.Parse(B410.Text) + double.Parse(B411.Text) + double.Parse(B412.Text) + double.Parse(B413.Text) + double.Parse(B414.Text) + double.Parse(B415.Text) + double.Parse(B416.Text) + double.Parse(B417.Text) + double.Parse(B418.Text) + double.Parse(textBox7.Text) + double.Parse(textBox8.Text) + double.Parse(textBox9.Text);
                B419.Text = Convert.ToString(total / 12);

                double PROM1 = double.Parse(B110.Text) + double.Parse(B210.Text) + double.Parse(B310.Text) + double.Parse(B410.Text);
                double PROM2 = double.Parse(B111.Text) + double.Parse(B211.Text) + double.Parse(B311.Text) + double.Parse(B411.Text);
                double PROM3 = double.Parse(B112.Text) + double.Parse(B212.Text) + double.Parse(B312.Text) + double.Parse(B412.Text);
                double PROM4 = double.Parse(B113.Text) + double.Parse(B213.Text) + double.Parse(B313.Text) + double.Parse(B413.Text);
                double PROM5 = double.Parse(B114.Text) + double.Parse(B214.Text) + double.Parse(B314.Text) + double.Parse(B414.Text);
                double PROM6 = double.Parse(B115.Text) + double.Parse(B215.Text) + double.Parse(B315.Text) + double.Parse(B415.Text);
                double PROM7 = double.Parse(B116.Text) + double.Parse(B216.Text) + double.Parse(B316.Text) + double.Parse(B416.Text);
                double PROM8 = double.Parse(B117.Text) + double.Parse(B217.Text) + double.Parse(B317.Text) + double.Parse(B417.Text);
                double PROM9 = double.Parse(B118.Text) + double.Parse(B218.Text) + double.Parse(B318.Text) + double.Parse(B418.Text);
                double PROM10 = double.Parse(textBox16.Text) + double.Parse(textBox13.Text) + double.Parse(textBox10.Text) + double.Parse(textBox7.Text);
                double PROM11 = double.Parse(textBox17.Text) + double.Parse(textBox14.Text) + double.Parse(textBox11.Text) + double.Parse(textBox8.Text);
                double PROM12 = double.Parse(textBox18.Text) + double.Parse(textBox15.Text) + double.Parse(textBox12.Text) + double.Parse(textBox9.Text);

                P10.Text = Convert.ToString(PROM1 / 4);
                P11.Text = Convert.ToString(PROM2 / 4);
                P12.Text = Convert.ToString(PROM3 / 4);
                P13.Text = Convert.ToString(PROM4 / 4);
                P14.Text = Convert.ToString(PROM5 / 4);
                P15.Text = Convert.ToString(PROM6 / 4);
                P16.Text = Convert.ToString(PROM7 / 4);
                P17.Text = Convert.ToString(PROM8 / 4);
                P18.Text = Convert.ToString(PROM9 / 4);
                textBox1.Text = Convert.ToString(PROM10 / 4);
                textBox2.Text = Convert.ToString(PROM11 / 4);
                textBox3.Text = Convert.ToString(PROM12 / 4);
            }
        }

        private void B510_TextChanged(object sender, EventArgs e)
        {
            if (B510.Text == "" ||
                       B511.Text == "" ||
                       B512.Text == "" ||
                       B513.Text == "" ||
                       B514.Text == "" ||
                       B515.Text == "" ||
                       B516.Text == "" ||
                       B517.Text == "" ||
                       B518.Text == "" ||
                       textBox4.Text == "" ||
                       textBox5.Text == "" ||
                       textBox6.Text == "")
            {
            }
            else
            {
                double total = double.Parse(B510.Text) + double.Parse(B511.Text) + double.Parse(B512.Text) + double.Parse(B513.Text) + double.Parse(B514.Text) + double.Parse(B515.Text) + double.Parse(B516.Text) + double.Parse(B517.Text) + double.Parse(B518.Text) + double.Parse(textBox4.Text) + double.Parse(textBox5.Text) + double.Parse(textBox6.Text);
                B519.Text = Convert.ToString(total / 12);

                double PROM1 = double.Parse(B110.Text) + double.Parse(B210.Text) + double.Parse(B310.Text) + double.Parse(B410.Text) + double.Parse(B510.Text);
                double PROM2 = double.Parse(B111.Text) + double.Parse(B211.Text) + double.Parse(B311.Text) + double.Parse(B411.Text) + double.Parse(B511.Text);
                double PROM3 = double.Parse(B112.Text) + double.Parse(B212.Text) + double.Parse(B312.Text) + double.Parse(B412.Text) + double.Parse(B512.Text);
                double PROM4 = double.Parse(B113.Text) + double.Parse(B213.Text) + double.Parse(B313.Text) + double.Parse(B413.Text) + double.Parse(B513.Text);
                double PROM5 = double.Parse(B114.Text) + double.Parse(B214.Text) + double.Parse(B314.Text) + double.Parse(B414.Text) + double.Parse(B514.Text);
                double PROM6 = double.Parse(B115.Text) + double.Parse(B215.Text) + double.Parse(B315.Text) + double.Parse(B414.Text) + double.Parse(B514.Text);
                double PROM7 = double.Parse(B116.Text) + double.Parse(B216.Text) + double.Parse(B316.Text) + double.Parse(B416.Text) + double.Parse(B516.Text);
                double PROM8 = double.Parse(B117.Text) + double.Parse(B217.Text) + double.Parse(B317.Text) + double.Parse(B417.Text) + double.Parse(B517.Text);
                double PROM9 = double.Parse(B118.Text) + double.Parse(B218.Text) + double.Parse(B318.Text) + double.Parse(B418.Text) + double.Parse(B518.Text);
                double PROM10 = double.Parse(textBox16.Text) + double.Parse(textBox13.Text) + double.Parse(textBox10.Text) + double.Parse(textBox7.Text) + double.Parse(textBox4.Text);
                double PROM11 = double.Parse(textBox17.Text) + double.Parse(textBox14.Text) + double.Parse(textBox11.Text) + double.Parse(textBox8.Text) + double.Parse(textBox5.Text);
                double PROM12 = double.Parse(textBox18.Text) + double.Parse(textBox15.Text) + double.Parse(textBox12.Text) + double.Parse(textBox9.Text) + double.Parse(textBox6.Text);

                P10.Text = Convert.ToString(PROM1 / 5);
                P11.Text = Convert.ToString(PROM2 / 5);
                P12.Text = Convert.ToString(PROM3 / 5);
                P13.Text = Convert.ToString(PROM4 / 5);
                P14.Text = Convert.ToString(PROM5 / 5);
                P15.Text = Convert.ToString(PROM6 / 5);
                P16.Text = Convert.ToString(PROM7 / 5);
                P17.Text = Convert.ToString(PROM8 / 5);
                P18.Text = Convert.ToString(PROM9 / 5);
                textBox1.Text = Convert.ToString(PROM10 / 5);
                textBox2.Text = Convert.ToString(PROM11 / 5);
                textBox3.Text = Convert.ToString(PROM12 / 5);
            }
        }

        private void P1_TextChanged(object sender, EventArgs e)
        {
            if (P1.Text == "" ||
                    P2.Text == "" ||
                    P3.Text == "" ||
                    P4.Text == "" ||
                    P5.Text == "" ||
                    P6.Text == "" ||
                    P7.Text == "" ||
                    P8.Text == "")
            {

            }
            else
            {
                double total = double.Parse(P1.Text) + double.Parse(P2.Text) + double.Parse(P3.Text) + double.Parse(P4.Text) + double.Parse(P5.Text) + double.Parse(P6.Text) + double.Parse(P7.Text) + double.Parse(P8.Text);
                P9.Text = Convert.ToString(Math.Round(total / 8));
            }
        }

        private void P10_TextChanged(object sender, EventArgs e)
        {
            if (P10.Text == "" ||
                       P11.Text == "" ||
                       P12.Text == "" ||
                       P13.Text == "" ||
                       P14.Text == "" ||
                       P15.Text == "" ||
                       P16.Text == "" ||
                       P17.Text == "" ||
                       P18.Text == "" ||
                       textBox1.Text == "" ||
                       textBox2.Text == "" ||
                       textBox3.Text == "")
            {
            }
            else
            {
                double total = double.Parse(P10.Text) + double.Parse(P11.Text) + double.Parse(P12.Text) + double.Parse(P13.Text) + double.Parse(P14.Text) + double.Parse(P15.Text) + double.Parse(P16.Text) + double.Parse(P17.Text) + double.Parse(P18.Text) + double.Parse(textBox1.Text) + double.Parse(textBox2.Text) + double.Parse(textBox3.Text);
                P19.Text = Convert.ToString(Math.Round(total / 12));
            }
        }

        private void TO23_TextChanged(object sender, EventArgs e)
        {
            if (TS23.Text == "" || TO23.Text == "")
            {

            }
            else
            {
                double ASIS = double.Parse(TS23.Text) + double.Parse(TO23.Text); ;
                B123.Text = Convert.ToString(ASIS);

                double proasis = double.Parse(B123.Text);
                P23.Text = Convert.ToString(proasis);
            }
        }

        private void TN23_TextChanged(object sender, EventArgs e)
        {
            if (TN23.Text == "" || TDD23.Text == "")
            {

            }
            else
            {
                double ASIS = double.Parse(TN23.Text) + double.Parse(TDD23.Text); ;
                B223.Text = Convert.ToString(ASIS);

                double proasis = double.Parse(B123.Text) + double.Parse(B223.Text);
                P23.Text = Convert.ToString(proasis);
            }
        }

        private void TF23_TextChanged(object sender, EventArgs e)
        {
            if (TE23.Text == "" || TF23.Text == "")
            {

            }
            else
            {
                double ASIS = double.Parse(TE23.Text) + double.Parse(TF23.Text); ;
                B323.Text = Convert.ToString(ASIS);

                double proasis = double.Parse(B123.Text) + double.Parse(B223.Text) + double.Parse(B323.Text);
                P23.Text = Convert.ToString(proasis);
            }
        }

        private void TA23_TextChanged(object sender, EventArgs e)
        {
            if (TM23.Text == "" || TA23.Text == "")
            {

            }
            else
            {
                double ASIS = double.Parse(TM23.Text) + double.Parse(TA23.Text); ;
                B423.Text = Convert.ToString(ASIS);

                double proasis = double.Parse(B123.Text) + double.Parse(B223.Text) + double.Parse(B323.Text) + double.Parse(B423.Text);
                P23.Text = Convert.ToString(proasis);
            }
        }

        private void TJ23_TextChanged(object sender, EventArgs e)
        {
            if (TMA23.Text == "" || TJ23.Text == "")
            {

            }
            else
            {
                double ASIS = double.Parse(TMA23.Text) + double.Parse(TJ23.Text); ;
                B523.Text = Convert.ToString(ASIS);

                double proasis = double.Parse(B123.Text) + double.Parse(B223.Text) + double.Parse(B323.Text) + double.Parse(B423.Text) + double.Parse(B523.Text);
                P23.Text = Convert.ToString(proasis);
            }
        }

        private void P9_TextChanged(object sender, EventArgs e)
        {

        }

        private void B49_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            TD3.Enabled = true;
            TD1.Enabled = true;
            TD3.Enabled = true;
            TD4.Enabled = true;
            TD5.Enabled = true;
            TD6.Enabled = true;
            TD7.Enabled = true;
            TD8.Enabled = true;
            //TxBDiaCom.Enabled = true;
            //TxBDiaIng.Enabled = true;

            TD10.Enabled = true;
            TD11.Enabled = true;
            TD12.Enabled = true;
            TD13.Enabled = true;
            TD14.Enabled = true;
            TD15.Enabled = true;
            TD16.Enabled = true;
            TD17.Enabled = true;
            TD18.Enabled = true;
            txt1.Enabled = true;
            txt2.Enabled = true;
            txt3.Enabled = true;

            TD23.Enabled = true;


            //Deshabilita los textbox de Septiembre
            TS1.Enabled = true;
            TS2.Enabled = true;
            TS3.Enabled = true;
            TS4.Enabled = true;
            TS5.Enabled = true;
            TS6.Enabled = true;
            TS7.Enabled = true;
            TS8.Enabled = true;
            //TxBSepCom.Enabled = true;
            //TxBSepIng.Enabled = true;

            TS10.Enabled = true;
            TS11.Enabled = true;
            TS12.Enabled = true;
            TS13.Enabled = true;
            TS14.Enabled = true;
            TS15.Enabled = true;
            TS16.Enabled = true;
            TS17.Enabled = true;
            TS18.Enabled = true;
            txt6.Enabled = true;
            txt5.Enabled = true;
            txt4.Enabled = true;

            TS23.Enabled = true;

            //Deshabilita los textbox de Octubre
            TO1.Enabled = true;
            TO2.Enabled = true;
            TO3.Enabled = true;
            TO4.Enabled = true;
            TO5.Enabled = true;
            TO6.Enabled = true;
            TO7.Enabled = true;
            TO8.Enabled = true;
            //TxBOctCom.Enabled = true;
            //TxBOctIng.Enabled = true;

            T10.Enabled = true;
            TO11.Enabled = true;
            TO12.Enabled = true;
            TO13.Enabled = true;
            TO14.Enabled = true;
            TO15.Enabled = true;
            TO16.Enabled = true;
            TO17.Enabled = true;
            TO18.Enabled = true;
            txt8.Enabled = true;
            txt9.Enabled = true;
            txt7.Enabled = true;

            TO23.Enabled = true;

            //Deshabilita los textbox de Noviembre
            TN1.Enabled = true;
            TN2.Enabled = true;
            TN3.Enabled = true;
            TN4.Enabled = true;
            TN5.Enabled = true;
            TN6.Enabled = true;
            TN7.Enabled = true;
            TN8.Enabled = true;
            //TxBNovCom.Enabled = true;
            //TxBNovIng.Enabled = true;

            TN10.Enabled = true;
            TN11.Enabled = true;
            TN12.Enabled = true;
            TN13.Enabled = true;
            TN14.Enabled = true;
            TN15.Enabled = true;
            TN16.Enabled = true;
            TN17.Enabled = true;
            TN18.Enabled = true;
            txt10.Enabled = true;
            txt11.Enabled = true;
            txt12.Enabled = true;

            TN23.Enabled = true;

            //Deshabilita los textbox de Diciembre
            TDD1.Enabled = true;
            TDD2.Enabled = true;
            TDD3.Enabled = true;
            TDD4.Enabled = true;
            TDD5.Enabled = true;
            TDD6.Enabled = true;
            TDD7.Enabled = true;
            TDD8.Enabled = true;
            //TxBDicCom.Enabled = true;
            //TxBDicIng.Enabled = true;

            TDD10.Enabled = true;
            TDD11.Enabled = true;
            TDD12.Enabled = true;
            TDD13.Enabled = true;
            TDD14.Enabled = true;
            TDD15.Enabled = true;
            TDD16.Enabled = true;
            TDD17.Enabled = true;
            TDD18.Enabled = true;
            txt13.Enabled = true;
            txt14.Enabled = true;
            txt15.Enabled = true;

            TDD23.Enabled = true;

            //Deshabilita los textbox de Enero
            TE1.Enabled = true;
            TE2.Enabled = true;
            TE3.Enabled = true;
            TE4.Enabled = true;
            TE5.Enabled = true;
            TE6.Enabled = true;
            TE7.Enabled = true;
            TE8.Enabled = true;
            //TxBEneCom.Enabled = true;
            //TxBEneIng.Enabled = true;

            TE10.Enabled = true;
            TE11.Enabled = true;
            TE12.Enabled = true;
            TE13.Enabled = true;
            TE14.Enabled = true;
            TE15.Enabled = true;
            TE16.Enabled = true;
            TE17.Enabled = true;
            TE18.Enabled = true;
            txt16.Enabled = true;
            txt17.Enabled = true;
            txt18.Enabled = true;

            TE23.Enabled = true;

            //Deshabilita los textbox de Febrero
            TF1.Enabled = true;
            TF2.Enabled = true;
            TF3.Enabled = true;
            TF4.Enabled = true;
            TF5.Enabled = true;
            TF6.Enabled = true;
            TF7.Enabled = true;
            TF8.Enabled = true;
            //TxBFebCom.Enabled = true;
            //TxBFebIng.Enabled = true;

            TF10.Enabled = true;
            TF11.Enabled = true;
            TF12.Enabled = true;
            TF13.Enabled = true;
            TF14.Enabled = true;
            TF15.Enabled = true;
            TF16.Enabled = true;
            TF17.Enabled = true;
            TF18.Enabled = true;
            textBox31.Enabled = true;
            textBox32.Enabled = true;
            textBox33.Enabled = true;

            TF23.Enabled = true;

            //Deshabilita los textbox de Marzo
            TM1.Enabled = true;
            TM2.Enabled = true;
            TM3.Enabled = true;
            TM4.Enabled = true;
            TM5.Enabled = true;
            TM6.Enabled = true;
            TM7.Enabled = true;
            TM8.Enabled = true;
            //TxBMarCom.Enabled = true;
            //TxBMarIng.Enabled = true;

            TM10.Enabled = true;
            TM11.Enabled = true;
            TM12.Enabled = true;
            TM13.Enabled = true;
            TM14.Enabled = true;
            TM15.Enabled = true;
            TM16.Enabled = true;
            TM17.Enabled = true;
            TM18.Enabled = true;
            textBox28.Enabled = true;
            textBox29.Enabled = true;
            textBox30.Enabled = true;

            TM23.Enabled = true;

            //Deshabilita los textbox de Abril
            TA1.Enabled = true;
            TA2.Enabled = true;
            TA3.Enabled = true;
            TA4.Enabled = true;
            TA5.Enabled = true;
            TA6.Enabled = true;
            TA7.Enabled = true;
            TA8.Enabled = true;
            //TxBAbrCom.Enabled = true;
            //TxBAbrIng.Enabled = true;

            TA10.Enabled = true;
            TA11.Enabled = true;
            TA12.Enabled = true;
            TA13.Enabled = true;
            TA14.Enabled = true;
            TA15.Enabled = true;
            TA16.Enabled = true;
            TA17.Enabled = true;
            TA18.Enabled = true;
            textBox25.Enabled = true;
            textBox26.Enabled = true;
            textBox27.Enabled = true;

            TA23.Enabled = true;

            //Deshabilita los textbox de Mayo
            TMA1.Enabled = true;
            TMA2.Enabled = true;
            TMA3.Enabled = true;
            TMA4.Enabled = true;
            TMA5.Enabled = true;
            TMA6.Enabled = true;
            TMA7.Enabled = true;
            TMA8.Enabled = true;
            //TxBMayCom.Enabled = true;
            //TxBMayIng.Enabled = true;

            TMA10.Enabled = true;
            TMA11.Enabled = true;
            TMA12.Enabled = true;
            TMA13.Enabled = true;
            TMA14.Enabled = true;
            TMA15.Enabled = true;
            TMA16.Enabled = true;
            TMA17.Enabled = true;
            TMA18.Enabled = true;
            textBox22.Enabled = true;
            textBox23.Enabled = true;
            textBox24.Enabled = true;

            TMA23.Enabled = true;

            //Deshabilita los textbox de Junio
            TJ1.Enabled = true;
            TJ2.Enabled = true;
            TJ3.Enabled = true;
            TJ4.Enabled = true;
            TJ5.Enabled = true;
            TJ6.Enabled = true;
            TJ7.Enabled = true;
            TJ8.Enabled = true;
            //TxBJunCom.Enabled = true;
            //TxBJunIng.Enabled = true;

            TJ10.Enabled = true;
            TJ11.Enabled = true;
            TJ12.Enabled = true;
            TJ13.Enabled = true;
            TJ14.Enabled = true;
            TJ15.Enabled = true;
            TJ16.Enabled = true;
            TJ17.Enabled = true;
            TJ18.Enabled = true;
            textBox19.Enabled = true;
            textBox20.Enabled = true;
            textBox21.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modifica Califica = new Modifica();

            if (txtbuscador.Text == "" ||
                        TD3.Text == "" ||
                        TD1.Text == "" ||
                        TD3.Text == "" ||
                        TD4.Text == "" ||
                        TD5.Text == "" ||
                        TD6.Text == "" ||
                        TD7.Text == "" ||
                        TD8.Text == "" ||
                        //TxBDiaCom.Text == ""||
                        //TxBDiaIng.Text == ""||

                        TD10.Text == "" ||
                        TD11.Text == "" ||
                        TD12.Text == "" ||
                        TD13.Text == "" ||
                        TD14.Text == "" ||
                        TD15.Text == "" ||
                        TD16.Text == "" ||
                        TD17.Text == "" ||
                        TD18.Text == "" ||
                        txt1.Text == "" ||
                        txt2.Text == "" ||
                        txt3.Text == "" ||

                        TD23.Text == "" ||


                        //Deshabilita los textbox de Septiembre
                        TS1.Text == "" ||
                        TS2.Text == "" ||
                        TS3.Text == "" ||
                        TS4.Text == "" ||
                        TS5.Text == "" ||
                        TS6.Text == "" ||
                        TS7.Text == "" ||
                        TS8.Text == "" ||
                        //TxBSepCom.Text == ""||
                        //TxBSepIng.Text == ""||

                        TS10.Text == "" ||
                        TS11.Text == "" ||
                        TS12.Text == "" ||
                        TS13.Text == "" ||
                        TS14.Text == "" ||
                        TS15.Text == "" ||
                        TS16.Text == "" ||
                        TS17.Text == "" ||
                        TS18.Text == "" ||
                        txt6.Text == "" ||
                        txt5.Text == "" ||
                        txt4.Text == "" ||

                        TS23.Text == "" ||

                        //Deshabilita los textbox de Octubre
                        TO1.Text == "" ||
                        TO2.Text == "" ||
                        TO3.Text == "" ||
                        TO4.Text == "" ||
                        TO5.Text == "" ||
                        TO6.Text == "" ||
                        TO7.Text == "" ||
                        TO8.Text == "" ||
                        //TxBOctCom.Text == ""||
                        //TxBOctIng.Text == ""||

                        T10.Text == "" ||
                        TO11.Text == "" ||
                        TO12.Text == "" ||
                        TO13.Text == "" ||
                        TO14.Text == "" ||
                        TO15.Text == "" ||
                        TO16.Text == "" ||
                        TO17.Text == "" ||
                        TO18.Text == "" ||
                        txt8.Text == "" ||
                        txt9.Text == "" ||
                        txt7.Text == "" ||

                        TO23.Text == "" ||

                        //Deshabilita los textbox de Noviembre
                        TN1.Text == "" ||
                        TN2.Text == "" ||
                        TN3.Text == "" ||
                        TN4.Text == "" ||
                        TN5.Text == "" ||
                        TN6.Text == "" ||
                        TN7.Text == "" ||
                        TN8.Text == "" ||
                        //TxBNovCom.Text == ""||
                        //TxBNovIng.Text == ""||

                        TN10.Text == "" ||
                        TN11.Text == "" ||
                        TN12.Text == "" ||
                        TN13.Text == "" ||
                        TN14.Text == "" ||
                        TN15.Text == "" ||
                        TN16.Text == "" ||
                        TN17.Text == "" ||
                        TN18.Text == "" ||
                        txt10.Text == "" ||
                        txt11.Text == "" ||
                        txt12.Text == "" ||

                        TN23.Text == "" ||

                        //Deshabilita los textbox de Diciembre
                        TDD1.Text == "" ||
                        TDD2.Text == "" ||
                        TDD3.Text == "" ||
                        TDD4.Text == "" ||
                        TDD5.Text == "" ||
                        TDD6.Text == "" ||
                        TDD7.Text == "" ||
                        TDD8.Text == "" ||
                        //TxBDicCom.Text == ""||
                        //TxBDicIng.Text == ""||

                        TDD10.Text == "" ||
                        TDD11.Text == "" ||
                        TDD12.Text == "" ||
                        TDD13.Text == "" ||
                        TDD14.Text == "" ||
                        TDD15.Text == "" ||
                        TDD16.Text == "" ||
                        TDD17.Text == "" ||
                        TDD18.Text == "" ||
                        txt13.Text == "" ||
                        txt14.Text == "" ||
                        txt15.Text == "" ||

                        TDD23.Text == "" ||

                        //Deshabilita los textbox de Enero
                        TE1.Text == "" ||
                        TE2.Text == "" ||
                        TE3.Text == "" ||
                        TE4.Text == "" ||
                        TE5.Text == "" ||
                        TE6.Text == "" ||
                        TE7.Text == "" ||
                        TE8.Text == "" ||
                        //TxBEneCom.Text == ""||
                        //TxBEneIng.Text == ""||

                        TE10.Text == "" ||
                        TE11.Text == "" ||
                        TE12.Text == "" ||
                        TE13.Text == "" ||
                        TE14.Text == "" ||
                        TE15.Text == "" ||
                        TE16.Text == "" ||
                        TE17.Text == "" ||
                        TE18.Text == "" ||
                        txt16.Text == "" ||
                        txt17.Text == "" ||
                        txt18.Text == "" ||

                        TE23.Text == "" ||

                        //Deshabilita los textbox de Febrero
                        TF1.Text == "" ||
                        TF2.Text == "" ||
                        TF3.Text == "" ||
                        TF4.Text == "" ||
                        TF5.Text == "" ||
                        TF6.Text == "" ||
                        TF7.Text == "" ||
                        TF8.Text == "" ||
                        //TxBFebCom.Text == ""||
                        //TxBFebIng.Text == ""||

                        TF10.Text == "" ||
                        TF11.Text == "" ||
                        TF12.Text == "" ||
                        TF13.Text == "" ||
                        TF14.Text == "" ||
                        TF15.Text == "" ||
                        TF16.Text == "" ||
                        TF17.Text == "" ||
                        TF18.Text == "" ||
                        textBox31.Text == "" ||
                        textBox32.Text == "" ||
                        textBox33.Text == "" ||

                        TF23.Text == "" ||

                        //Deshabilita los textbox de Marzo
                        TM1.Text == "" ||
                        TM2.Text == "" ||
                        TM3.Text == "" ||
                        TM4.Text == "" ||
                        TM5.Text == "" ||
                        TM6.Text == "" ||
                        TM7.Text == "" ||
                        TM8.Text == "" ||
                        //TxBMarCom.Text == ""||
                        //TxBMarIng.Text == ""||

                        TM10.Text == "" ||
                        TM11.Text == "" ||
                        TM12.Text == "" ||
                        TM13.Text == "" ||
                        TM14.Text == "" ||
                        TM15.Text == "" ||
                        TM16.Text == "" ||
                        TM17.Text == "" ||
                        TM18.Text == "" ||
                        textBox28.Text == "" ||
                        textBox29.Text == "" ||
                        textBox30.Text == "" ||

                        TM23.Text == "" ||

                        //Deshabilita los textbox de Abril
                        TA1.Text == "" ||
                        TA2.Text == "" ||
                        TA3.Text == "" ||
                        TA4.Text == "" ||
                        TA5.Text == "" ||
                        TA6.Text == "" ||
                        TA7.Text == "" ||
                        TA8.Text == "" ||
                        //TxBAbrCom.Text == ""||
                        //TxBAbrIng.Text == ""||

                        TA10.Text == "" ||
                        TA11.Text == "" ||
                        TA12.Text == "" ||
                        TA13.Text == "" ||
                        TA14.Text == "" ||
                        TA15.Text == "" ||
                        TA16.Text == "" ||
                        TA17.Text == "" ||
                        TA18.Text == "" ||
                        textBox25.Text == "" ||
                        textBox26.Text == "" ||
                        textBox27.Text == "" ||

                        TA23.Text == "" ||

                        //Deshabilita los textbox de Mayo
                        TMA1.Text == "" ||
                        TMA2.Text == "" ||
                        TMA3.Text == "" ||
                        TMA4.Text == "" ||
                        TMA5.Text == "" ||
                        TMA6.Text == "" ||
                        TMA7.Text == "" ||
                        TMA8.Text == "" ||
                        //TxBMayCom.Text == ""||
                        //TxBMayIng.Text == ""||

                        TMA10.Text == "" ||
                        TMA11.Text == "" ||
                        TMA12.Text == "" ||
                        TMA13.Text == "" ||
                        TMA14.Text == "" ||
                        TMA15.Text == "" ||
                        TMA16.Text == "" ||
                        TMA17.Text == "" ||
                        TMA18.Text == "" ||
                        textBox22.Text == "" ||
                        textBox23.Text == "" ||
                        textBox24.Text == "" ||

                        TMA23.Text == "" ||


                        //Deshabilita los textbox de Junio
                        TJ1.Text == "" ||
                        TJ2.Text == "" ||
                        TJ3.Text == "" ||
                        TJ4.Text == "" ||
                        TJ5.Text == "" ||
                        TJ6.Text == "" ||
                        TJ7.Text == "" ||
                        TJ8.Text == "" ||
                        //TxBJunCom.Text == ""||
                        //TxBJunIng.Text == ""||

                        TJ10.Text == "" ||
                        TJ11.Text == "" ||
                        TJ12.Text == "" ||
                        TJ13.Text == "" ||
                        TJ14.Text == "" ||
                        TJ15.Text == "" ||
                        TJ16.Text == "" ||
                        TJ17.Text == "" ||
                        TJ18.Text == "" ||
                        textBox19.Text == "" ||
                        textBox20.Text == "" ||
                        textBox21.Text == "" ||

                        TJ23.Text == "")
            {
                MessageBox.Show("Debe de buscar un alumno y seleccionar un mes", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (TD1.Text == "" || TD2.Text == "" || TD3.Text == "" || TD4.Text == "" || TD5.Text == "" || TD6.Text == ""
                    || TD7.Text == "" || TD8.Text == "" || TD10.Text == "" || TD11.Text == "" || TD12.Text == "" ||
                    TD13.Text == "" || TD14.Text == "" || TD15.Text == "" || TD16.Text == "" || TD17.Text == "")
                {
                    MessageBox.Show("UN CAMPO ESTA VACIO, DEBE DE LLENARLO ANTES DE GUARDAR", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Califica.Curp = txtbuscador.Text;
                    Califica.Mes = "DIAGNOSTICO";
                    Califica.Grado = txtgrado.Text;

                    Califica.Español = TD1.Text;
                    Califica.Matematicas = TD2.Text;
                    Califica.Nat_y_Soc = TD3.Text;
                    Califica.Civica = TD4.Text;
                    Califica.Ed_Fisica = TD5.Text;
                    Califica.Ed_Artistica = TD6.Text;
                    Califica.Computacion = TD7.Text;
                    Califica.Ingles = TD8.Text;

                    Califica.Ortografia = TD10.Text;
                    Califica.Disciplina = TD11.Text;
                    Califica.Uniforme = TD12.Text;
                    Califica.Puntualidad = TD13.Text;
                    Califica.Material = TD14.Text;
                    Califica.Partici = TD15.Text;
                    Califica.Comp_Lect = TD16.Text;
                    Califica.Trabajos = TD17.Text;
                    Califica.Tareas = TD18.Text;
                    Califica.Karate = txt1.Text;
                    Califica.Ballet = txt2.Text;
                    Califica.Take = txt3.Text;
                    Califica.Inasistenicias = TD23.Text;

                    int resultado = Modificacion(Califica);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Calificacion Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el la Calificacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    };
                }


                if (TS1.Text == "" || TS2.Text == "" || TS3.Text == "" || TS6.Text == "" || TS7.Text == "" || TS8.Text == "" ||
                     TS10.Text == "" || TS11.Text == "" || TS12.Text == "" || TS13.Text == "" || TS14.Text == "" ||
                    TS15.Text == "" || TS16.Text == "" || TS17.Text == "" || TS18.Text == "" || TS23.Text == "")
                {
                    MessageBox.Show("UN CAMPO ESTA VACIO, DEBE DE LLENARLO ANTES DE CONTINUAR", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Califica.Curp = txtbuscador.Text;
                    Califica.Mes = "SEPTIEMBRE";
                    Califica.Grado = txtgrado.Text;

                    Califica.Español = TS1.Text;
                    Califica.Matematicas = TS2.Text;
                    Califica.Nat_y_Soc = TS3.Text;
                    Califica.Civica = TS4.Text;
                    Califica.Ed_Fisica = TS5.Text;
                    Califica.Ed_Artistica = TS6.Text;
                    Califica.Computacion = TS7.Text;
                    Califica.Ingles = TS8.Text;

                    Califica.Ortografia = TS10.Text;
                    Califica.Disciplina = TS11.Text;
                    Califica.Uniforme = TS12.Text;
                    Califica.Puntualidad = TS13.Text;
                    Califica.Material = TS14.Text;
                    Califica.Partici = TS15.Text;
                    Califica.Comp_Lect = TS16.Text;
                    Califica.Trabajos = TS17.Text;
                    Califica.Tareas = TS18.Text;
                    Califica.Karate = txt4.Text;
                    Califica.Ballet = txt5.Text;
                    Califica.Take = txt6.Text;
                    Califica.Inasistenicias = TS23.Text;

                    int resultado = Modificacion(Califica);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Calificacion Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el la Calificacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    };
                }


                if (TO1.Text == "" || TO2.Text == "" || TO3.Text == "" || TO6.Text == "" || TO7.Text == "" || TO8.Text == "" ||
                    T10.Text == "" || TO11.Text == "" || TO12.Text == "" || TO13.Text == "" || TO14.Text == "" ||
                    TO15.Text == "" || TO16.Text == "" || TO17.Text == "" || TO18.Text == "" || TO23.Text == "")
                {
                    MessageBox.Show("UN CAMPO ESTA VACIO, DEBE DE LLENARLO ANTES DE CONTINUAR", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Califica.Curp = txtbuscador.Text;
                    Califica.Mes = "OCTUBRE";
                    Califica.Grado = txtgrado.Text;

                    Califica.Español = TO1.Text;
                    Califica.Matematicas = TO2.Text;
                    Califica.Nat_y_Soc = TO3.Text;
                    Califica.Civica = TO4.Text;
                    Califica.Ed_Fisica = TO5.Text;
                    Califica.Ed_Artistica = TO6.Text;
                    Califica.Computacion = TO7.Text;
                    Califica.Ingles = TO8.Text;

                    Califica.Ortografia = T10.Text;
                    Califica.Disciplina = TO11.Text;
                    Califica.Uniforme = TO12.Text;
                    Califica.Puntualidad = TO13.Text;
                    Califica.Material = TO14.Text;
                    Califica.Partici = TO15.Text;
                    Califica.Comp_Lect = TO16.Text;
                    Califica.Trabajos = TO17.Text;
                    Califica.Tareas = TO18.Text;
                    Califica.Karate = txt7.Text;
                    Califica.Ballet = txt8.Text;
                    Califica.Take = txt9.Text;
                    Califica.Inasistenicias = TO23.Text;

                    int resultado = Modificacion(Califica);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Calificacion Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el la Calificacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    };
                }



                if (TN1.Text == "" || TN2.Text == "" || TN3.Text == "" || TN6.Text == "" || TN7.Text == "" || TN8.Text == ""
                    || TN10.Text == "" || TN11.Text == "" || TN12.Text == "" || TN13.Text == "" || TN14.Text == "" ||
                    TN15.Text == "" || TN16.Text == "" || TN17.Text == "" || TN18.Text == "" || TN23.Text == "")
                {
                    MessageBox.Show("UN CAMPO ESTA VACIO, DEBE DE LLENARLO ANTES DE CONTINUAR", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Califica.Curp = txtbuscador.Text;
                    Califica.Mes = "NOVIEMBRE";
                    Califica.Grado = txtgrado.Text;

                    Califica.Español = TN1.Text;
                    Califica.Matematicas = TN2.Text;
                    Califica.Nat_y_Soc = TN3.Text;
                    Califica.Civica = TN4.Text;
                    Califica.Ed_Fisica = TN5.Text;
                    Califica.Ed_Artistica = TN6.Text;
                    Califica.Computacion = TN7.Text;
                    Califica.Ingles = TN8.Text;

                    Califica.Ortografia = TN10.Text;
                    Califica.Disciplina = TN11.Text;
                    Califica.Uniforme = TN12.Text;
                    Califica.Puntualidad = TN13.Text;
                    Califica.Material = TN14.Text;
                    Califica.Partici = TN15.Text;
                    Califica.Comp_Lect = TN16.Text;
                    Califica.Trabajos = TN17.Text;
                    Califica.Tareas = TN18.Text;
                    Califica.Karate = txt10.Text;
                    Califica.Ballet = txt11.Text;
                    Califica.Take = txt12.Text;
                    Califica.Inasistenicias = TN23.Text;

                    int resultado = Modificacion(Califica);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Calificacion Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el la Calificacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    };
                }


                if (TDD1.Text == "" || TDD2.Text == "" || TDD3.Text == "" || TDD6.Text == "" || TDD7.Text == "" || TDD8.Text == "" ||
                     TDD10.Text == "" || TDD11.Text == "" || TDD12.Text == "" || TDD13.Text == "" || TDD14.Text == "" ||
                    TDD15.Text == "" || TDD16.Text == "" || TDD17.Text == "" || TDD18.Text == "" || TDD23.Text == "")
                {
                    MessageBox.Show("UN CAMPO ESTA VACIO, DEBE DE LLENARLO ANTES DE CONTINUAR", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Califica.Curp = txtbuscador.Text;
                    Califica.Mes = "DICIEMBRE";
                    Califica.Grado = txtgrado.Text;

                    Califica.Español = TDD1.Text;
                    Califica.Matematicas = TDD2.Text;
                    Califica.Nat_y_Soc = TDD3.Text;
                    Califica.Civica = TDD4.Text;
                    Califica.Ed_Fisica = TDD5.Text;
                    Califica.Ed_Artistica = TDD6.Text;
                    Califica.Computacion = TDD7.Text;
                    Califica.Ingles = TDD8.Text;

                    Califica.Ortografia = TDD10.Text;
                    Califica.Disciplina = TDD11.Text;
                    Califica.Uniforme = TDD12.Text;
                    Califica.Puntualidad = TDD13.Text;
                    Califica.Material = TDD14.Text;
                    Califica.Partici = TDD15.Text;
                    Califica.Comp_Lect = TDD16.Text;
                    Califica.Trabajos = TDD17.Text;
                    Califica.Tareas = TDD18.Text;
                    Califica.Karate = txt13.Text;
                    Califica.Ballet = txt14.Text;
                    Califica.Take = txt15.Text;
                    Califica.Inasistenicias = TDD23.Text;

                    int resultado = Modificacion(Califica);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Calificacion Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el la Calificacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    };
                }


                if (TE1.Text == "" || TE2.Text == "" || TE3.Text == "" || TE6.Text == "" || TE7.Text == "" || TE8.Text == ""
                   || TE10.Text == "" || TE11.Text == "" || TE12.Text == "" || TE13.Text == "" || TE14.Text == "" ||
                    TE15.Text == "" || TE16.Text == "" || TE17.Text == "" || TE18.Text == "" || TE23.Text == "")
                {
                    MessageBox.Show("UN CAMPO ESTA VACIO, DEBE DE LLENARLO ANTES DE CONTINUAR", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Califica.Curp = txtbuscador.Text;
                    Califica.Mes = "ENERO";
                    Califica.Grado = txtgrado.Text;

                    Califica.Español = TE1.Text;
                    Califica.Matematicas = TE2.Text;
                    Califica.Nat_y_Soc = TE3.Text;
                    Califica.Civica = TE4.Text;
                    Califica.Ed_Fisica = TE5.Text;
                    Califica.Ed_Artistica = TE6.Text;
                    Califica.Computacion = TE7.Text;
                    Califica.Ingles = TE8.Text;

                    Califica.Ortografia = TE10.Text;
                    Califica.Disciplina = TE11.Text;
                    Califica.Uniforme = TE12.Text;
                    Califica.Puntualidad = TE13.Text;
                    Califica.Material = TE14.Text;
                    Califica.Partici = TE15.Text;
                    Califica.Comp_Lect = TE16.Text;
                    Califica.Trabajos = TE17.Text;
                    Califica.Tareas = TE18.Text;
                    Califica.Karate = txt16.Text;
                    Califica.Ballet = txt17.Text;
                    Califica.Take = txt18.Text;
                    Califica.Inasistenicias = TE23.Text;

                    int resultado = Modificacion(Califica);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Calificacion Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el la Calificacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    };
                }



                if (TF1.Text == "" || TF2.Text == "" || TF3.Text == "" || TF6.Text == "" || TF7.Text == "" || TF8.Text == ""
                    || TF10.Text == "" || TF11.Text == "" || TF12.Text == "" || TF13.Text == "" || TF14.Text == "" ||
                    TF15.Text == "" || TF16.Text == "" || TF17.Text == "" || TF18.Text == "" || TF23.Text == "")
                {
                    MessageBox.Show("UN CAMPO ESTA VACIO, DEBE DE LLENARLO ANTES DE CONTINUAR", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Califica.Curp = txtbuscador.Text;
                    Califica.Mes = "FEBRERO";
                    Califica.Grado = txtgrado.Text;

                    Califica.Español = TF1.Text;
                    Califica.Matematicas = TF2.Text;
                    Califica.Nat_y_Soc = TF3.Text;
                    Califica.Civica = TF4.Text;
                    Califica.Ed_Fisica = TF5.Text;
                    Califica.Ed_Artistica = TF6.Text;
                    Califica.Computacion = TF7.Text;
                    Califica.Ingles = TF8.Text;

                    Califica.Ortografia = TF10.Text;
                    Califica.Disciplina = TF11.Text;
                    Califica.Uniforme = TF12.Text;
                    Califica.Puntualidad = TF13.Text;
                    Califica.Material = TF14.Text;
                    Califica.Partici = TF15.Text;
                    Califica.Comp_Lect = TF16.Text;
                    Califica.Trabajos = TF17.Text;
                    Califica.Tareas = TF18.Text;
                    Califica.Karate = textBox31.Text;
                    Califica.Ballet = textBox32.Text;
                    Califica.Take = textBox33.Text;
                    Califica.Inasistenicias = TF23.Text;

                    int resultado = Modificacion(Califica);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Calificacion Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el la Calificacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    };
                }



                if (TM1.Text == "" || TM2.Text == "" || TM3.Text == "" || TM6.Text == "" || TM7.Text == "" || TM8.Text == "" ||
                     TM10.Text == "" || TM11.Text == "" || TM12.Text == "" || TM13.Text == "" || TM14.Text == "" ||
                    TM15.Text == "" || TM16.Text == "" || TM17.Text == "" || TM18.Text == "" || TM23.Text == "")
                {
                    MessageBox.Show("UN CAMPO ESTA VACIO, DEBE DE LLENARLO ANTES DE CONTINUAR", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Califica.Curp = txtbuscador.Text;
                    Califica.Mes = "MARZO";
                    Califica.Grado = txtgrado.Text;

                    Califica.Español = TM1.Text;
                    Califica.Matematicas = TM2.Text;
                    Califica.Nat_y_Soc = TM3.Text;
                    Califica.Civica = TM4.Text;
                    Califica.Ed_Fisica = TM5.Text;
                    Califica.Ed_Artistica = TM6.Text;
                    Califica.Computacion = TM7.Text;
                    Califica.Ingles = TM8.Text;

                    Califica.Ortografia = TM10.Text;
                    Califica.Disciplina = TM11.Text;
                    Califica.Uniforme = TM12.Text;
                    Califica.Puntualidad = TM13.Text;
                    Califica.Material = TM14.Text;
                    Califica.Partici = TM15.Text;
                    Califica.Comp_Lect = TM16.Text;
                    Califica.Trabajos = TM17.Text;
                    Califica.Tareas = TM18.Text;
                    Califica.Karate = textBox28.Text;
                    Califica.Ballet = textBox29.Text;
                    Califica.Take = textBox30.Text;
                    Califica.Inasistenicias = TM23.Text;

                    int resultado = Modificacion(Califica);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Calificacion Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el la Calificacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    };
                }



                if (TA1.Text == "" || TA2.Text == "" || TA3.Text == "" || TA6.Text == "" || TA7.Text == "" || TA8.Text == ""
                    || TA10.Text == "" || TA11.Text == "" || TA12.Text == "" || TA13.Text == "" || TA14.Text == "" ||
                    TA15.Text == "" || TA16.Text == "" || TA17.Text == "" || TA18.Text == "" || TA23.Text == "")
                {
                    MessageBox.Show("UN CAMPO ESTA VACIO, DEBE DE LLENARLO ANTES DE CONTINUAR", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Califica.Curp = txtbuscador.Text;
                    Califica.Mes = "ABRIL";
                    Califica.Grado = txtgrado.Text;

                    Califica.Español = TA1.Text;
                    Califica.Matematicas = TA2.Text;
                    Califica.Nat_y_Soc = TA3.Text;
                    Califica.Civica = TA4.Text;
                    Califica.Ed_Fisica = TA5.Text;
                    Califica.Ed_Artistica = TA6.Text;
                    Califica.Computacion = TA7.Text;
                    Califica.Ingles = TA8.Text;

                    Califica.Ortografia = TA10.Text;
                    Califica.Disciplina = TA11.Text;
                    Califica.Uniforme = TA12.Text;
                    Califica.Puntualidad = TA13.Text;
                    Califica.Material = TA14.Text;
                    Califica.Partici = TA15.Text;
                    Califica.Comp_Lect = TA16.Text;
                    Califica.Trabajos = TA17.Text;
                    Califica.Tareas = TA18.Text;
                    Califica.Karate = textBox25.Text;
                    Califica.Ballet = textBox26.Text;
                    Califica.Take = textBox27.Text;
                    Califica.Inasistenicias = TA23.Text;

                    int resultado = Modificacion(Califica);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Calificacion Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el la Calificacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    };
                }


                if (TMA1.Text == "" || TMA2.Text == "" || TMA3.Text == "" || TMA6.Text == "" || TMA7.Text == "" || TMA8.Text == ""
                     || TMA10.Text == "" || TMA11.Text == "" || TMA12.Text == "" || TMA13.Text == "" || TMA14.Text == "" ||
                    TMA15.Text == "" || TMA16.Text == "" || TMA17.Text == "" || TMA18.Text == "" || TMA23.Text == "")
                {
                    MessageBox.Show("UN CAMPO ESTA VACIO, DEBE DE LLENARLO ANTES DE CONTINUAR", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Califica.Curp = txtbuscador.Text;
                    Califica.Mes = "MAYO";
                    Califica.Grado = txtgrado.Text;

                    Califica.Español = TMA1.Text;
                    Califica.Matematicas = TMA2.Text;
                    Califica.Nat_y_Soc = TMA3.Text;
                    Califica.Civica = TMA4.Text;
                    Califica.Ed_Fisica = TMA5.Text;
                    Califica.Ed_Artistica = TMA6.Text;
                    Califica.Computacion = TMA7.Text;
                    Califica.Ingles = TMA8.Text;

                    Califica.Ortografia = TMA10.Text;
                    Califica.Disciplina = TMA11.Text;
                    Califica.Uniforme = TMA12.Text;
                    Califica.Puntualidad = TMA13.Text;
                    Califica.Material = TMA14.Text;
                    Califica.Partici = TMA15.Text;
                    Califica.Comp_Lect = TMA16.Text;
                    Califica.Trabajos = TMA17.Text;
                    Califica.Tareas = TMA18.Text;
                    Califica.Karate = textBox22.Text;
                    Califica.Ballet = textBox23.Text;
                    Califica.Take = textBox24.Text;
                    Califica.Inasistenicias = TMA23.Text;


                    int resultado = Modificacion(Califica);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Calificacion GuardadA!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar la Calificacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    };
                }


                if (TJ1.Text == "" || TJ2.Text == "" || TJ3.Text == "" || TJ6.Text == "" || TJ7.Text == "" || TJ8.Text == ""
                   || TJ10.Text == "" || TJ11.Text == "" || TJ12.Text == "" || TJ13.Text == "" || TJ14.Text == "" ||
                    TJ15.Text == "" || TJ16.Text == "" || TJ17.Text == "" || TJ18.Text == "" || TJ23.Text == "")
                {
                    MessageBox.Show("UN CAMPO ESTA VACIO, DEBE DE LLENARLO y CONTINUAR", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Califica.Curp = txtbuscador.Text;
                    Califica.Mes = "JUNIO";
                    Califica.Grado = txtgrado.Text;

                    Califica.Español = TJ1.Text;
                    Califica.Matematicas = TJ2.Text;
                    Califica.Nat_y_Soc = TJ3.Text;
                    Califica.Civica = TJ4.Text;
                    Califica.Ed_Fisica = TJ5.Text;
                    Califica.Ed_Artistica = TJ6.Text;
                    Califica.Computacion = TJ7.Text;
                    Califica.Ingles = TJ8.Text;

                    Califica.Ortografia = TJ10.Text;
                    Califica.Disciplina = TJ11.Text;
                    Califica.Uniforme = TJ12.Text;
                    Califica.Puntualidad = TJ13.Text;
                    Califica.Material = TJ14.Text;
                    Califica.Partici = TJ15.Text;
                    Califica.Comp_Lect = TJ16.Text;
                    Califica.Trabajos = TJ17.Text;
                    Califica.Tareas = TJ18.Text;
                    Califica.Karate = textBox19.Text;
                    Califica.Ballet = textBox20.Text;
                    Califica.Take = textBox21.Text;
                    Califica.Inasistenicias = TJ23.Text;

                    int resultado = Registro.Modificacion(Califica);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Calificacion Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el la Calificacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    };
                }
            }
        }

        private void txtbuscador_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            btnEnviar.Visible = false;
            BtnBuscar.Visible = false;
            BtnGuardar.Visible = false;
            button2.Visible = false;
            button1.Visible = false;
            label6.Visible = false;
            CBMes.Visible = false;
            txtbuscador.Visible = false;
            label1.Visible = false;
            txtCorreo.Visible = false;


            SqlConnection conexion = conection.obtenerConexion();
            //String stConection;
            String stConsulta3;
            //stConection = "Server=ANGELHDZS; DataBase=Control_Escolar1; integrated Security=true";
            //conexion.ConnectionString = stConection;
            //conexion.Open();
            stConsulta3 = "SELECT correo FROM Tutor where Curp = '" + txtbuscador.Text + "'";
            SqlCommand ConsultaCorreo = new SqlCommand();
            ConsultaCorreo.Connection = conexion;
            ConsultaCorreo.CommandText = stConsulta3;
            SqlDataReader Control = ConsultaCorreo.ExecuteReader();

            if (Control.HasRows)
            {
                Control.Read();
                txtCorreo.Text = Control["Correo"].ToString();
            }

            conexion.Close();

            // Para llenar lo del correo
            To = txtCorreo.Text;
            Subject = "Boleta Mensual";
            Body = "ENTREGA DE BOLETA DEL MES";

            SaveFileDialog filename = new SaveFileDialog();
            filename.Filter = "Imagen jpeg|*.jpeg";
            filename.FileName = txtbuscador.Text;
            if (filename.FileName != "")
            {
                Graphics g1 = this.CreateGraphics();
                System.Drawing.Image MyImage = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height, g1);
                Graphics g2 = Graphics.FromImage(MyImage);
                IntPtr dc1 = g1.GetHdc();
                IntPtr dc2 = g2.GetHdc();
                BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
                g1.ReleaseHdc(dc1);
                g2.ReleaseHdc(dc2);

                FileStream fileStream = new FileStream(filename.FileName, FileMode.Create, FileAccess.Write);
                MyImage.Save(fileStream, System.Drawing.Imaging.ImageFormat.Jpeg);

                fileStream.Close();
                MyImage.Dispose();

                //Una vez obtenida la imagen la convertimos en PDF   (Estas coordenas son iguales al tamaño del formulario)
                var pgSize = new iTextSharp.text.Rectangle(800, 790);
                Document document = new Document(pgSize, 10, 10, 10, 10);
                //Guardamos el archivo en pdf con un nombre predefinido
                string GuardarComo = @"C:\Users\Dreamer\Documents\BOLETAS\" + txtbuscador.Text + ".pdf";
                using (var stream = new FileStream(GuardarComo, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    PdfWriter.GetInstance(document, stream);
                    document.Open();
                    using (var imageStream = new FileStream(filename.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        var image = iTextSharp.text.Image.GetInstance(imageStream);
                        document.Add(image);
                    }
                    document.Close();
                    EnviarCorreo();
                }

            }
            btnEnviar.Visible = true;
            BtnBuscar.Visible = true;
            BtnGuardar.Visible = true;
            button2.Visible = true;
            button1.Visible = true;
            label6.Visible = true;
            CBMes.Visible = true;
            txtbuscador.Visible = true;
            label1.Visible = true;
            txtCorreo.Visible = true;
        }
        private void EnviarCorreo()
        {

            mail = new MailMessage();
            mail.To.Add(new MailAddress(this.To));
            mail.From = new MailAddress("oxuan-psv97@hotmail.com");
            mail.Subject = Subject;
            mail.Body = Body;
            mail.IsBodyHtml = false;

            Data = new Attachment(@"C:\Users\Dreamer\Documents\BOLETAS\" + txtbuscador.Text + ".pdf", MediaTypeNames.Application.Pdf);

            mail.Attachments.Add(Data);

            SmtpClient client = new SmtpClient("smtp.live.com", 587);
            using (client)
            {
                client.Credentials = new System.Net.NetworkCredential("oxuan-psv97@hotmail.com", "suastegui");
                client.EnableSsl = true;
                client.Send(mail);
            }
            MessageBox.Show("Mensaje enviado Correctamente");
        }

        private void CapturaFormulario()
        {

            Graphics mygraphics = this.CreateGraphics();
            Size sz = this.ClientRectangle.Size;
            bmp = new Bitmap(sz.Width, sz.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(bmp);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width,
            this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest,
            int nXDest,
            int nYDest,
            int nWidth,
            int nHeight,
            IntPtr hdcSrc,
            int nXSrc,
            int nYSrc,
            int dwRop);

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BOLETA_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            trons.Curp = txtbuscador.Text;
            trons.tipobimes = "PROM GENERAL";

            trons.Español = P1.Text;
            trons.Matematicas = P2.Text;
            trons.Nat_y_Soc = P3.Text;
            trons.Civica = P4.Text;
            trons.Ed_Fisica = P5.Text;
            trons.Ed_Artistica = P6.Text;
            trons.Computacion = P7.Text;
            trons.Ingles = P8.Text;

            trons.Ortografia = P10.Text;
            trons.Disciplina = P11.Text;
            trons.Uniforme = P12.Text;
            trons.Puntualidad = P13.Text;
            trons.Material = P14.Text;
            trons.Partici = P15.Text;
            trons.Comp_Lect = P16.Text;
            trons.Trabajos = P17.Text;
            trons.Tareas = P18.Text;
            trons.Karate = textBox1.Text;
            trons.Ballet = textBox2.Text;
            trons.Take = textBox3.Text;
            trons.Inasistenicias = P23.Text;
            trons.prosep = P9.Text;
            trons.promcom = P19.Text;
            trons.promgen = P20.Text;
            trons.puntos = P21.Text;
            int re = Registro.Calificacion(trons);

        }

        private void TxBClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxBCicloEsc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




