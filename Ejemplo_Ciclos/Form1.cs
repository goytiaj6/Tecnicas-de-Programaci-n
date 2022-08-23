using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Ciclos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int suma;
        private void Button1_Click(object sender, EventArgs e)
        {
            suma = 0;
            for (int i=1;i<=10; i++)
            {
                suma = suma + i;
            }
            string sSuma = Convert.ToString(suma);
            MessageBox.Show("La suma de los primeros 10 números enteros es: " + sSuma);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BT_Click(object sender, EventArgs e)
        {
            suma = 0;
            int i = 0;
            bool b = true;
            while(b==true)
            {
                suma = suma + i;
                i++;
                if(i>=11)

                    {
                        b = false;
                    }
                string sSuma = Convert.ToString(suma);
                MessageBox.Show("La suma de los primeros 10 números enteros es: " + sSuma);
            }
        }
    }
}
