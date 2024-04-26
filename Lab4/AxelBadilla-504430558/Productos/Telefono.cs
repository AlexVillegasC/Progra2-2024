using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.AxelBadilla_504430558.Productos
{
    public class Telefono
    {
        public string Nombre { get; set; }


        public Telefono(string nombre)
        { 
        
        this.Nombre = nombre;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}";
        }

    }
}
