using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Encapsulamiento
{
    class Persona
    {
        int edad;//atributo encapsulado
        public string nombre;

        public Persona()
        {

        }

        //leer valñor edad
        public int SaberEdad()
        {
            return edad;
        }

        //Asignar valor edad
        public void AsignarEdad(int e)
        {
            edad = e;
        }

        //Misma función del método SaberEdad
        public int Edad
        {
            get { return edad; } //Solo lectura
            set { edad = value; } //Misma función del método SaberEdad
        }
    }
}
