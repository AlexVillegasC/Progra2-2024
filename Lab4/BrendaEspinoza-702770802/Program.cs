namespace Lab4.BrendaEspinoza_702770802
{
    public class Program
    {
        public static void Main()
        {
            // Crear instancias de Gato y Perro
            var gato = new Animales.Gato("Gray");
            var perro = new Animales.Perro("Bobby");

            // Crear una instancia de ContenedorAnimalesV para Gato
            var contenedorGatos = new Animales.ContenedorAnimalesV<Animales.Gato>();
            contenedorGatos.Agregar(gato);
            contenedorGatos.MostrarElementos();

            // Crear una instancia de ContenedorAnimalesV para Perro
            var contenedorPerros = new Animales.ContenedorAnimalesV<Animales.Perro>();
            contenedorPerros.Agregar(perro);
            contenedorPerros.MostrarElementos();
        }
    }
}