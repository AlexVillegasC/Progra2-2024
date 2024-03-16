namespace Lab1.Cristhian_Altamirano;

public class Pokemon
{
    public  int Vida { get; set; } = 1000;

    public int Ataque { get; set; }

    public string Nombre { get; set; }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="Vida"></param>
       /// <param name="Ataque"></param>
       /// <param name="Nombre"></param>

    public Pokemon(int Vida, int Ataque, string Nombre)
    {
        this.Vida = Vida;
        this.Ataque = Ataque;
        Nombre = Nombre;
    }
}
