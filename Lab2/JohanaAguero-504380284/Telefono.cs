using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.JohanaAguero_504380284

// Primera clase derivada
public class Telefono : DispositivoElectronico
{
    // Método específico de TelefonoMovil
    public void RealizarLlamada()
    {
        if (EstaEncendido)
        {
            Console.WriteLine("Realizando llamada...");
        }
        else
        {
            Console.WriteLine("El teléfono está apagado. Por favor, enciéndelo primero.");
        }
    }
}