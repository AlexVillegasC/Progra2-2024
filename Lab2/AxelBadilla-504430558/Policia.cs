using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.AxelBadilla_504430558
{
    public class Policia : Persona
    {
        public string Rango { set; get; }

       
        
        public Policia(string nombre, int id, int telefono, string rango) : base( nombre,id,telefono)
        {
            this.Rango = rango; 

        }


        public override void Ejercer() {
            Console.WriteLine("El ejerce la ley en el dia a dia");
        }

        public override void Horarios()
        {
            Console.WriteLine("El horario del policia le hace tener que patrullar en la noche");
        }



    }
}
