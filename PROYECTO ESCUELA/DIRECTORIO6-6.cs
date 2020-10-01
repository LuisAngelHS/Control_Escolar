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
    public partial class DIRECTORIO6_6 : Form
    {
        public DIRECTORIO6_6()
        {
            InitializeComponent();
        }

        private void DIRECTORIO6_6_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.TUTOR_DIRECT6A' Puede moverla o quitarla según sea necesario.
            this.TUTOR_DIRECT6ATableAdapter.Fill(this.Control_Escolar1DataSet.TUTOR_DIRECT6A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.fantas2' Puede moverla o quitarla según sea necesario.
            this.fantas2TableAdapter.Fill(this.Control_Escolar1DataSet.fantas2);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.fastasma' Puede moverla o quitarla según sea necesario.
            this.fastasmaTableAdapter.Fill(this.Control_Escolar1DataSet.fastasma);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.grado6A' Puede moverla o quitarla según sea necesario.
            this.grado6ATableAdapter.Fill(this.Control_Escolar1DataSet.grado6A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.NOMBALUMDIRECT6A' Puede moverla o quitarla según sea necesario.
            this.NOMBALUMDIRECT6ATableAdapter.Fill(this.Control_Escolar1DataSet.NOMBALUMDIRECT6A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.FECHADIRECT6A' Puede moverla o quitarla según sea necesario.
            this.FECHADIRECT6ATableAdapter.Fill(this.Control_Escolar1DataSet.FECHADIRECT6A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.alumno' Puede moverla o quitarla según sea necesario.
            this.alumnoTableAdapter.Fill(this.Control_Escolar1DataSet.alumno);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.CURPDIRECT6A' Puede moverla o quitarla según sea necesario.
            this.CURPDIRECT6ATableAdapter.Fill(this.Control_Escolar1DataSet.CURPDIRECT6A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.DIREC_DIRECTORIO6A' Puede moverla o quitarla según sea necesario.
            this.DIREC_DIRECTORIO6ATableAdapter.Fill(this.Control_Escolar1DataSet.DIREC_DIRECTORIO6A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.TELEF_DIREC6A' Puede moverla o quitarla según sea necesario.
            this.TELEF_DIREC6ATableAdapter.Fill(this.Control_Escolar1DataSet.TELEF_DIREC6A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.ALERG_DIRECT6A' Puede moverla o quitarla según sea necesario.
            this.ALERG_DIRECT6ATableAdapter.Fill(this.Control_Escolar1DataSet.ALERG_DIRECT6A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.SANGRE_DIRECT6A' Puede moverla o quitarla según sea necesario.
            this.SANGRE_DIRECT6ATableAdapter.Fill(this.Control_Escolar1DataSet.SANGRE_DIRECT6A);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
