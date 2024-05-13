using NLayer.Architecture.Data;
using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.ReporteInventario;



namespace DataAccess.Layer.FileRepositories;
public class ReporteInventarioRepository : FileRepository, IReporteInventarioRepository
{
    //esta la ruta para acceder a los archivos json
    private string MaquinariaVirtualPath = "Maquinaria.json";


    // es una propiedad privada que almacena la ruta de la carpeta donde se encuentran los archivos JSON que contienen los datos
    private string FolderPath { get; set; }

    //constructor de la clase que accede a la configuracion de la aplicacion
    public ReporteInventarioRepository(IConfiguration configuration)
    {
        FolderPath = $"{configuration["Folders:MaquinariaAgricola"]}";
        MaquinariaVirtualPath = FolderPath + MaquinariaVirtualPath;
    }
    //metodo para leer el archivo json y los delvuelve como un onjeto
    public async Task<Maquinaria> GetMaquinaria()
    {
        return await ReadJsonFileAsync<Maquinaria>(MaquinariaVirtualPath);
    }
}


/*FolderPath = $"{Configuration["Folders:Clima"]}";: En esta línea, se está utilizando la configuración proporcionada
 * para acceder a la ruta de la carpeta donde se almacenan los archivos */