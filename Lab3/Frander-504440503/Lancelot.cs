using System.Diagnostics.Contracts;

namespace Lab3.Frander_504440503;

public class Lancelot : IprimeraHabilidad, Iulti
{

    public int ataque { get; set; }
    public string nombre { get; set; }

    Lancelot (string _nombre, int _ataque)
    {
        this.nombre = _nombre;
        this.ataque = _ataque;
    }

    public void PrimerasHabilidad()
    {
        throw new NotImplementedException();
    }

    public void Ulti()
    {
        throw new NotImplementedException();
    }


}