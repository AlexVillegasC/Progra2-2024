<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
﻿namespace Lab2.JhonnRojas_703090697
{
    public class Moto : Medio_de_Transporte
    {


        public string Tipo_motocicleta { get; set; }


        public Moto(string Marca, string Color, int Matricula, string Equilibrio_dinamico, string Tipo_motocicleta)
            : base(Marca, Color, Matricula, Equilibrio_dinamico)
        {
            this.Tipo_motocicleta = Tipo_motocicleta;
        }

        public override void Realizar_mantenimiento()
        {
            Console.WriteLine("Verificar cadena y los ejes de cada llanta");
        }
    }

=======
=======
>>>>>>> 0ceb716 (Abstract class)
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab2.JhonnRojas_703090697.Medio_de_Transporte;

namespace Lab2.JhonnRojas_703090697
<<<<<<< HEAD
=======
﻿namespace Lab2.JhonnRojas_703090697
>>>>>>> 2550663 (Merge with latest Dev changes)
{
    public class Moto : Medio_de_Transporte
    {


        public string Tipo_motocicleta { get; set; }


        public Moto(string Marca, string Color, int Matricula, string Equilibrio_dinamico, string Tipo_motocicleta)
            : base(Marca, Color, Matricula, Equilibrio_dinamico)
        {
            this.Tipo_motocicleta = Tipo_motocicleta;
        }
<<<<<<< HEAD
    
>>>>>>> 0ceb716 (Abstract class)
=======

        public override void Realizar_mantenimiento()
        {
            Console.WriteLine("Verificar cadena y los ejes de cada llanta");
        }
    }

>>>>>>> 2550663 (Merge with latest Dev changes)
=======
{
    public class Moto: Medio_de_Transporte
    {
        
        
            public string Tipo_motocicleta { get; set; }


            public Moto(string Marca, string Color, int Matricula, string Equilibrio_dinamico, string Tipo_motocicleta)
                : base(Marca, Color, Matricula, Equilibrio_dinamico)
            {
                this.Tipo_motocicleta = Tipo_motocicleta;
            }

            public override void Realizar_mantenimiento()
            {
                Console.WriteLine("Verificar cadena y los ejes de cada llanta");
            }
        }
    
>>>>>>> 0ceb716 (Abstract class)
}

