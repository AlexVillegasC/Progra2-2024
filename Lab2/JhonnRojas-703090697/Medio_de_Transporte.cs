<<<<<<< HEAD
﻿namespace Lab2.JhonnRojas_703090697
{
    public class Medio_de_Transporte
    {


        public string Marca { get; set; }

        public string Color { get; set; }

        public int Matricula { get; set; }

        public string Equilibrio_dinamico { get; set; }



        public Medio_de_Transporte(string Marca, string Color, int Matricula, string Equilibrio_dinamico)
        {
            this.Marca = Marca;
            this.Color = Color;
            this.Matricula = Matricula;
            this.Equilibrio_dinamico = Equilibrio_dinamico;
        }

        public virtual void Realizar_mantenimiento()
        {
            Console.WriteLine("mantenimiento general");
        }

    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.JhonnRojas_703090697
{
    public class Medio_de_Transporte
    {
        
        
            public string Marca { get; set; }

            public string Color { get; set; }

            public int Matricula { get; set; }

            public string Equilibrio_dinamico { get; set; }



            public Medio_de_Transporte(string Marca, string Color, int Matricula, string Equilibrio_dinamico)
            {
                this.Marca = Marca;
                this.Color = Color;
                this.Matricula = Matricula;
                this.Equilibrio_dinamico = Equilibrio_dinamico;
            }

            public virtual void Realizar_mantenimiento()
            {
                Console.WriteLine("mantenimiento general");
            }

        }
    }
>>>>>>> 0ceb716 (Abstract class)



