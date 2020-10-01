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
using iTextSharp.text; //Para lo del pdf
using iTextSharp.text.pdf;
using System.Net.Mail; //Para lo del correo

namespace PROYECTO_ESCUELA
{
    public partial class DIRECTORIOS2_6 : Form
    {
        public DIRECTORIOS2_6()
        {
            InitializeComponent();
        }

        private void DIRECTORIOS2_6_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.fantas2' Puede moverla o quitarla según sea necesario.
            this.fantas2TableAdapter.Fill(this.Control_Escolar1DataSet.fantas2);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.fastasma' Puede moverla o quitarla según sea necesario.
            this.fastasmaTableAdapter.Fill(this.Control_Escolar1DataSet.fastasma);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.grado2A' Puede moverla o quitarla según sea necesario.
            this.grado2ATableAdapter.Fill(this.Control_Escolar1DataSet.grado2A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.NOMBALUMDIRECT2A' Puede moverla o quitarla según sea necesario.
            this.NOMBALUMDIRECT2ATableAdapter.Fill(this.Control_Escolar1DataSet.NOMBALUMDIRECT2A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.FECHADIRECT2A' Puede moverla o quitarla según sea necesario.
            this.FECHADIRECT2ATableAdapter.Fill(this.Control_Escolar1DataSet.FECHADIRECT2A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.CURPDIRECT2A' Puede moverla o quitarla según sea necesario.
            this.CURPDIRECT2ATableAdapter.Fill(this.Control_Escolar1DataSet.CURPDIRECT2A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.DIREC_DIRECTORIO2A' Puede moverla o quitarla según sea necesario.
            this.DIREC_DIRECTORIO2ATableAdapter.Fill(this.Control_Escolar1DataSet.DIREC_DIRECTORIO2A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.TELEF_DIREC2A' Puede moverla o quitarla según sea necesario.
            this.TELEF_DIREC2ATableAdapter.Fill(this.Control_Escolar1DataSet.TELEF_DIREC2A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.TUTOR_DIRECT2A' Puede moverla o quitarla según sea necesario.
            this.TUTOR_DIRECT2ATableAdapter.Fill(this.Control_Escolar1DataSet.TUTOR_DIRECT2A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.ALERG_DIRECT2A' Puede moverla o quitarla según sea necesario.
            this.ALERG_DIRECT2ATableAdapter.Fill(this.Control_Escolar1DataSet.ALERG_DIRECT2A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.SANGRE_DIRECT2A' Puede moverla o quitarla según sea necesario.
            this.SANGRE_DIRECT2ATableAdapter.Fill(this.Control_Escolar1DataSet.SANGRE_DIRECT2A);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

      
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
