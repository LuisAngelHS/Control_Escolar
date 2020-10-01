using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_ESCUELA
{
    public partial class llamado_listas : Form
    {

        public llamado_listas()
        {
            InitializeComponent();
        }

        private listasEscolares   modify = null;
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
        void form_Disposede(object sender, EventArgs e)
        {
            modify = null;
        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            listasEscolares frm = this.FormInstances;

            if (Cmb_grupo.Text == "Seleccione el grupo")
            {
                MessageBox.Show("No se ha seleccionado ningun grado", "◄ AVISO |  Sistema de Control Escolar ►", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               

                frm.grado = Convert.ToString(Cmb_grupo.Text);


                if (txtruta.Text == "Nombre del archivo")
                {
                    MessageBox.Show("El campo nombre no puede estar vacio", "◄ AVISO |  Sistema de Control Escolar ►", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtruta.BorderColorIdle = Color.Red;
                }
                else
                {
                    // se verifica si el formulario no esta minimizado, en caso de estarlo
                    // se lo cambia a un estado normal
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

                    Warning[] warnings;
                    string[] streamids;
                    string mimeType;
                    string encoding;
                    string extension;

                    byte[] bytes = frm.reportViewer1.LocalReport.Render(
                     "EXCEL", null, out mimeType, out encoding,
                     out extension,
                     out streamids, out warnings);

                    FileStream fs = new FileStream(@"C:\Users\Dreamer\Documents\BOLETAS\" + txtruta.Text + ".xls",
                    FileMode.Create);
                    fs.Write(bytes, 0, bytes.Length);
                    fs.Close();
                    //frm.Close();
                    MessageBox.Show("Lista creada y guarda con exito", " AVISO | CONTROL ESCOLAR ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void llamado_listas_Load(object sender, EventArgs e)
        {

        }

        private void Cmb_grupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtruta_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
