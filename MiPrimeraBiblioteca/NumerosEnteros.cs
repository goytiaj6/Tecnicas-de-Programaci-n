using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraBiblioteca
{
    public class NumerosEnteros
    {
        public int CE(TextBox T1)
        {
            string s = T1.Text;
            int n = 0;
            try
            {
                n = Convert.ToInt32(s);
            }
            catch(FormatException)
            {
                MessageBox.Show(" El dato que ingresaste no es un número entero");
            }
            return n;
        }
    }
}
