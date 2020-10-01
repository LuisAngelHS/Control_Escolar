using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text; //Para lo del pdf
using iTextSharp.text.pdf;
using System.Net.Mail; //Para lo del correo
using System.Net.Mime;
using System.IO;

namespace PROYECTO_ESCUELA
{
    public partial class DIRECTORIOS1_6 : Form
    {
        public DIRECTORIOS1_6()
        {
            InitializeComponent();
        }

        private void DIRECTORIOS1_6_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.fantas2' Puede moverla o quitarla según sea necesario.
            this.fantas2TableAdapter.Fill(this.Control_Escolar1DataSet.fantas2);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.NOMBALUMDIRECT1A' Puede moverla o quitarla según sea necesario.
            this.NOMBALUMDIRECT1ATableAdapter.Fill(this.Control_Escolar1DataSet.NOMBALUMDIRECT1A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.telefono1A' Puede moverla o quitarla según sea necesario.
            this.telefono1ATableAdapter.Fill(this.Control_Escolar1DataSet.telefono1A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.TELEF_DIREC6A' Puede moverla o quitarla según sea necesario.
            this.TELEF_DIREC6ATableAdapter.Fill(this.Control_Escolar1DataSet.TELEF_DIREC6A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.fastasma' Puede moverla o quitarla según sea necesario.
            this.fastasmaTableAdapter.Fill(this.Control_Escolar1DataSet.fastasma);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.grado1A' Puede moverla o quitarla según sea necesario.
            this.grado1ATableAdapter.Fill(this.Control_Escolar1DataSet.grado1A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.FECHADIRECT1A' Puede moverla o quitarla según sea necesario.
            this.FECHADIRECT1ATableAdapter.Fill(this.Control_Escolar1DataSet.FECHADIRECT1A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.CURPDIRECT1A' Puede moverla o quitarla según sea necesario.
            this.CURPDIRECT1ATableAdapter.Fill(this.Control_Escolar1DataSet.CURPDIRECT1A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.DIREC_DIRECTORIO1A' Puede moverla o quitarla según sea necesario.
            this.DIREC_DIRECTORIO1ATableAdapter.Fill(this.Control_Escolar1DataSet.DIREC_DIRECTORIO1A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.TELEF_DIREC1A' Puede moverla o quitarla según sea necesario.
            this.TELEF_DIREC1ATableAdapter.Fill(this.Control_Escolar1DataSet.TELEF_DIREC1A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.TUTOR_DIRECT1A' Puede moverla o quitarla según sea necesario.
            this.TUTOR_DIRECT1ATableAdapter.Fill(this.Control_Escolar1DataSet.TUTOR_DIRECT1A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.ALERG_DIRECT1A' Puede moverla o quitarla según sea necesario.
            this.ALERG_DIRECT1ATableAdapter.Fill(this.Control_Escolar1DataSet.ALERG_DIRECT1A);
            // TODO: esta línea de código carga datos en la tabla 'Control_Escolar1DataSet.SANGRE_DIRECT1A' Puede moverla o quitarla según sea necesario.
            this.SANGRE_DIRECT1ATableAdapter.Fill(this.Control_Escolar1DataSet.SANGRE_DIRECT1A);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog filename = new SaveFileDialog();
            filename.Filter = "Imagen png|*.png";
            filename.FileName = "Grado1";
            //filename.FileName = txtbuscador.Text;
            reportViewer1.ShowToolBar = false;
            button1.Visible = false;
            if (filename.FileName != "")
            {
                Graphics g1 = this.CreateGraphics();
                System.Drawing.Image MyImage = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height, g1);
                Graphics g2 = Graphics.FromImage(MyImage);
                IntPtr dc1 = g1.GetHdc();
                IntPtr dc2 = g2.GetHdc();
                BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
                g1.ReleaseHdc(dc1);
                g2.ReleaseHdc(dc2);

                FileStream fileStream = new FileStream(filename.FileName, FileMode.Create, FileAccess.Write);
                MyImage.Save(fileStream, System.Drawing.Imaging.ImageFormat.Png);

                fileStream.Close();
                MyImage.Dispose();

                //Una vez obtenida la imagen la convertimos en PDF   (Estas coordenas son iguales al tamaño del formulario)
                var pgSize = new iTextSharp.text.Rectangle(1030,920);
                Document document = new Document(pgSize, 10, 10, 10, 10);
                //Guardamos el archivo en pdf con un nombre predefinido
                string GuardarComo = @"C:\Users\Dreamer\Documents\BOLETAS\grado1A.pdf";
                using (var stream = new FileStream(GuardarComo, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    PdfWriter.GetInstance(document, stream);
                    document.Open();
                    using (var imageStream = new FileStream(filename.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        var image = iTextSharp.text.Image.GetInstance(imageStream);
                        document.Add(image);
                    }
                    document.Close();
                }
            }
            button1.Visible = true;
        }
                

                  [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest,
            int nXDest,
            int nYDest,
            int nWidth,
            int nHeight,
            IntPtr hdcSrc,
            int nXSrc,
            int nYSrc,
            int dwRop);

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
  
}
    

