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
    public partial class listasEscolares : Form
    {
        public listasEscolares()
        {
            InitializeComponent();
        }
        public string grado { get; set; }

        private void listasEscolares_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.fantas2' Puede moverla o quitarla según sea necesario.
            this.fantas2TableAdapter.Fill(this.Control_Escolar1DataSet.fantas2);

            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.fastasma1' Puede moverla o quitarla según sea necesario.
            this.fastasma1TableAdapter.Fill(this.Control_Escolar1DataSet.fastasma1);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.listasgrado1' Puede moverla o quitarla según sea necesario.
            this.listasgrado1TableAdapter.Fill(this.Control_Escolar1DataSet.listasgrado1,grado);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.gradoes' Puede moverla o quitarla según sea necesario.
            this.gradoesTableAdapter.Fill(this.Control_Escolar1DataSet.gradoes,grado);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.fastasma' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.listassexo' Puede moverla o quitarla según sea necesario.
            this.listassexoTableAdapter.Fill(this.Control_Escolar1DataSet.listassexo,Convert.ToString(grado));
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.listasgrado' Puede moverla o quitarla según sea necesario.
        

            
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_2(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_3(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_4(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_5(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_6(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_7(object sender, EventArgs e)
        {

        }
    }
}
