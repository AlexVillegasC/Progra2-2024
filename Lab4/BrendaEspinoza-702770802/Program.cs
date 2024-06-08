namespace Lab4.BrendaEspinoza_702770802
{
    public class Program
    {
        public static void Main()
        {
            
            var gato = new Animales.Gato("Gray");
            var perro = new Animales.Perro("Bobby");

            
            var contenedorGatos = new Animales.ContenedorAnimalesV<Animales.Gato>();
            contenedorGatos.Agregar(gato);
            contenedorGatos.MostrarElementos();

           
            var contenedorPerros = new Animales.ContenedorAnimalesV<Animales.Perro>();
            contenedorPerros.Agregar(perro);
            contenedorPerros.MostrarElementos();
        }
    }
}