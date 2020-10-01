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
    public partial class boletas3AS : Form
    {
        public boletas3AS()
        {
            InitializeComponent();
        }
        public string curp { get; set; }
        private void boletas3AS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.NOMBREfre' Puede moverla o quitarla según sea necesario.
            this.NOMBREfreTableAdapter.Fill(this.Control_Escolar1DataSet.NOMBREfre,curp);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.Diagnost' Puede moverla o quitarla según sea necesario.
            this.DiagnostTableAdapter.Fill(this.Control_Escolar1DataSet.Diagnost,curp);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.Septiem1' Puede moverla o quitarla según sea necesario.
            this.Septiem1TableAdapter.Fill(this.Control_Escolar1DataSet.Septiem1,curp);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.Octubre1' Puede moverla o quitarla según sea necesario.
            this.Octubre1TableAdapter.Fill(this.Control_Escolar1DataSet.Octubre1,curp);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.Noviembre1' Puede moverla o quitarla según sea necesario.
            this.Noviembre1TableAdapter.Fill(this.Control_Escolar1DataSet.Noviembre1,curp);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.Diciembre1' Puede moverla o quitarla según sea necesario.
            this.Diciembre1TableAdapter.Fill(this.Control_Escolar1DataSet.Diciembre1,curp);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.Enero1' Puede moverla o quitarla según sea necesario.
            this.Enero1TableAdapter.Fill(this.Control_Escolar1DataSet.Enero1,curp);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.Febrero1' Puede moverla o quitarla según sea necesario.
            this.Febrero1TableAdapter.Fill(this.Control_Escolar1DataSet.Febrero1,curp);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.Marzo1' Puede moverla o quitarla según sea necesario.
            this.Marzo1TableAdapter.Fill(this.Control_Escolar1DataSet.Marzo1,curp);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.Abril1' Puede moverla o quitarla según sea necesario.
            this.Abril1TableAdapter.Fill(this.Control_Escolar1DataSet.Abril1,curp);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.Mayo1' Puede moverla o quitarla según sea necesario.
            this.Mayo1TableAdapter.Fill(this.Control_Escolar1DataSet.Mayo1,curp);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.Junio1' Puede moverla o quitarla según sea necesario.
            this.Junio1TableAdapter.Fill(this.Control_Escolar1DataSet.Junio1,curp);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.bim11' Puede moverla o quitarla según sea necesario.
            this.bim11TableAdapter.Fill(this.Control_Escolar1DataSet.bim11,curp);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.bim22' Puede moverla o quitarla según sea necesario.
            this.bim22TableAdapter.Fill(this.Control_Escolar1DataSet.bim22,curp);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.bim33' Puede moverla o quitarla según sea necesario.
            this.bim33TableAdapter.Fill(this.Control_Escolar1DataSet.bim33,curp);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.bim44' Puede moverla o quitarla según sea necesario.
            this.bim44TableAdapter.Fill(this.Control_Escolar1DataSet.bim44,curp);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.bim55' Puede moverla o quitarla según sea necesario.
            this.bim55TableAdapter.Fill(this.Control_Escolar1DataSet.bim55,curp);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.bimprom' Puede moverla o quitarla según sea necesario.
            this.bimpromTableAdapter.Fill(this.Control_Escolar1DataSet.bimprom,curp);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.buscar2' Puede moverla o quitarla según sea necesario.
            this.buscar2TableAdapter.Fill(this.Control_Escolar1DataSet.buscar2,curp);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
