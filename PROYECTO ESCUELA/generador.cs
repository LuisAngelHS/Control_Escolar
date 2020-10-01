using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROYECTO_ESCUELA
{
    public partial class generador : Form
    {
        private conection conexion = new conection();
        private SqlCommand comando = new SqlCommand();
        SqlConnection conectar = new SqlConnection("Server=ANGELHDZS; DataBase=Control_Escolar1; integrated Security=true");
        public generador()
        {
            InitializeComponent();
        }

        private boleta4_6 mo = null;
        private boleta4_6 FormInstance
        {
            get
            {
                if (mo == null)
                {
                    mo = new boleta4_6();
                    mo.Disposed += new EventHandler(form_Disposede);
                }
                return mo;
            }
        }

        private Boleta1_2 moc = null;
        private Boleta1_2 FormInstan
        {
            get
            {
                if (moc == null)
                {
                    moc = new Boleta1_2();
                    moc.Disposed += new EventHandler(form_Disposede);
                }
                return moc;
            }
        }

        private boletas3AS mod = null;
        private boletas3AS FormInstanc
        {
            get
            {
                if (mod == null)
                {
                    mod = new boletas3AS();
                    mod.Disposed += new EventHandler(form_Disposede);
                }
                return mod;
            }
        }
        void form_Disposede(object sender, EventArgs e)
        {
            mo = null;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            comando.Connection = conexion.AbrirConexion();
            SqlCommand cmd = new SqlCommand("buscar2", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Curp", textBox1.Text);
            conectar.Close();
            conectar.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            // SqlDataReader leer = comando.ExecuteReader();

            if (reader.Read())
            {
                gradotxt.Text = Convert.ToString(reader["Grado"]);


                // if (reader.Read() == true)
                {
                    gradotxt.Text = reader["Grado"].ToString();


                    if (gradotxt.Text == "6°A")
                    {                  
                        boleta4_6 frm = this.FormInstance;
                        frm.curp = Convert.ToString(textBox1.Text);
                        if (frm.WindowState == FormWindowState.Minimized)
                            frm.WindowState = FormWindowState.Normal;
                        AddOwnedForm(frm);
                        frm.FormBorderStyle = FormBorderStyle.FixedSingle;
                        //frm.TopLevel = false;
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        //frm.Dock = DockStyle.Fill;
                        //this.Controls.Add(frm);
                        this.Tag = frm;
                        frm.BringToFront();
                        frm.Enabled = true;
                        frm.Visible = true;
                        frm.Show();

                    }
                    if (gradotxt.Text == "2°A")
                    {
                        Boleta1_2 frm = this.FormInstan;
                        frm.curp = Convert.ToString(textBox1.Text);
                        if (frm.WindowState == FormWindowState.Minimized)
                            frm.WindowState = FormWindowState.Normal;
                        AddOwnedForm(frm);
                        frm.FormBorderStyle = FormBorderStyle.FixedSingle;
                        //frm.TopLevel = false;
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        //frm.Dock = DockStyle.Fill;
                        //this.Controls.Add(frm);
                        this.Tag = frm;
                        frm.BringToFront();
                        frm.Enabled = true;
                        frm.Visible = true;
                        frm.Show();
                    }
                    if (gradotxt.Text == "3°A")
                    {
                        boletas3AS frm = this.FormInstanc;
                        frm.curp = Convert.ToString(textBox1.Text);
                        if (frm.WindowState == FormWindowState.Minimized)
                            frm.WindowState = FormWindowState.Normal;
                        AddOwnedForm(frm);
                        frm.FormBorderStyle = FormBorderStyle.FixedSingle;
                        //frm.TopLevel = false;
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        //frm.Dock = DockStyle.Fill;
                        //this.Controls.Add(frm);
                        this.Tag = frm;
                        frm.BringToFront();
                        frm.Enabled = true;
                        frm.Visible = true;
                        frm.Show();
                    }
                    if (gradotxt.Text == "4°A")
                    {
                        boleta4_6 frm = this.FormInstance;
                        frm.curp = Convert.ToString(textBox1.Text);
                        if (frm.WindowState == FormWindowState.Minimized)
                            frm.WindowState = FormWindowState.Normal;
                        AddOwnedForm(frm);
                        frm.FormBorderStyle = FormBorderStyle.FixedSingle;
                        //frm.TopLevel = false;
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        //frm.Dock = DockStyle.Fill;
                        //this.Controls.Add(frm);
                        this.Tag = frm;
                        frm.BringToFront();
                        frm.Enabled = true;
                        frm.Visible = true;
                        frm.Show();
                    }
                    if (gradotxt.Text == "5°A")
                    {
                        boleta4_6 frm = this.FormInstance;
                        frm.curp = Convert.ToString(textBox1.Text);
                        if (frm.WindowState == FormWindowState.Minimized)
                            frm.WindowState = FormWindowState.Normal;
                        AddOwnedForm(frm);
                        frm.FormBorderStyle = FormBorderStyle.FixedSingle;
                        //frm.TopLevel = false;
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        //frm.Dock = DockStyle.Fill;
                        //this.Controls.Add(frm);
                        this.Tag = frm;
                        frm.BringToFront();
                        frm.Enabled = true;
                        frm.Visible = true;
                        frm.Show();
                    }
                    if (gradotxt.Text == "1°A")
                    {
                        Boleta1_2 frm = this.FormInstan;
                        frm.curp = Convert.ToString(textBox1.Text);
                        if (frm.WindowState == FormWindowState.Minimized)
                            frm.WindowState = FormWindowState.Normal;
                        AddOwnedForm(frm);
                        frm.FormBorderStyle = FormBorderStyle.FixedSingle;
                        //frm.TopLevel = false;
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        //frm.Dock = DockStyle.Fill;
                        //this.Controls.Add(frm);
                        this.Tag = frm;
                        frm.BringToFront();
                        frm.Enabled = true;
                        frm.Visible = true;
                        frm.Show();
                    }

                }
            }
        }

        private void gradotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void generador_Load(object sender, EventArgs e)
        {

        }
    }

    }

