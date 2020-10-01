using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using PROYECTO_ESCUELA;

namespace PROYECTO_ESCUELA
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

    private void button1_Click(object sender, EventArgs e)
        {
            clasUsuario1 objUser = new clasUsuario1();
            SqlDataReader Loguear;
            objUser._Usuario = tx_user.Text;
            objUser._Contraseña = tx_contrase.Text;
            //Loguear = objUser.iniciarsesion();
            if (objUser._Usuario == tx_user.Text)
            {
                lbuser.Visible = false;
                if (objUser._Contraseña == tx_contrase.Text)
                {
                    lbpass.Visible = true;
                    Loguear = objUser.iniciarsesion();

                    if (Loguear.Read() == true)
                    {
                        this.Hide();
                        principal iniciando = new principal ();
                        Program.perfil = Loguear["Perfil"].ToString();
                        iniciando.Show();
                    }
                    else
                    {
                        lblogin.Text = "Usuario o contraseña invalidos, intente de nuevo";
                        lblogin.Visible = true;
                        tx_contrase.Text = "";
                        tx_contrase_Leave(null, e);
                        tx_user.Focus();
                    }
                }
                else
                {
                    lbpass.Text = objUser._Contraseña;
                    lbpass.Visible = true;
                }
            }
            else
            {
                lbuser.Text = objUser._Usuario;
                lbuser.Visible = true;
            }




        }

        private void tx_user_Enter(object sender, EventArgs e)
        {
            if (tx_user.Text == "NombreUsuario")
            {
                tx_user.Text = "";
                tx_user.ForeColor = Color.Black;
            }
        }

        private void tx_user_Leave(object sender, EventArgs e)
        {
            if (tx_user.Text == "")
            {
                tx_user.Text = "USUARIO";
                tx_user.ForeColor = Color.Gray;
            }
        }

        private void tx_contrase_Leave(object sender, EventArgs e)
        {
            if (tx_contrase.Text == "")
            {
                tx_contrase.Text = "CONTRASEÑA";
                tx_contrase.ForeColor = Color.Gray;
                //tx_contrase.= false;
            }
        }

        private void lbuser_Click(object sender, EventArgs e)
        {

        }
    }
}
