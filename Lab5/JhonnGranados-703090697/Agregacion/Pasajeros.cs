using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.JhonnGranados_703090697.Agregacion
{
    public class Pasajeros
    {
        public int Id{ set; get; }

        public string Nombre { set; get; }

        public string Apellido { set; get;}


        public Pasajeros(int id, string nombre, string apellido)
        {
            this.Id = id;   
            this.Nombre= nombre;
            this.Apellido= apellido;
        }


    }
}
