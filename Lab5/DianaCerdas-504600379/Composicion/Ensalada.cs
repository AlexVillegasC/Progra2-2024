namespace Lab5.DianaCerdas_504600379.Composicion;

	public class Ensalada
	{
	public Ingredientes ingredientes { get; set; }

	public Ensalada()
	{
		ingredientes = new Ingredientes();
	}


}


//Ensalada ensalada = new Ensalada();
//Console.WriteLine($"ingredientes:{ensalada.ingredientes.ingre1 + " y "+ ensalada.ingredientes.ingre2}");
