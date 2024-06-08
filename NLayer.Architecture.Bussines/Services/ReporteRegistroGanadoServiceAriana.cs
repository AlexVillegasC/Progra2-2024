using DataAccess.Layer.FileRepositories;
using Newtonsoft.Json.Linq;
using NLayer.Architecture.Bussines.Models.RegistroGanado;
using NLayer.Architecture.Bussines.RegistroGanado;
using NLayer.Architecture.Data.FileRepositories;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace NLayer.Architecture.Bussines.Services;

public class ReporteRegistroGanadoServiceAriana : IReporteRegistroGanadoServiceAriana
{
    private readonly IReporteRegistroGanadoRepository _ReporteGanadoRepo;

    public ReporteRegistroGanadoServiceAriana(IReporteRegistroGanadoRepository reporteRegistroGanadoRepository)
    {
        _ReporteGanadoRepo = reporteRegistroGanadoRepository;
    }

    public async Task<RegistroGanado.LoteDeGanado> GetRegistroGanado()
    {
        RegistroGanado.LoteDeGanado miRegistro = new RegistroGanado.LoteDeGanado();
        miRegistro.listaGanado = await _ReporteGanadoRepo.GetRegistroGanado();
        miRegistro.listaGanadoVacunas = await _ReporteGanadoRepo.GetRegistroVacunas();
        miRegistro.ListaRegistroVet = await _ReporteGanadoRepo.GetRegistroVeterinario();

        return miRegistro;
    }

    public async Task Add_Ganado(Ganado ganado)
    {
        await _ReporteGanadoRepo.AddGanado(ganado);
    }

    public async Task<bool> Update_Ganado(IEnumerable<Ganado> ganado)
    {
        return await _ReporteGanadoRepo.UpdateGanado(ganado);
    }

    public async Task<bool> Delete_Ganado()
    {
        return await _ReporteGanadoRepo.DeleteGanado();
    }

}