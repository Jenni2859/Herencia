using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Clases
{
    public class Caballo: Animal 
    {
        

        public bool TieneMontura { get; set; }

        public Caballo(string nombre, int edad, string sexo, bool tieneMontura) : base(nombre, edad, sexo)
        {
            TieneMontura = tieneMontura;
        }

        public override void HacerSonido()
        {
            Console.WriteLine("El caballo hace ¡hiiii, hiiii, hiiii! ");
        }
    }
}
