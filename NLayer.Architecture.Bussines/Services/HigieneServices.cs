﻿using DataAccess.Layer.FileRepositories;
using NLayer.Architecture.Bussines.Models.TheSillies;

namespace NLayer.Architecture.Bussines.Services;

public class HigieneServices : ICostosHigieneServices
{
    private readonly ICostosHigieneRepository _costosHigieneRepository;

    public HigieneServices(ICostosHigieneRepository costosHigieneRepository)
    {
        _costosHigieneRepository = costosHigieneRepository;
    }

    public async Task<TheSillies.CostosGenerales> GetCostosGenerales()
    {
        TheSillies.CostosGenerales reporteHigiene = new TheSillies.CostosGenerales();
        reporteHigiene.CostosHigiene = await _costosHigieneRepository.GetCostosHigiene();
        reporteHigiene.CostosAlimenticios = await _costosHigieneRepository.GetCostosAlimenticios();

        return reporteHigiene;
    }

    public async Task AddCostosHigiene (CostosHigiene costosHigiene)
    {
        await _costosHigieneRepository.AddCostosHigiene(costosHigiene);
    }
}