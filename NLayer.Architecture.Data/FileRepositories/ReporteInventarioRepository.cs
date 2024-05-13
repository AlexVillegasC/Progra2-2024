using NLayer.Architecture.Data;
using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.ReporteInventario;


<<<<<<< HEAD
=======

>>>>>>> 6e723fd (Creacion de los servicios de maquinaria)
namespace DataAccess.Layer.FileRepositories;
public class ReporteInventarioRepository : FileRepository, IReporteInventarioRepository
{
    //esta la ruta para acceder a los archivos json
    private string MaquinariaVirtualPath = "Maquinaria.json";
<<<<<<< HEAD
    private string HerramientasVirtualPath = "Herramientas.json";
    private string MantenimientoVirtualPath = "Mantenimiento.json";
=======

>>>>>>> 6e723fd (Creacion de los servicios de maquinaria)

    // es una propiedad privada que almacena la ruta de la carpeta donde se encuentran los archivos JSON que contienen los datos
    private string FolderPath { get; set; }

    //constructor de la clase que accede a la configuracion de la aplicacion
    public ReporteInventarioRepository(IConfiguration configuration)
    {
        FolderPath = $"{configuration["Folders:MaquinariaAgricola"]}";
        MaquinariaVirtualPath = FolderPath + MaquinariaVirtualPath;
<<<<<<< HEAD
        HerramientasVirtualPath = FolderPath + HerramientasVirtualPath;
        MantenimientoVirtualPath = FolderPath + MantenimientoVirtualPath;
    }

    //metodo para leer el archivo json y los delvuelve como un onjeto



=======
    }
    //metodo para leer el archivo json y los delvuelve como un onjeto
>>>>>>> 6e723fd (Creacion de los servicios de maquinaria)
    public async Task<Maquinaria> GetMaquinaria()
    {
        return await ReadJsonFileAsync<Maquinaria>(MaquinariaVirtualPath);
    }
<<<<<<< HEAD

    public async Task<Herramientas> GetHerramientas()
    {
        return await ReadJsonFileAsync<Herramientas>(HerramientasVirtualPath); 
    }

    

    public  async Task<Mantenimiento> GetMantenimiento()
    {
        return await ReadJsonFileAsync<Mantenimiento>(MantenimientoVirtualPath);
    }
}




=======
}


>>>>>>> 6e723fd (Creacion de los servicios de maquinaria)
/*FolderPath = $"{Configuration["Folders:Clima"]}";: En esta línea, se está utilizando la configuración proporcionada
 * para acceder a la ruta de la carpeta donde se almacenan los archivos */