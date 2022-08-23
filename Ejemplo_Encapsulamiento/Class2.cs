using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Encapsulamiento
{
    class Alumno:Persona
    {
        string NoCuenta;
        float promedio;

        public Alumno(string nom, int ed, string nC, float pr)
        {
            nombre = nom;
            Edad = ed;
            NoCuenta = nC;
            promedio = pr;
        }

        public Alumno()
        {

        }
    }
}
