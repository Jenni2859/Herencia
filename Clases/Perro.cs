using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Clases
{
    public class Perro : Animal
    {
        public string Raza { get; set; }
        public Perro() { }

        public Perro(string Nombre_p, int Edad_p, string raza_p,string Sexo_p) : base(Nombre_p, Edad_p, Sexo_p)
        {
            this.Raza = raza_p;
        }

        public override void HacerSonido()
        {
            Console.WriteLine("El pego hace psssss");
        }
    }
    
}
