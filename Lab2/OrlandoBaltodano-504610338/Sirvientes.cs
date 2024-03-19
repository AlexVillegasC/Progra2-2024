
namespace Lab2.OrlandoBaltodano;

public abstract class Sirvientes
{
    public string Name { get; }
    public int HP { get; }
    public int Atack { get; }

    protected Sirvientes(string name, int hp, int atack)
    {

       this.Name = name;
       this. HP = hp;
       this. Atack = atack;
    }
    public abstract void Atacar();
    
    public virtual void Ultimate() {

        Console.WriteLine("Noble Phantasm");
    }


}
