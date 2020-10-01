using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PROYECTO_ESCUELA
{
    public partial class archivos : Form
    {
        public archivos()
        {
            InitializeComponent();
        }

        private void archivos_Load(object sender, EventArgs e)
        {

        }

        private void bt_examinar_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if(buscar.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = buscar.FileName;
            }
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Abrir_Click(object sender, EventArgs e)
        {
            Process.Start(textBox1.Text);
        }
    }
}   
