using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
        float n1, n2, res;
        string sn1, sn2, sn3;
        private void BOK_Click(object sender, EventArgs e)
        {
            sn1 = Box1.Text;
            sn2 = Box2.Text;

            n1 = Convert.ToSingle(sn1);
            n2 = Convert.ToSingle(sn2);

            if (rdbSuma.Checked == true)
            {
                res = n1 + n2;
            }
            else if (rdbResta.Checked == true)
            {
                res = n1 - n2;
            }
            else if (rdbDivisión.Checked == true && n2 != 0)
            {
                res = n1 / n2;
            }
            else if (rdbMultiplicación.Checked == true)
            {
                res = n1 * n2;
            }
            sn3 = Convert.ToString(res);
            Box3.Text = sn3;
        }
    }
}
