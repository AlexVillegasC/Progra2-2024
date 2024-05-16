using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Architecture.Data.FileRepositories
{
    public interface IGestorRiego
    {
        Task<Cultivo> GetCultivo();


    }
}
