using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.JohanaAguero_504380284

// Clase base abstracta
public abstract class DispositivoElectronico
{
    // Propiedad común a todos los dispositivos electrónicos
    public bool EstaEncendido { get; protected set; }

    // Método común para encender el dispositivo
    public virtual void Encender()
    {
        EstaEncendido = true;
        Console.WriteLine("Dispositivo encendido.");
    }

    // Método común para apagar el dispositivo
    public virtual void Apagar()
    {
        EstaEncendido = false;
        Console.WriteLine("Dispositivo apagado.");
    }
}
