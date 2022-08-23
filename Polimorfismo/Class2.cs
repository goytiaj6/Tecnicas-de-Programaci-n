using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfismo
{
    public class vaca : animal
    {
        public override void Sonido()
        {
            MessageBox.Show("La vaca hace mu");
        }

        public void Sonido(string nombre)
        {
            MessageBox.Show("La vaca " + nombre + " hace mu");
        }
    }
}
