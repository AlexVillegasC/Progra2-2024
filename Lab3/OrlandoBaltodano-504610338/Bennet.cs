
namespace Lab3.OrlandoBaltodano;

<<<<<<< HEAD
public class Bennet : IHabilidadDefinitiva, IHabilidadElemental
=======
public class Bennet : IHabilidadDefinitiva , IHabilidadElemental
>>>>>>> e45abd7 ([lab3] Orlando-Baltodano)
{
    public string Nombre { get; set; }
    public int Vida { get; set; }

<<<<<<< HEAD
    protected Bennet(string nombre, int vida)
=======
    protected Bennet(string nombre,int vida) 
>>>>>>> e45abd7 ([lab3] Orlando-Baltodano)
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
