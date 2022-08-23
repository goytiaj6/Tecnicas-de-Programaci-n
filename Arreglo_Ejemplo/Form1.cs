using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglo_Ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] arr;  //Arreglo sin inicializar 
        Animal[] ArrAnimal = new Animal[2]; 

        private void BtnOk_Click(object sender, EventArgs e)
        {
            i = 0; 
           string longitud = txtNum.Text;
           int Slongitud =Convert.ToInt32(longitud);
            arr = new string[Slongitud];
            //arr = new string[Convert.ToInt32(txtNum.Text)];La longitud del arreglo es ingresada por el usuario 
            //                                               txtNum y eso es una cadena 
            //Muestra lo desaparecido 

            ArrAnimal[0] = new Pez("Nemo", "dorado", 2);
            ArrAnimal[1] = new Vaca(3); 

            label2.Visible = true;  
            txtIngresar.Visible = true;
            btnIngresar.Visible = true;
            btnMostrar.Visible = true;
            label1.Visible = false; 
            btnOk.Visible = false;
            txtIngresar.Visible = true;


        }
        int i = 0;
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (i < arr.Length)
            {
                arr[i] = txtIngresar.Text;
            }
            else
            {
                MessageBox.Show("Arreglo lleno!");
            }
            i++;
            txtIngresar.Text = ""; 

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            txtIngresar.Visible = false;
            btnIngresar.Visible = false;
            btnMostrar.Visible = false;
            label1.Visible = true;
            btnOk.Visible = true;
            txtIngresar.Visible = false;
            string contenido = ""; 
            for (int k=0; k<arr.Length; k++)
            {
                contenido = contenido + arr[k] + ", "; 
            }
            MessageBox.Show("El arreglo es: " + contenido);
        }
    }
}
