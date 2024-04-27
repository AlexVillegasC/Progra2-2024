using Lab5.JhonnGranados_703090697.Agregacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.JhonnGranados_703090697.Agregacion
{
    public class Bus
    {
        List<Pasajeros> Pasajero = new List<Pasajeros>();
        
        public void Agregar_pasajero (Pasajeros pasajeros)
        {
            Pasajero.Add(pasajeros);
        }



        public void Imprimir_pasajeros()
        {
            foreach(var passenger in Pasajero)
            {
                Console.WriteLine($"Identificacion:{passenger.Id}\nNombre:{passenger.Nombre}\nApellido:{passenger.Apellido}");
            }
        }


        public void Menu() 
        {
            int Opcion;

            do
            {
                Mostrar_menu();
                Opcion = Obtener_opcion();
            switch (Opcion)
                {
                    case 1:
                        Console.WriteLine("Agrega un nuevo pasajero:");
                        Agregar_pasajero(Crear_pasajero());
                        Console.WriteLine("El pasajero se ha agregado con exito:");
                        break;
                    case 2:
                        Console.WriteLine("Datos del pasajero:");
                        Imprimir_pasajeros();
                        break;

                    case 0:
                        Console.WriteLine("Cerrando programa...");
                        break;
                    default: 
                        Console.WriteLine("'Opcion invalida'");
                        break;
                }
            }while (Opcion!=0);

        }


        public void Mostrar_menu()
        {
            Console.WriteLine("+++++++Menu+++++++");
            Console.WriteLine("1.Agregar pasajero");
            Console.WriteLine("2.Imprimir pasajero");
            Console.WriteLine("0.Cerrar programa");
        }
        public int Obtener_opcion()
        {
            Console.WriteLine("Elije una opcion");
            if (int.TryParse(Console.ReadLine(), out int Opcion))
            {
                return Opcion;
            }else
            {
                Console.WriteLine("Esta opcion no existe");
                return Obtener_opcion();
            }
        }

        private Pasajeros Crear_pasajero()
        {
            Console.WriteLine("Ingrese la identificacion del pasajero:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del pasajero:");
            string nombre=Console.ReadLine();

            Console.WriteLine("Ingrese el apellido del pasajero:");
            string apellido=Console.ReadLine();

            return new Pasajeros(id,nombre,apellido);
            
        }
    }
}
//Bus pasajero = new Bus();
//pasajero.Menu();
