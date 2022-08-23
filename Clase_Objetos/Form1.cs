using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_Objetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //bebe b1;
        //bebe b2;
        bebe b3 = new bebe();  

        private void Btbb_Click(object sender, EventArgs e)
        {
            //b1 = new bebe();
            //b1.nombre = "Joaquin";
            //MessageBox.Show("Ha nacido un bebé llamado:  " + b1.nombre);

            //b2 = new bebe(BoxName.Text, 'F', 8, 73.8F, 5.2F, "café");
            //MessageBox.Show("Ha nacido otro bebé llamado: " + b2.nombre + " de género: " + b2.genero );

            b3 = new bebe(BoxName.Text);
            b3.peso = 3500;
            b3.talla = 50;

            textBox1.Text = "Se ha creado el objeto que tiene los siguientes atributos: \r\n nombre: " + b3.nombre + " \r\n peso: " + Convert.ToString(b3.peso) + "\r\n talla: " + Convert.ToString(b3.talla);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            b3.hambre = checkBox1.Checked;
            C = checkBox4.Checked;

            if (b3.Comer(C) == true)
            {
                MessageBox.Show(b3.nombre + " está comiendo");
                checkBox1.Checked = false;
                checkBox4.Checked = false;
                textBox1.Text = "Se ha creado el objeto que tiene los siguientes atributos: \r\n nombre: " + b3.nombre + " \r\n peso: " + Convert.ToString(b3.peso) + "\r\n talla: " + Convert.ToString(b3.talla);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //b3.Gatear1();
            //b3.Gatear2();
            if(b3.Gatear3() == true)
            {
                MessageBox.Show("Estoy gateando");
                checkBox1.Checked = b3.hambre;
                textBox1.Text = "Se ha creado el objeto que tiene los siguientes atributos: \r\n nombre: " + b3.nombre + " \r\n peso: " + Convert.ToString(b3.peso) + "\r\n talla: " + Convert.ToString(b3.talla);
            }
        }

        bool C;

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            b3.hambre = checkBox1.Checked;

            if (b3.Llorar() == true)
            {
                MessageBox.Show(b3.nombre + " esta llorando");
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            b3.sueño = checkBox2.Checked;

            if (b3.Llorar() == true)
            {
                MessageBox.Show(b3.nombre + " esta llorando");
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            b3.dolor = checkBox3.Checked;
            if (b3.Llorar() == true)
            {
                MessageBox.Show(b3.nombre + " esta llorando");
            }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            bool malestar = b3.HacerBaño();
            if(malestar == true)
            {
                MessageBox.Show("Estoy llorando");
            }
            timer1.Interval = 10000;
        }

        private void BoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}