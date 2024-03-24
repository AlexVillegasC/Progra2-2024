namespace Lab2.MariaGonzalez
{
    public class Computadora
    {
        protected string modelo;
        protected int precio;

<<<<<<< HEAD

=======
        
>>>>>>> 09e6e2c (lab2/MariaGoonzalez-504550553)
        public Computadora(string modelo, int precio)
        {
            this.modelo = modelo;
            this.precio = precio;
        }

<<<<<<< HEAD

=======
        
>>>>>>> 09e6e2c (lab2/MariaGoonzalez-504550553)
        public virtual void Encender()
        {
            Console.WriteLine("La computadora está encendiendo...");
        }

<<<<<<< HEAD

=======
        
>>>>>>> 09e6e2c (lab2/MariaGoonzalez-504550553)
        public virtual void Apagar()
        {
            Console.WriteLine("La computadora está apagando...");
        }

<<<<<<< HEAD

=======
        
>>>>>>> 09e6e2c (lab2/MariaGoonzalez-504550553)
        public override string ToString()
        {
            return $"Modelo: {modelo}, Precio: {precio}";
        }
    }

}
