using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.ArianaHernandez_504520730
{
    public class Animal : IDomestico, ISalvaje
    {
        public string Nombre { get; set; }

        public string Clase { get; set; }
        protected Animal(string nombre, string clase)
        {
            this.Nombre = nombre;
            this.Clase = clase;
        }

        public void Salvaje()
        {
            throw new NotImplementedException();
        }

        public void Domestico()
        {
            throw new NotImplementedException();
        }

        public void Ostil()
        {
            throw new NotImplementedException();
        }
    }

}
