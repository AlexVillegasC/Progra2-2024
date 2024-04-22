using Lab5.JhonnGranados_703090697.Composicion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.JhonnGranados_703090697.Composicion
{
    public class Dispositivo
    {
        public Bateria bateria { get; private set; }

        public Sistema_Operativo sistema_operativo { get; private set; }

        public Dispositivo()
        {
            bateria = new Bateria();
            sistema_operativo = new Sistema_Operativo(); 
        }
    }
}
/*Dispositivo dispositivo = new Dispositivo();
Console.WriteLine($"Carga de la bateria:{dispositivo.bateria.Carga_bateria}");
Console.WriteLine($"funcion del dispositivo:{dispositivo.sistema_operativo.Funcionalidades}");*/
