﻿namespace Lab2.JohanaAguero_504380284;
// Segunda clase derivada
public class Computadora : DispositivoElectronico
{
    // Método específico de Computadora
    public void IniciarSesion()
    {
        if (EstaEncendido)
        {
            Console.WriteLine("Iniciando sesión...");
        }
        else
        {
            Console.WriteLine("La computadora está apagada. Por favor, enciéndela primero.");
        }
    }
}