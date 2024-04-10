namespace Lab3.AlondraFlores;

public class Militar : Arma, Granada
{
    public string Nombre { get; set; }
    public int ID { get; set; }

    public Militar(string nombre, int id)
    {
        this.Nombre = nombre;
        this.ID = id;
    }

    public void Disparar()
    {
        Console.WriteLine("El militar ha Disparado con el arma");
    }

    public void Lanzar()
    {
        Console.WriteLine("El militar ha lanzado una granada");
    }
}