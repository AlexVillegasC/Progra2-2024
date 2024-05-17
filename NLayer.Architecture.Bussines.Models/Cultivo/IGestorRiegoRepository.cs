using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Architecture.Bussines.Models.Cultivo;

public class IGestorRiegoRepository
{
    public Temperatura _Temperatura { get; set; }
    public HumedadSuelo _HumedadSuelo { get; set; }
    public Cultivo _Cultivo { get; set; }

}
