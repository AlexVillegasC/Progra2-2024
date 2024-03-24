namespace Lab2.MariaGonzalez
{
    public class Desktop : Computadora
    {
        private string fabricante;

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

=======
        
>>>>>>> 09e6e2c (lab2/MariaGoonzalez-504550553)
=======

>>>>>>> 2550663 (Merge with latest Dev changes)
=======
        
>>>>>>> 09e6e2c (lab2/MariaGoonzalez-504550553)
        public Desktop(string modelo, int precio, string fabricante) : base(modelo, precio)
        {
            this.fabricante = fabricante;
        }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD



=======
        

      
>>>>>>> 09e6e2c (lab2/MariaGoonzalez-504550553)
=======



>>>>>>> 2550663 (Merge with latest Dev changes)
=======
        

      
>>>>>>> 09e6e2c (lab2/MariaGoonzalez-504550553)
        public override string ToString()
        {
            return $"Modelo: {modelo}, Precio: {precio}, Fabricante: {fabricante}";
        }
    }

}
