using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfismo
{
    public abstract class animal
    {
        //public animal() { } no sirve porque no puedo creear a partir de una clase abstracta

        /*public virtual void Sonido()
        {
            MessageBox.Show("El animal hace algún sonido");
        }*/
        public abstract void Sonido();
    }
}
