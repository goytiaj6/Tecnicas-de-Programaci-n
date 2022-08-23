using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo_Ejemplo
{
   abstract class Animal
    {
       protected string nombre,color; 
    }
    class Pez : Animal
    {
        int aletas; 
        public Pez (string N, string C, int A)
        {
            nombre = N;
            color = C;
            aletas = A; 
        }
    }
    class Vaca: Animal
    {
        int noPatas; 
        public Vaca (int nPatas)
        {
            noPatas = nPatas; 
        }
    }
}

