﻿namespace Lab2.MariaGonzalez
{
    public class Computadora
    {
        protected string modelo;
        protected int precio;

<<<<<<< HEAD
<<<<<<< HEAD

=======
        
>>>>>>> 09e6e2c (lab2/MariaGoonzalez-504550553)
=======

>>>>>>> 2550663 (Merge with latest Dev changes)
        public Computadora(string modelo, int precio)
        {
            this.modelo = modelo;
            this.precio = precio;
        }

<<<<<<< HEAD
<<<<<<< HEAD

=======
        
>>>>>>> 09e6e2c (lab2/MariaGoonzalez-504550553)
=======

>>>>>>> 2550663 (Merge with latest Dev changes)
        public virtual void Encender()
        {
            Console.WriteLine("La computadora está encendiendo...");
        }

<<<<<<< HEAD
<<<<<<< HEAD

=======
        
>>>>>>> 09e6e2c (lab2/MariaGoonzalez-504550553)
=======

>>>>>>> 2550663 (Merge with latest Dev changes)
        public virtual void Apagar()
        {
            Console.WriteLine("La computadora está apagando...");
        }

<<<<<<< HEAD
<<<<<<< HEAD

=======
        
>>>>>>> 09e6e2c (lab2/MariaGoonzalez-504550553)
=======

>>>>>>> 2550663 (Merge with latest Dev changes)
        public override string ToString()
        {
            return $"Modelo: {modelo}, Precio: {precio}";
        }
    }

}
