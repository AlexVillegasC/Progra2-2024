using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.AxelBadilla_504430558
{
    public abstract class Persona
    {
        public string Nombre { set; get; }

        public int Id { set; get; }

        public int Telefono { set; get; }

        public Persona(string nombre, int id, int telefono)
        {


            this.Nombre = nombre;
            this.Id = id;
            this.Telefono = telefono;


        }


        public abstract void Ejercer();
        
        
        
        public virtual void  Horarios()
        {
            Console.WriteLine();
        }

        
    }






}
