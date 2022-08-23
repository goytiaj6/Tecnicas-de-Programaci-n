using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hola_Mundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HM_Click(object sender, EventArgs e)
        {

        }
        int i = 0;
        string s = "";
        private void OK_Click(object sender, EventArgs e)
        {
            /*i++;
            if(i % 2 !=0)
            {
                HM.Text = "Hola Mundo";
            }
            else
            {
                HM.Text = " ";
            }*/
            HM.Text = "Hola " + Box1.Text;
        }
        
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}