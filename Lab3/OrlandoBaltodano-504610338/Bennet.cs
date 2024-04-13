
namespace Lab3.OrlandoBaltodano;

public class Bennet : IHabilidadDefinitiva , IHabilidadElemental
{
    public string Nombre { get; set; }
    public int Vida { get; set; }

    protected Bennet(string nombre,int vida) 
    {
        this.Nombre = nombre;
        this.Vida = vida;
    }

    public void AtaqueElemental()
    {
        throw new NotImplementedException();
    }

    public void Ataque_Definitivo()
    {
        throw new NotImplementedException();
    }
}
