namespace Lab2.DiegoGutierrez_504560809
{
    public abstract class Animal
    {
        public string Nombre { get; set; }
        public int Peso { get; set; }
        public string habitat { get; set; }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        protected Animal(string _nombre, int _peso, string _habitat)
=======
        protected Animal(string _nombre, int _peso, string _habitat) 
>>>>>>> c28cea0 ([Lab2]Diego Gutierrez)
=======
        protected Animal(string _nombre, int _peso, string _habitat)
>>>>>>> 2550663 (Merge with latest Dev changes)
=======
        protected Animal(string _nombre, int _peso, string _habitat) 
>>>>>>> c28cea0 ([Lab2]Diego Gutierrez)
=======
        protected Animal(string _nombre, int _peso, string _habitat)
>>>>>>> 2550663 (Merge with latest Dev changes)
        {
            this.Nombre = _nombre;
            this.Peso = _peso;
            this.habitat = _habitat;
        }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======

>>>>>>> c28cea0 ([Lab2]Diego Gutierrez)
=======
>>>>>>> be1cce2 ([Lab2]Diego Gutierrez)
=======

>>>>>>> c28cea0 ([Lab2]Diego Gutierrez)
=======
>>>>>>> be1cce2 ([Lab2]Diego Gutierrez)
        public abstract void Accion();

        public virtual void QueSoy()
        {
            Console.WriteLine("Soy del reino animal!");
        }
    }
}
