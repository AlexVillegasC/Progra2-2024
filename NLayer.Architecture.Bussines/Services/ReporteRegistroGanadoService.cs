using DataAccess.Layer.FileRepositories;
using Newtonsoft.Json.Linq;
using NLayer.Architecture.Bussines.RegistroGanado;
using NLayer.Architecture.Data.FileRepositories;
using System.Collections.Generic;

namespace NLayer.Architecture.Bussines.Services;

public class ReporteRegistroGanadoService : IReporteRegistroGanadoService
{
    private readonly IReporteRegistroGanadoRepository _ReporteGanadoRepo;

    public ReporteRegistroGanadoService(IReporteRegistroGanadoRepository reporteRegistroGanadoRepository)
    {
        _ReporteGanadoRepo = reporteRegistroGanadoRepository;
    }

    public async Task<RegistroGanado.LoteDeGanado> GetRegistroGanado()
    {
        RegistroGanado.LoteDeGanado miRegistro = new RegistroGanado.LoteDeGanado();
        miRegistro.listaGanado = await _ReporteGanadoRepo.GetRegistroGanado();
        miRegistro.listaGanadoVacunas = await _ReporteGanadoRepo.GetRegistroVacunas();
        miRegistro.ListaRegistroVet = await _ReporteGanadoRepo.GetRegistroVacunasVet();

        return miRegistro;
    }

}