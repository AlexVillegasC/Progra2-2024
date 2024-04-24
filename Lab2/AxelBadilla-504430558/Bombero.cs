using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.AxelBadilla_504430558
{
    public class Bombero : Persona
    {

        public string Valentia { set; get; }


        public Bombero(string nombre, int id, int telefono, string valentia) : base(nombre, id, telefono)
        {
            this.Valentia = valentia;

        }


        public override void Ejercer()
        {
            Console.WriteLine("El ejerce su labor mitigando incendios");
        }



        public override void Horarios()
        {
            Console.WriteLine("El horario del bombero le fuerza a dormir en la estacion");
        }

    }
}
