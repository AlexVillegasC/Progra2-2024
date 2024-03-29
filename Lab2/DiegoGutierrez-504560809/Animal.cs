namespace Lab2.DiegoGutierrez_504560809
{
    public abstract class Animal
    {
        public string Nombre { get; set; }
        public int Peso { get; set; }
        public string habitat { get; set; }

<<<<<<< HEAD
        protected Animal(string _nombre, int _peso, string _habitat)
=======
        protected Animal(string _nombre, int _peso, string _habitat) 
>>>>>>> c28cea0 ([Lab2]Diego Gutierrez)
        {
            this.Nombre = _nombre;
            this.Peso = _peso;
            this.habitat = _habitat;
        }
<<<<<<< HEAD
<<<<<<< HEAD
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
