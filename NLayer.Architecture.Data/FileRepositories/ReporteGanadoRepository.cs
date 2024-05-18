using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.Models.RegistroGanado;
using NLayer.Architecture.Data;

namespace NLayer.Architecture.Data.FileRepositories
{
    public class ReporteRegistroGanadoRepository : FileRepository, IReporteRegistroGanadoRepository
    {
        private string _RegistroGanadoVirtualPath = "RegistroGanado.json";
        private string _RegistroVacunasVirtualPath = "Registro_de_Vacunas.json";
        private string _RegistroVeterinarioVirtualPath = "RegistroVeterinario.json";

        private string FolderPath { get; set; }

        public ReporteRegistroGanadoRepository(IConfiguration Configuration)
        {
            FolderPath = $"{Configuration["Folders::RegistroGanado"]}";
            _RegistroGanadoVirtualPath = FolderPath + _RegistroGanadoVirtualPath;
            _RegistroVacunasVirtualPath = FolderPath + _RegistroVacunasVirtualPath;
            _RegistroVeterinarioVirtualPath = FolderPath + _RegistroVeterinarioVirtualPath;
        }

        public async Task<List<Registro_de_Vacunas>> GetRegistroVacunas()
        {
            return await ReadListJsonAsync<Registro_de_Vacunas>(_RegistroVacunasVirtualPath);
        }

        public async Task<List<RegistroGanado>> GetRegistroGanado()
        {
            return await ReadListJsonAsync<RegistroGanado>(_RegistroGanadoVirtualPath);
        }

        public async Task<List<RegistroVeterinario>> GetRegistroVeterinario()
        {
            return await ReadListJsonAsync<RegistroVeterinario>(_RegistroVeterinarioVirtualPath);
            
        }
    }
}