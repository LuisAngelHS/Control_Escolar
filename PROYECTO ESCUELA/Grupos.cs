using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_ESCUELA
{
    public partial class Grupos : Form
    {
        public Grupos()
        {
            InitializeComponent();
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Registro objprod = new Registro();
            datosalum.DataSource = objprod.Listargrupo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro objprod = new Registro();
            datosalum.DataSource = objprod.Listargrupo2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro objprod = new Registro();
           datosalum.DataSource = objprod.Listargrupo3();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registro objprod = new Registro();
            datosalum.DataSource = objprod.Listargrupo4();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Registro objprod = new Registro();
            datosalum.DataSource = objprod.Listargrupo5();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Registro objprod = new Registro();
            datosalum.DataSource = objprod.Listargrupo6();
        }

        private void tx_buscaralum_TextChange(object sender, EventArgs e)
        {
            Registro sql = new Registro();
            if (tx_buscaralum.Text != "")
                datosalum.DataSource = sql.Buscar1(tx_buscaralum.Text);
            else datosalum.DataSource = sql.Listargrupo();
        }

        private void Grupos_Load(object sender, EventArgs e)
        {

        }
    }
}
