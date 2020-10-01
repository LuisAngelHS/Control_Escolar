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
    public partial class CALIFICACIONES : Form
    {
        public CALIFICACIONES()
        {
            InitializeComponent();
        }
        public string grado { get; set; }

        private void CALIFICACIONES_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.promgene' Puede moverla o quitarla según sea necesario.
            this.promgeneTableAdapter.Fill(this.Control_Escolar1DataSet.promgene);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.FANTASM' Puede moverla o quitarla según sea necesario.
            this.FANTASMTableAdapter.Fill(this.Control_Escolar1DataSet.FANTASM);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.gradoes' Puede moverla o quitarla según sea necesario.
            this.gradoesTableAdapter.Fill(this.Control_Escolar1DataSet.gradoes,grado);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.fastasma' Puede moverla o quitarla según sea necesario.
            this.fastasmaTableAdapter.Fill(this.Control_Escolar1DataSet.fastasma);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.mtral' Puede moverla o quitarla según sea necesario.
            this.mtralTableAdapter.Fill(this.Control_Escolar1DataSet.mtral,grado);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.mater' Puede moverla o quitarla según sea necesario.
            this.materTableAdapter.Fill(this.Control_Escolar1DataSet.mater,grado);

            this.reportViewer1.RefreshReport();
            reportViewer1.ShowExportButton = false;

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
    }
}
