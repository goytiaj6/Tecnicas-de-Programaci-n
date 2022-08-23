using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Encapsulamiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            P1.AsignarEdad(45);
            int edadP1 = P1.SaberEdad();
            int EdadP1 = P1.Edad;
            P1.Edad = 34;
        }
        Alumno A1 = new Alumno();

        Persona P1 = new Persona();
    }
}
