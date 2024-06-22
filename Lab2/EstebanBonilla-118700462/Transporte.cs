using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.EstebanBonilla_118700462
{
    public class Transporte
    {
        public string Fabricante { get; set; }
        public string Tipo { get; set; }
        public int Fabricacion { get; set; }

        // Constructor con sobrecarga
        public Transporte(string fabricante, string tipo)
        {
            Fabricante = fabricante;
            Tipo = tipo;
            Fabricacion = DateTime.Now.Year;
        }

        public Transporte(string fabricante, string tipo, int fabricacion)
        {
            Fabricante = fabricante;
            Tipo = tipo;
            Fabricacion = fabricacion;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Fabricante: {Fabricante}, Tipo: {Tipo}, Año: {Fabricacion}");
        }

        public void Encender()
        {
            Console.WriteLine("El transporte ha arrancado.");
        }

        public void Encender(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
