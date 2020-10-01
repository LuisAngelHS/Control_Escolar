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
    public partial class DIRECTORIO3_6 : Form
    {
        public DIRECTORIO3_6()
        {
            InitializeComponent();
        }

        private void DIRECTORIO3_6_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.fantas2' Puede moverla o quitarla según sea necesario.
            this.fantas2TableAdapter.Fill(this.Control_Escolar1DataSet.fantas2);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.fastasma' Puede moverla o quitarla según sea necesario.
            this.fastasmaTableAdapter.Fill(this.Control_Escolar1DataSet.fastasma);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.grado3A' Puede moverla o quitarla según sea necesario.
            this.grado3ATableAdapter.Fill(this.Control_Escolar1DataSet.grado3A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.NOMBALUMDIRECT3A' Puede moverla o quitarla según sea necesario.
            this.NOMBALUMDIRECT3ATableAdapter.Fill(this.Control_Escolar1DataSet.NOMBALUMDIRECT3A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.CURPDIRECT3A' Puede moverla o quitarla según sea necesario.
            this.CURPDIRECT3ATableAdapter.Fill(this.Control_Escolar1DataSet.CURPDIRECT3A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.FECHADIRECT3A' Puede moverla o quitarla según sea necesario.
            this.FECHADIRECT3ATableAdapter.Fill(this.Control_Escolar1DataSet.FECHADIRECT3A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.DIREC_DIRECTORIO3A' Puede moverla o quitarla según sea necesario.
            this.DIREC_DIRECTORIO3ATableAdapter.Fill(this.Control_Escolar1DataSet.DIREC_DIRECTORIO3A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.TELEF_DIREC3A' Puede moverla o quitarla según sea necesario.
            this.TELEF_DIREC3ATableAdapter.Fill(this.Control_Escolar1DataSet.TELEF_DIREC3A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.ALERG_DIRECT3A' Puede moverla o quitarla según sea necesario.
            this.ALERG_DIRECT3ATableAdapter.Fill(this.Control_Escolar1DataSet.ALERG_DIRECT3A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.TUTOR_DIRECT3A' Puede moverla o quitarla según sea necesario.
            this.TUTOR_DIRECT3ATableAdapter.Fill(this.Control_Escolar1DataSet.TUTOR_DIRECT3A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.SANGRE_DIRECT3A' Puede moverla o quitarla según sea necesario.
            this.SANGRE_DIRECT3ATableAdapter.Fill(this.Control_Escolar1DataSet.SANGRE_DIRECT3A);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
