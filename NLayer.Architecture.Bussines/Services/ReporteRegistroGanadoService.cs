using DataAccess.Layer.FileRepositories;
using Newtonsoft.Json.Linq;
using NLayer.Architecture.Bussines.Models.RegistroGanado;
using NLayer.Architecture.Bussines.RegistroGanado;
using NLayer.Architecture.Data.FileRepositories;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace NLayer.Architecture.Bussines.Services;
public class ReporteRegistroGanadoService : IReporteRegistroGanadoService
    {
        private readonly IReporteRegistroGanadoRepository _reporteGanadoRepo;

        public ReporteRegistroGanadoService(IReporteRegistroGanadoRepository reporteRegistroGanadoRepository)
        {
            _reporteGanadoRepo = reporteRegistroGanadoRepository;
        }

        public async Task<LoteDeGanado> GetRegistroGanado()
        {
            LoteDeGanado miRegistro = new()
            {
                listaGanado = await _reporteGanadoRepo.GetRegistroGanado(),
                ListaRegistroVet = await _reporteGanadoRepo.GetRegistroVeterinario()
            };

            return miRegistro;
        }

        public async Task AddGanado(Ganado ganado)
        {
            await _reporteGanadoRepo.AddGanado(ganado);
        }

        public async Task<bool> UpdateGanado(IEnumerable<Ganado> ganado)
        {
            return await _reporteGanadoRepo.UpdateGanado(ganado);
        }

        public async Task<bool> DeleteGanado()
        {
            return await _reporteGanadoRepo.DeleteGanado();
        }
    }