using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Animal
    {
        public string nombre {  get; set; }
        public int Edad { get; set; }

        public string Sexo { get; set; }

        public Animal()
        {
            
        }

        public Animal(string nombre, int edad, string sexo) // crea una instancia y agrega valores
        {
            this.nombre = nombre;
            Edad = edad;
            Sexo = sexo;
        }

        //Método

        public void Defenderse ()
        {
            Console.WriteLine("El animal se sintio en peligro, se hizo bolita");
        }


        /// <summary>
        /// Método para darle de comer al animalito
        /// </summary>
        /// <param name="TipoComida">Recibe 1: para indicar que es carnivoro, 2: Hervivoro, 3: Come cuando hay</param>
        public void Alimentarse(int TipoComida)
        {
            switch (TipoComida)
            {
                case 1: // Carnivoros
                    Console.WriteLine($"A {nombre} debes de darle carne");
                    break;
                case 2: //Hervivoros
                    Console.WriteLine($"A {nombre} debes de darle vegetales");
                    break;
                case 3: 
                    Console.WriteLine($"A {nombre} puedes darle lo que sea");
                    break;
                default:
                    Console.WriteLine("Opción no completada");
                    break;

            }
        }


        public void SetEdad(int Edad_p)
        {
            if (Edad_p <= 0)
            {
                Console.WriteLine("Edad no permitada");
            }
            else
            {
                this.Edad = Edad_p;
            }
        }

        public virtual void HacerSonido()
        {
            Console.WriteLine("Todos los animales hacen sonid");

        }


    }
}
