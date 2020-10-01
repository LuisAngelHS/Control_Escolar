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
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.TOTALH' Puede moverla o quitarla según sea necesario.
            this.TOTALHTableAdapter.Fill(this.Control_Escolar1DataSet.TOTALH);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.TOTAL' Puede moverla o quitarla según sea necesario.
            this.TOTALTableAdapter.Fill(this.Control_Escolar1DataSet.TOTAL);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.TOGRADO' Puede moverla o quitarla según sea necesario.
            this.TOGRADOTableAdapter.Fill(this.Control_Escolar1DataSet.TOGRADO);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.esta6AH' Puede moverla o quitarla según sea necesario.
            this.esta6AHTableAdapter.Fill(this.Control_Escolar1DataSet.esta6AH);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.esta6AM' Puede moverla o quitarla según sea necesario.
            this.esta6AMTableAdapter.Fill(this.Control_Escolar1DataSet.esta6AM);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.suma6A' Puede moverla o quitarla según sea necesario.
            this.suma6ATableAdapter.Fill(this.Control_Escolar1DataSet.suma6A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.esta5AH' Puede moverla o quitarla según sea necesario.
            this.esta5AHTableAdapter.Fill(this.Control_Escolar1DataSet.esta5AH);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.esta5AM' Puede moverla o quitarla según sea necesario.
            this.esta5AMTableAdapter.Fill(this.Control_Escolar1DataSet.esta5AM);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.suma5A' Puede moverla o quitarla según sea necesario.
            this.suma5ATableAdapter.Fill(this.Control_Escolar1DataSet.suma5A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.esta4AH' Puede moverla o quitarla según sea necesario.
            this.esta4AHTableAdapter.Fill(this.Control_Escolar1DataSet.esta4AH);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.esta4AM' Puede moverla o quitarla según sea necesario.
            this.esta4AMTableAdapter.Fill(this.Control_Escolar1DataSet.esta4AM);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.suma4A' Puede moverla o quitarla según sea necesario.
            this.suma4ATableAdapter.Fill(this.Control_Escolar1DataSet.suma4A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.esta3AHS' Puede moverla o quitarla según sea necesario.
            this.esta3AHSTableAdapter.Fill(this.Control_Escolar1DataSet.esta3AHS);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.esta3AMS' Puede moverla o quitarla según sea necesario.
            this.esta3AMSTableAdapter.Fill(this.Control_Escolar1DataSet.esta3AMS);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.suma3AS' Puede moverla o quitarla según sea necesario.
            this.suma3ASTableAdapter.Fill(this.Control_Escolar1DataSet.suma3AS);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.esta2AM' Puede moverla o quitarla según sea necesario.
            this.esta2AMTableAdapter.Fill(this.Control_Escolar1DataSet.esta2AM);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.suma2A' Puede moverla o quitarla según sea necesario.
            this.suma2ATableAdapter.Fill(this.Control_Escolar1DataSet.suma2A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.esta2AH' Puede moverla o quitarla según sea necesario.
            this.esta2AHTableAdapter.Fill(this.Control_Escolar1DataSet.esta2AH);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.fastasma1' Puede moverla o quitarla según sea necesario.
            this.fastasma1TableAdapter.Fill(this.Control_Escolar1DataSet.fastasma1);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.esta1AH' Puede moverla o quitarla según sea necesario.
            this.esta1AHTableAdapter.Fill(this.Control_Escolar1DataSet.esta1AH);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.esta1AM' Puede moverla o quitarla según sea necesario.
            this.esta1AMTableAdapter.Fill(this.Control_Escolar1DataSet.esta1AM);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.suma1A' Puede moverla o quitarla según sea necesario.
            this.suma1ATableAdapter.Fill(this.Control_Escolar1DataSet.suma1A);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
