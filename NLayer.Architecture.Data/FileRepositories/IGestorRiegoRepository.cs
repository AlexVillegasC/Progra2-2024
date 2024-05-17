using NLayer.Architecture.Bussines.Models.Cultivo;
using NLayer.Architecture.Bussines.ReporteClima;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Architecture.Data.FileRepositories
{
    public interface IGestorRiegoRepository
    {
        Task<Cultivo> GetCultivo();
        Task<Temperature> GetTemperatures();
        Task<Moisture> GetMoisture();

    }
}
