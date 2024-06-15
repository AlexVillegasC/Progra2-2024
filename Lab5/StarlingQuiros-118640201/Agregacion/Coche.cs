using Lab5.StarlingQuiros_118640201.Agregacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.StarlingQuiros_118640201.Agregacion
{
    public class Coche
    {
        public string Modelo { get; set; }
        public List<Rueda> Ruedas { get; set; }

        public Coche(string modelo)
        {
            Modelo = modelo;
            Ruedas = new List<Rueda>();
        }

        public void AgregarRueda(Rueda rueda)
        {
            Ruedas.Add(rueda);
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Modelo del Coche: {Modelo}");
            foreach (var rueda in Ruedas)
            {
                rueda.MostrarInformacion();
            }
        }
    }
}