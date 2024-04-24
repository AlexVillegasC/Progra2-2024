using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.JhonnRojas_703090697

{
    public class Contenedor_empresa<T>
    {
        private List<T> Datos_empresa = new List<T>();

        public void Agregar_dato(T objeto)
        {
            
            Datos_empresa.Add(objeto);
            Console.WriteLine("Se ha agregado un nuevo dato");
        }

        public void Imprimir_datos(Type tipo)
        {
            Console.WriteLine($"Tipo de la lista es:{tipo.Name}");
            Console.WriteLine("Elementos de la lista");

            foreach (T elemento in Datos_empresa)
            {
                Console.WriteLine(elemento);
            }
        }

        public void Eliminar_datos(T elemento)
        {
            Datos_empresa.Remove(elemento);
            Console.WriteLine("El dato ha sido eliminado");
        }

        public void Mostrar_menu()
        {
            Console.WriteLine("******MENU******");
            Console.WriteLine("1.Agregar datos");
            Console.WriteLine("2.Imprimir datos");
            Console.WriteLine("3.Eliminar datos");

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
                        Console.WriteLine("Agregue un nuevo dato:");
                        T datoAgregar = Obtener_dato();
                        Agregar_dato(datoAgregar);
                        break;

                    case 2:
                        Console.WriteLine("Aqui tienes todos los datos:");
                        Imprimir_datos(typeof(T));
                        break;
                    case 3:
                        Console.WriteLine("Que deseas eliminar");
                        T Eliminar_elemento = Obtener_dato();
                        Eliminar_datos(Eliminar_elemento);
                        break;
                }
            } while (Opcion != 0);
        }

        public T Obtener_dato()
        {
            return (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
        }
        public int Obtener_opcion()
        {
            Console.WriteLine("Elija una opcion:");
            if (int.TryParse(Console.ReadLine(),out int Opcion))
            {
                return Opcion;
            }else
            {
                Console.WriteLine("La opcion elegida no existe, elija otra");
                return Obtener_opcion();
            }
        }
    }
}
