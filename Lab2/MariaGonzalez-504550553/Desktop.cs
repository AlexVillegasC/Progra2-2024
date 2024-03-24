namespace Lab2.MariaGonzalez
{
    public class Desktop : Computadora
    {
        private string fabricante;

<<<<<<< HEAD

=======
        
>>>>>>> 09e6e2c (lab2/MariaGoonzalez-504550553)
        public Desktop(string modelo, int precio, string fabricante) : base(modelo, precio)
        {
            this.fabricante = fabricante;
        }

<<<<<<< HEAD



=======
        

      
>>>>>>> 09e6e2c (lab2/MariaGoonzalez-504550553)
        public override string ToString()
        {
            return $"Modelo: {modelo}, Precio: {precio}, Fabricante: {fabricante}";
        }
    }

}
