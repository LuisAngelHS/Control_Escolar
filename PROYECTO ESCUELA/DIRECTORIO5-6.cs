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
    public partial class DIRECTORIO5_6 : Form
    {
        public DIRECTORIO5_6()
        {
            InitializeComponent();
        }

        private void DIRECTORIO5_6_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.fantas2' Puede moverla o quitarla según sea necesario.
            this.fantas2TableAdapter.Fill(this.Control_Escolar1DataSet.fantas2);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.fastasma' Puede moverla o quitarla según sea necesario.
            this.fastasmaTableAdapter.Fill(this.Control_Escolar1DataSet.fastasma);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.grado5A' Puede moverla o quitarla según sea necesario.
            this.grado5ATableAdapter.Fill(this.Control_Escolar1DataSet.grado5A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.NOMBALUMDIRECT5A' Puede moverla o quitarla según sea necesario.
            this.NOMBALUMDIRECT5ATableAdapter.Fill(this.Control_Escolar1DataSet.NOMBALUMDIRECT5A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.FECHADIRECT5A' Puede moverla o quitarla según sea necesario.
            this.FECHADIRECT5ATableAdapter.Fill(this.Control_Escolar1DataSet.FECHADIRECT5A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.CURPDIRECT5A' Puede moverla o quitarla según sea necesario.
            this.CURPDIRECT5ATableAdapter.Fill(this.Control_Escolar1DataSet.CURPDIRECT5A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.DIREC_DIRECTORIO5A' Puede moverla o quitarla según sea necesario.
            this.DIREC_DIRECTORIO5ATableAdapter.Fill(this.Control_Escolar1DataSet.DIREC_DIRECTORIO5A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.TELEF_DIREC5A' Puede moverla o quitarla según sea necesario.
            this.TELEF_DIREC5ATableAdapter.Fill(this.Control_Escolar1DataSet.TELEF_DIREC5A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.TUTOR_DIRECT5A' Puede moverla o quitarla según sea necesario.
            this.TUTOR_DIRECT5ATableAdapter.Fill(this.Control_Escolar1DataSet.TUTOR_DIRECT5A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.ALERG_DIRECT5A' Puede moverla o quitarla según sea necesario.
            this.ALERG_DIRECT5ATableAdapter.Fill(this.Control_Escolar1DataSet.ALERG_DIRECT5A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.SANGRE_DIRECT5A' Puede moverla o quitarla según sea necesario.
            this.SANGRE_DIRECT5ATableAdapter.Fill(this.Control_Escolar1DataSet.SANGRE_DIRECT5A);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
