<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
﻿namespace Lab4.DanielNunez_119040930
=======
=======
>>>>>>> f27fe80 (testing)
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.DanielNunez_119040930
<<<<<<< HEAD
>>>>>>> f27fe80 (testing)
=======
﻿namespace Lab4.DanielNunez_119040930
>>>>>>> 2550663 (Merge with latest Dev changes)
=======
>>>>>>> f27fe80 (testing)
=======
﻿namespace Lab4.DanielNunez_119040930
>>>>>>> 2550663 (Merge with latest Dev changes)
=======
﻿namespace Lab4.DanielNunez_119040930
>>>>>>> origin/development
{
    public class ContenedorDaniel<T>
    {
        private List<T> elementos = new List<T>(); // Lista para almacenar elementos de cualquier tipo

        // Método para agregar elementos al contenedor
        public void Agregar(T elemento)
        {
            elementos.Add(elemento);
        }

        // Método para mostrar los elementos del contenedor
        public void MostrarElementos()
        {
            Console.WriteLine("Elementos en el contenedor:");
            foreach (var elemento in elementos)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}
