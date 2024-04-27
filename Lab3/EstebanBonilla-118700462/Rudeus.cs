using Lab3.WaynerDíaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.EstebanBonilla_118700462;
public class Rudeus : Cumulonimbus, Canon
{
    public string Poder { get; set; }
    public string Nombre { get; set; }

    protected Rudeus(string Poder, string Nombre)
    {
        this.Poder = Poder;
        this.Nombre = Nombre;
    }
    public void Ultraman()
    {
        throw new NotImplementedException();
    }
    public void Ultravision()
    {
        throw new NotImplementedException();
    }

    public void Teletransportacion()
    {
        throw new NotImplementedException();
    }

    public void Cumulonimbus()
    {
        throw new NotImplementedException();
    }

    public void Canon()
    {
        throw new NotImplementedException();
    }
}

