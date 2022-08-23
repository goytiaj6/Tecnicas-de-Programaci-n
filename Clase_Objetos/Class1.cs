using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_Objetos
{
    public class bebe
    {
        //Atributos de la clase
        public string nombre, ColorOjos;
        public char genero;
        public int edad;
        public float peso, talla;
        public bool hambre, sueño, dolor;

        //Se define un constructor para la clase
        //lista de constructores
        //constructor vacio

        public bebe() { }

        //constructor de cadena

        /*public bebe(string N, char G, int E, float P, float T, string CO)
        {
            nombre = N;
            genero = G;
            edad = E;
            talla = T;
            ColorOjos = CO;
        }*/

        //Otro constructo de cadena (solo bebe.nombre)
        public bebe(string N)
        {
            nombre = N;
        }

        public bebe(string N, int E)
        {
            nombre = N;
            edad = E;
        }

        //Métodos

        public bool Llorar()//bool hambre, bool sueño, bool dolor caundo no posee los atributos
        {
            bool estoy_llorando = false;
            if (hambre == true || sueño == true || dolor == true)
            {
                estoy_llorando = true;
            }
            return estoy_llorando;
        }

        public bool Comer(bool hay_comida)//bool hambre
        {
            bool estoy_comiendo = false;
            if (hambre == true && hay_comida == true)
            {
                estoy_comiendo = true;
                peso = peso + 100;
                talla = talla + .1F;
            }
            return estoy_comiendo;
        }

        //Ejemplo gatear1
        /*public void Gatear1()
        {
            MessageBox.Show(" está gateándo");
            peso = peso - 50;
            talla = talla - .1F;
            hambre = true;
        }*/

        //Ejemplo gatear2
        /*public bool Gatear2()
            bool estoy_gateando = false;
            if(sueño == false && dolor == false)
            {
                estoy_gateando = true;
            {
                peso = peso - 50;
                talla = talla - .05F;
            }
            return estoy_gateando;
        }*/

        //Ejemplo gatear3
        public bool Gatear3()
        {
            bool estoy_gateando = false;
            if(8<edad && edad<=13)
            {
                estoy_gateando = true;
            }

            else
            {
                MessageBox.Show("No estoy en edad para gatear");
            }
            return estoy_gateando;
        }

        public bool HacerBaño()
        {
            peso = peso - 100;
            dolor = true;
            bool b = Llorar();
            MessageBox.Show("Hice del baño");
            return b;
        }
    }
}
