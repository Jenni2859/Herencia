using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Clases
{
    public class Categorias
    {
        public int IdCategory { get; set; }
        public string NombreCategory { get; set; }


        // CONSTRUCTORES
        public Categorias() { }
        public Categorias(int idCategory_C, string nombreCategory_C)
        {
            IdCategory = idCategory_C;
            NombreCategory = nombreCategory_C;
        }


    }
}
