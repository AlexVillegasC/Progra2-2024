﻿//
namespace Lab3.DanielNunez_119040930
{
    public class Telefono : TelefonoConBateria, TelefonoConConexionInalabrica

    {
        public void TurnOn()
        {
            Console.WriteLine("Encendiendo el teléfono móvil...");
        }

        public void TurnOff()
        {
            Console.WriteLine("Apagando el teléfono móvil...");
        }

        public void Connect()
        {
            Console.WriteLine("Conectando el teléfono móvil a la red...");
        }

        public void Disconnect()
        {
            Console.WriteLine("Desconectando el teléfono móvil de la red...");
        }
    }
}
