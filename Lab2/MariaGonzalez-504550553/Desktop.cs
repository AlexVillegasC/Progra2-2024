namespace Lab2.MariaGonzalez
{
    public class Desktop : Computadora
    {
        private string fabricante;

        
        public Desktop(string modelo, int precio, string fabricante) : base(modelo, precio)
        {
            this.fabricante = fabricante;
        }

        

      
        public override string ToString()
        {
            return $"Modelo: {modelo}, Precio: {precio}, Fabricante: {fabricante}";
        }
    }

}
