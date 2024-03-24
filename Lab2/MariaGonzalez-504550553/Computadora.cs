namespace Lab2.MariaGonzalez
{
    public class Computadora
    {
        protected string modelo;
        protected int precio;

        
        public Computadora(string modelo, int precio)
        {
            this.modelo = modelo;
            this.precio = precio;
        }

        
        public virtual void Encender()
        {
            Console.WriteLine("La computadora está encendiendo...");
        }

        
        public virtual void Apagar()
        {
            Console.WriteLine("La computadora está apagando...");
        }

        
        public override string ToString()
        {
            return $"Modelo: {modelo}, Precio: {precio}";
        }
    }

}
