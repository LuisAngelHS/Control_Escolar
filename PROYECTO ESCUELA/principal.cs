using System;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PROYECTO_ESCUELA
{
    public partial class principal : Form
    {
        public principal()
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


        private listasEscolares modify = null;
        private listasEscolares FormInstances
        {
            get
            {
                if (modify == null)
                {
                    modify = new listasEscolares();
                    modify.Disposed += new EventHandler(form_Disposede);
                }
                return modify;
            }
        }

        private ListasMensuales m = null;
        private ListasMensuales Formi
        {
            get
            {
                if (m == null)
                {
                    m = new ListasMensuales();
                    m.Disposed += new EventHandler(form_Disposede);
                }
                return m;
            }
        }


        void form_Disposede(object sender, EventArgs e)
        {
            modify = null;
        }

        private listas3A modi = null;
        private listas3A Forminstanc
        {
            get
            {
                if (modi == null)
                {
                    modi = new listas3A();
                    modi.Disposed += new EventHandler(form_Disposede);
                }
                return modi;
            }
        }

        private listas4_6 mod = null;
        private listas4_6 Forminstan
        {
            get
            {
                if (mod == null)
                {
                    mod = new listas4_6();
                    mod.Disposed += new EventHandler(form_Disposede);
                }
                return mod;
            }
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void barraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonmenu_Click(object sender, EventArgs e)
        {
            if (menu_vertical.Width == 238)
            {
                menu_vertical.Width = 70;
            }
            else
                menu_vertical.Width = 238;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void AbrirFormInPanel(object Formhijo)
        {
            if (this.contenedor.Controls.Count > 0)
                this.contenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.contenedor.Controls.Add(fh);
            this.contenedor.Tag = fh;
            fh.Show();
        }
        private void bT_ALUMNO_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new AgregarAlumno());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Grupos());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            llamado_listas nom = new llamado_listas();
            nom.Show();
        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_vertical_Paint(object sender, PaintEventArgs e)
        {
            //listasEscolares frm = new listasEscolares();
            //frm.grado = Convert.ToInt32(txt_listas.Text);
            //AbrirFormInPanel(new listasEscolares());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tx_direc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tx_direc.Text == "1°A")
            {
                DIRECTORIOS1_6 nom = new DIRECTORIOS1_6();
                nom.Show();
            }
            if (tx_direc.Text == "2°A")
            {
                DIRECTORIOS2_6 nom = new DIRECTORIOS2_6();
                nom.Show();
            }
            if (tx_direc.Text=="3°A") 
            {
                DIRECTORIO3_6 nom = new DIRECTORIO3_6();
                nom.Show();
            }
            if (tx_direc.Text == "4°A")
            {
                DIRECTORIO4_6 nom = new DIRECTORIO4_6();
                nom.Show();
            }
            if (tx_direc.Text == "5°A")
            {
                DIRECTORIO5_6 nom = new DIRECTORIO5_6();
                nom.Show();
            }
            if (tx_direc.Text == "6°A")
            {
                DIRECTORIO6_6 nom = new DIRECTORIO6_6();
                nom.Show();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            BOLETA nom = new BOLETA();
            nom.Show();
        }

        private void txt_listas_SelectedIndexChanged(object sender, EventArgs e)
        {
            llamado_listas nom = new  llamado_listas();
            nom.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         listasB  nom = new listasB();
            nom.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Estadisticas());
        }

        private void principal_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            llam_calificaciones nom = new llam_calificaciones();
            nom.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Estadisticas());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new archivos());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tx_listas_TextChanged(object sender, EventArgs e)
        {
            if (tx_listas.Text == "1°A")
            {
                listasEscolares frm = this.FormInstances;
                frm.grado = Convert.ToString(tx_listas.Text);
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
            if (tx_listas.Text == "2°A")
            {
                listasEscolares frm = this.FormInstances;
                frm.grado = Convert.ToString(tx_listas.Text);
                if(frm.WindowState == FormWindowState.Minimized)
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
                //listasEscolares nom = new listasEscolares();
                //nom.Show();
            }
            if (tx_listas.Text == "3°A")
            {
                listas3A frm = this.Forminstanc;
                frm.grado = Convert.ToString(tx_listas.Text);
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
            if (tx_listas.Text == "4°A")
            {
               listas4_6 frm = this.Forminstan;
                frm.grado = Convert.ToString(tx_listas.Text);
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
            if (tx_listas.Text == "5°A")
            {
                listas4_6 frm = this.Forminstan;
                frm.grado = Convert.ToString(tx_listas.Text);
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
            if (tx_listas.Text == "6°A")
            {
                listas4_6 frm = this.Forminstan;
                frm.grado = Convert.ToString(tx_listas.Text);
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
        private void tx_listas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            generador nom = new generador();
            nom.Show();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (txlista.Text == "1°A")
            {
               ListasMensuales frm = this.Formi;
                frm.grado = Convert.ToString(txlista.Text);
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
            if (txlista.Text == "2°A")
            {
                ListasMensuales frm1 = this.Formi;
                frm1.grado = Convert.ToString(txlista.Text);
                if (frm1.WindowState == FormWindowState.Minimized)
                    frm1.WindowState = FormWindowState.Normal;
                AddOwnedForm(frm1);
                frm1.FormBorderStyle = FormBorderStyle.FixedSingle;
                //frm.TopLevel = false;
                frm1.StartPosition = FormStartPosition.CenterScreen;
                //frm.Dock = DockStyle.Fill;
                //this.Controls.Add(frm);
                this.Tag = frm1;
                frm1.BringToFront();
                frm1.Enabled = true;
                //frm1.Visible = true;
                frm1.Show();
                //listasEscolares nom = new listasEscolares();
                //nom.Show();
            }
            if (txlista.Text == "3°A")
            {
                listas3A frm = this.Forminstanc;
                frm.grado = Convert.ToString(txlista.Text);
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
            if (txlista.Text == "4°A")
            {
                listas4_6 frm = this.Forminstan;
                frm.grado = Convert.ToString(txlista.Text);
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
            if (txlista.Text == "5°A")
            {
                listas4_6 frm = this.Forminstan;
                frm.grado = Convert.ToString(txlista.Text);
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
            if (txlista.Text == "6°A")
            {
                listas4_6 frm = this.Forminstan;
                frm.grado = Convert.ToString(txlista.Text);
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
