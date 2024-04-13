namespace Lab2.DiegoGutierrez_504560809
{
    public abstract class Animal
    {
        public string Nombre { get; set; }
        public int Peso { get; set; }
        public string habitat { get; set; }

        protected Animal(string _nombre, int _peso, string _habitat)
        {
            this.Nombre = _nombre;
            this.Peso = _peso;
            this.habitat = _habitat;
        }
        public abstract void Accion();

        public virtual void QueSoy()
        {
            Console.WriteLine("Soy del reino animal!");
        }
    }
}
