using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.GestionCultivo;
using NLayer.Architecture.Data;
using System.ComponentModel.Design;

namespace DataAccess.Layer.FileRepositories;

public class CultivoRepository : FileRepository, ICultivoRepository
{
    private string _coeficienteCultivoVirtualPath = "CoeficienteCultivo.json";
    private string _cultivoDatosVirtualPath = "CultivoDatos.json";
    private string _gestionCultivoVirtualPath = "GestionCultivo.json";
    private string _reservorioVirtualPath = "reservorio.json";

    private string FolderPath { get; set; }

    public CultivoRepository(IConfiguration Configuration)
    {
        FolderPath = $"{Configuration["Folders:Cultivo"]}";
        _gestionCultivoVirtualPath = FolderPath + _gestionCultivoVirtualPath;
        _coeficienteCultivoVirtualPath = FolderPath + _coeficienteCultivoVirtualPath;
        _cultivoDatosVirtualPath = FolderPath + _cultivoDatosVirtualPath;
        _reservorioVirtualPath = FolderPath + _reservorioVirtualPath;
        //
    }

    public async Task<GestionCultivo> GetGestionCultivo()
    {
        return await ReadJsonFileAsync<GestionCultivo>(_gestionCultivoVirtualPath);
    }

    public async Task<CoeficienteCultivo> GetCoeficienteCultivo()
    {
        return await ReadJsonFileAsync<CoeficienteCultivo>(_coeficienteCultivoVirtualPath);
    }

    public async Task<CultivoDatos> GetCultivoDatos()
    {
        return await ReadJsonFileAsync<CultivoDatos>(_cultivoDatosVirtualPath);
    }

    public async Task<Reservorio> GetReservorio()
    {
        return await ReadJsonFileAsync<Reservorio>(_reservorioVirtualPath);
    }
}