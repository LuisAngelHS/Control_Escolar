using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_ESCUELA
{
    class validacion
    {
        public static void numero (KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("No se admiten letras, solo valores numericos");
            }


        }

        public static void letra (KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("no se admiten numeros, solo letras");
            }

        }
        public void rango(PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                //if (Convert.ToInt16(mat9jun.Text) < 5 && Convert.ToInt16(mat9jun.Text) > 10) { }
            }

        }
    }
}
