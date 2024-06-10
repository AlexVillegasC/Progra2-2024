using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.Models.RegistroGanado;
using NLayer.Architecture.Bussines.ReporteClima;
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
            FolderPath = $"{Configuration["Folders:RegistroGanado"]}";
            _RegistroGanadoVirtualPath = FolderPath + _RegistroGanadoVirtualPath;
            _RegistroVacunasVirtualPath = FolderPath + _RegistroVacunasVirtualPath;
            _RegistroVeterinarioVirtualPath = FolderPath + _RegistroVeterinarioVirtualPath;
        }

        public async Task<List<Ganado>> GetRegistroGanado()
        {
            return await ReadListJsonAsync<Ganado>(_RegistroGanadoVirtualPath);
        }

        public async Task AddGanado (Ganado ganado)
        {
            List<Ganado> elementos = await ReadJsonFileAsync<List<Ganado>>(_RegistroGanadoVirtualPath);
            if (elementos != null)
            {
                elementos.Add(ganado);
                await WriteJsonFileAsync(_RegistroGanadoVirtualPath, elementos);
            }
        }

        public async Task <bool> UpdateGanado (IEnumerable<Ganado> ganado)
        {
            List <Ganado> elementos = ganado.ToList();
            try{
                await WriteJsonFileAsync(_RegistroGanadoVirtualPath, elementos);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async Task <bool> DeleteGanado ()
        {
            List<Ganado> elementos = new();
            try{
                await WriteJsonFileAsync(_RegistroGanadoVirtualPath, elementos);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public async Task<List<RegistroVeterinario>> GetRegistroVeterinario()
        {
            return await ReadListJsonAsync<RegistroVeterinario>(_RegistroVeterinarioVirtualPath);
        }

        public async Task AddRegistroVeterinario(RegistroVeterinario registroVeterinario)
        {
            List<RegistroVeterinario> elementos = await ReadJsonFileAsync<List<RegistroVeterinario>>(_RegistroVeterinarioVirtualPath);
            if (elementos != null)
            {
                elementos.Add(registroVeterinario);
                await WriteJsonFileAsync(_RegistroVeterinarioVirtualPath, elementos);
            }
        }
        public async Task<bool> UpdateRegistroVeterinario(IEnumerable<RegistroVeterinario> registroVeterinario)
        {
            List<RegistroVeterinario> elementos = registroVeterinario.ToList();
            try
            {
                await WriteJsonFileAsync(_RegistroVeterinarioVirtualPath, elementos);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async Task<bool> DeleteRegistroVeterinario()
        {
            List<RegistroVeterinario> elementos = new();
            try
            {
                await WriteJsonFileAsync(_RegistroVeterinarioVirtualPath, elementos);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Registro_de_Vacunas>> GetRegistroVacunas()
        {
            return await ReadListJsonAsync<Registro_de_Vacunas>(_RegistroVacunasVirtualPath);
        }

        public async Task AddRegistroVacunas(Registro_de_Vacunas registro_De_Vacunas)
        {
            List<Registro_de_Vacunas> elementos = await ReadJsonFileAsync<List<Registro_de_Vacunas>>(_RegistroVacunasVirtualPath);
            if (elementos != null)
            {
                elementos.Add(registro_De_Vacunas);
                await WriteJsonFileAsync(_RegistroVacunasVirtualPath, elementos);
            }
        }
        public async Task<bool> UpdateVacunas(IEnumerable<Registro_de_Vacunas> registro_De_Vacunas)
        {
            List<Registro_de_Vacunas> elementos = registro_De_Vacunas.ToList();
            try
            {
                await WriteJsonFileAsync(_RegistroVacunasVirtualPath, elementos);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async Task<bool> DeleteVacunas()
        {
            List<Registro_de_Vacunas> elementos = new();
            try
            {
                await WriteJsonFileAsync(_RegistroVacunasVirtualPath, elementos);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
