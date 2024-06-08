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

    public async Task<List<GestionCultivo>> GetGestionCultivo()
    {
        return await ReadJsonFileAsync<List<GestionCultivo>>(_gestionCultivoVirtualPath);
    }

    public async Task<List<CoeficienteCultivo>> GetCoeficienteCultivo()
    {
        return await ReadJsonFileAsync<List<CoeficienteCultivo>>(_coeficienteCultivoVirtualPath);
    }

    public async Task<List<CultivoDatos>> GetCultivoDatos()
    {
        return await ReadJsonFileAsync<List<CultivoDatos>>(_cultivoDatosVirtualPath);
    }

    public async Task<List<Reservorio>> GetReservorio()
    {
        return await ReadJsonFileAsync<List<Reservorio>>(_reservorioVirtualPath);
    }

    public async Task AddGestionCultivo(GestionCultivo gestionCultivo)
    {
        List<GestionCultivo> elementos = await GetGestionCultivo();
        elementos.Add(gestionCultivo);
        await WriteJsonFileAsync(_gestionCultivoVirtualPath, elementos);
    }
    public async Task<bool> UpdateGestionCultivo(IEnumerable<GestionCultivo> gestionCultivo)
    {
        List<GestionCultivo> elementos = gestionCultivo.ToList();

        try
        {
            await WriteJsonFileAsync(_gestionCultivoVirtualPath, elementos);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> DeleteGestionCultivo()
    {
        try
        {
            await WriteJsonFileAsync(_gestionCultivoVirtualPath, new List<GestionCultivo>());
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task AddCultivoDatos(CultivoDatos cultivoDatos)
    {
        List<CultivoDatos> elementos = await GetCultivoDatos();
        elementos.Add(cultivoDatos);
        await WriteJsonFileAsync(_cultivoDatosVirtualPath, elementos);
    }
    public async Task<bool> UpdateCultivoDatos(IEnumerable<CultivoDatos> cultivoDatos)
    {
        List<CultivoDatos> elementos = cultivoDatos.ToList();

        try
        {
            await WriteJsonFileAsync(_cultivoDatosVirtualPath, elementos);
            return true;
        }
        catch
        {
            return false;
        }
    } 
    public async Task<bool> DeleteCultivo()
    {
        try
        {
            await WriteJsonFileAsync(_cultivoDatosVirtualPath, new List<CultivoDatos>());
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task AddReservorio(Reservorio reservorio)
    {
        List<Reservorio> elementos = await GetReservorio();
        elementos.Add(reservorio);
        await WriteJsonFileAsync(_reservorioVirtualPath, elementos);
    }
    public async Task<bool> UpdateReservorio(IEnumerable<Reservorio> reservorio)
    {
        List<Reservorio> elementos = reservorio.ToList();

        try
        {
            await WriteJsonFileAsync(_reservorioVirtualPath, elementos);
            return true;
        }
        catch
        {
            return false;
        }
    }
    public async Task<bool> DeleteReservorio()
    {
        try
        {
            await WriteJsonFileAsync(_reservorioVirtualPath, new List<Reservorio>());
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task AddCoeficienteCultivo(CoeficienteCultivo coeficienteCultivo)
    {
        List<CoeficienteCultivo> elementos = await GetCoeficienteCultivo();
        elementos.Add(coeficienteCultivo);
        await WriteJsonFileAsync(_coeficienteCultivoVirtualPath, elementos);
    }
    public async Task<bool> UpdateCoeficienteCultivo(IEnumerable<CoeficienteCultivo> coeficienteCultivo)
    {
        List<CoeficienteCultivo> elementos = coeficienteCultivo.ToList();

        try
        {
            await WriteJsonFileAsync(_coeficienteCultivoVirtualPath, elementos);
            return true;
        }
        catch
        {
            return false;
        }
    }
    public async Task<bool> DeleteCoeficienteCultivo()
    {
        try
        {
            await WriteJsonFileAsync(_coeficienteCultivoVirtualPath, new List<CoeficienteCultivo>());
            return true;
        }
        catch
        {
            return false;
        }
    }
}