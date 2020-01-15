using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Facturacion
{
  public  class Validacion
    {

        //valida Solo letras
        public void SoloLetras(KeyPressEventArgs e)
        {

            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;

                }

                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }

                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;

                }

                else
                {

                    e.Handled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void SoloNumeros(KeyPressEventArgs e)
        {

            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;

                }

                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }

                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;

                }

                else
                {

                    e.Handled = true;
                }

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}

/*
 * el el evento del elemento
 * Validacion v = new Validacion();
 * 
 private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

En el Evento Para DOUBLE
if (Char.IsDigit(e.KeyChar)) return;
if (Char.IsControl(e.KeyChar)) return;
if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains('.') == false)) return;
if ((e.KeyChar == '.') && ((sender as TextBox).SelectionLength == (sender as TextBox).TextLength)) return;
e.Handled = true;

*/
