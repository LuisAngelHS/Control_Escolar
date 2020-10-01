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
    public partial class DIRECTORIO4_6 : Form
    {
        public DIRECTORIO4_6()
        {
            InitializeComponent();
        }

        private void DIRECTORIO4_6_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.fantas2' Puede moverla o quitarla según sea necesario.
            this.fantas2TableAdapter.Fill(this.Control_Escolar1DataSet.fantas2);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.fastasma' Puede moverla o quitarla según sea necesario.
            this.fastasmaTableAdapter.Fill(this.Control_Escolar1DataSet.fastasma);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.grado4A' Puede moverla o quitarla según sea necesario.
            this.grado4ATableAdapter.Fill(this.Control_Escolar1DataSet.grado4A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.NOMBALUMDIRECT4A' Puede moverla o quitarla según sea necesario.
            this.NOMBALUMDIRECT4ATableAdapter.Fill(this.Control_Escolar1DataSet.NOMBALUMDIRECT4A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.FECHADIRECT4A' Puede moverla o quitarla según sea necesario.
            this.FECHADIRECT4ATableAdapter.Fill(this.Control_Escolar1DataSet.FECHADIRECT4A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.CURPDIRECT4A' Puede moverla o quitarla según sea necesario.
            this.CURPDIRECT4ATableAdapter.Fill(this.Control_Escolar1DataSet.CURPDIRECT4A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.DIREC_DIRECTORIO4A' Puede moverla o quitarla según sea necesario.
            this.DIREC_DIRECTORIO4ATableAdapter.Fill(this.Control_Escolar1DataSet.DIREC_DIRECTORIO4A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.TELEF_DIREC4A' Puede moverla o quitarla según sea necesario.
            this.TELEF_DIREC4ATableAdapter.Fill(this.Control_Escolar1DataSet.TELEF_DIREC4A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.TUTOR_DIRECT4A' Puede moverla o quitarla según sea necesario.
            this.TUTOR_DIRECT4ATableAdapter.Fill(this.Control_Escolar1DataSet.TUTOR_DIRECT4A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.ALERG_DIRECT4A' Puede moverla o quitarla según sea necesario.
            this.ALERG_DIRECT4ATableAdapter.Fill(this.Control_Escolar1DataSet.ALERG_DIRECT4A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.SANGRE_DIRECT4A' Puede moverla o quitarla según sea necesario.
            this.SANGRE_DIRECT4ATableAdapter.Fill(this.Control_Escolar1DataSet.SANGRE_DIRECT4A);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
