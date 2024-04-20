using Lab3.CristhiaAltamirano;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.CristhiaAltamirano_504570779;

public class Vehiculo : ITipoSUV, ITipoDeportivo
{
    public int Matricula { set; get; }

    public string Marca { set; get; }

    public string Modelo { set; get; }

    public int Año { set; get;  }

    protected Vehiculo(int matricula, string marca, string modelo, int año)
    {
        this.Matricula = matricula;
        this.Marca = marca;
        this.Modelo = modelo;
        this.Año = año;
    }

    public void AltaVelocidad()
    {
        throw new NotImplementedException();
    }

    public void ComodidadFamiliar()
    {
        throw new NotImplementedException();
    }
}
