using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiPrimeraBiblioteca;


namespace Aplicación_Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NumerosEnteros n1 = new NumerosEnteros();
        private void Suma_Click(object sender, EventArgs e)
        {
            int num1 = n1.CE(textBox1);
            int num2 = n1.CE(textBox2);
            int suma = num1 + num2;

            MessageBox.Show(" La suma es: " + Convert.ToString(suma));
        }
    }
}
