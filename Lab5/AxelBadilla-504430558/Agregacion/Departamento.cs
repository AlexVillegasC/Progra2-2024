using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.AxelBadilla_504430558.Agregacion
{
    public class Departamento
    {

        public string Nombre { get; set; }
        public int Codigo_materia { get; set; }

        public Departamento(string nombre)
        {
            this.Nombre = nombre;
        }
    }
}