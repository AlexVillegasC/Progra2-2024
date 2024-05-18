using NLayer.Architecture.Data;
using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.ReporteInventario;


<<<<<<< HEAD



<<<<<<< HEAD


=======
>>>>>>> b9342b3 (Creacion de los servicios de maquinaria)
=======
>>>>>>> 4b4602e (Creacion de los servicios, interfaces,json de la clase mantenimiento)
namespace DataAccess.Layer.FileRepositories;
public class ReporteInventarioRepository : FileRepository, IReporteInventarioRepository
{
    //esta la ruta para acceder a los archivos json
    private string MaquinariaVirtualPath = "Maquinaria.json";
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    private string HerramientasVirtualPath = "Herramientas.json";
=======
>>>>>>> b9342b3 (Creacion de los servicios de maquinaria)
=======
    private string HerramientasVirtualPath = "Herramientas.json";
>>>>>>> d564e34 (Herramientas)

=======
    private string MantenimientoVirtualPath = "Mantenimiento.json";
>>>>>>> 4b4602e (Creacion de los servicios, interfaces,json de la clase mantenimiento)

    // es una propiedad privada que almacena la ruta de la carpeta donde se encuentran los archivos JSON que contienen los datos
    private string FolderPath { get; set; }

    //constructor de la clase que accede a la configuracion de la aplicacion
    public ReporteInventarioRepository(IConfiguration configuration)
    {
        FolderPath = $"{configuration["Folders:MaquinariaAgricola"]}";
        MaquinariaVirtualPath = FolderPath + MaquinariaVirtualPath;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        HerramientasVirtualPath = FolderPath + HerramientasVirtualPath;
=======
        MantenimientoVirtualPath = FolderPath + MantenimientoVirtualPath;
>>>>>>> 4b4602e (Creacion de los servicios, interfaces,json de la clase mantenimiento)
    }

    //metodo para leer el archivo json y los delvuelve como un onjeto



=======
=======
        HerramientasVirtualPath = FolderPath + HerramientasVirtualPath;
>>>>>>> d564e34 (Herramientas)
    }

    //metodo para leer el archivo json y los delvuelve como un onjeto
<<<<<<< HEAD
>>>>>>> b9342b3 (Creacion de los servicios de maquinaria)
=======



>>>>>>> d564e34 (Herramientas)
    public async Task<Maquinaria> GetMaquinaria()
    {
        return await ReadJsonFileAsync<Maquinaria>(MaquinariaVirtualPath);
    }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> d564e34 (Herramientas)

    public async Task<Herramientas> GetHerramientas()
    {
        return await ReadJsonFileAsync<Herramientas>(HerramientasVirtualPath); 
    }

    
=======

    public  async Task<Mantenimiento> GetMantenimiento()
    {
        return await ReadJsonFileAsync<Mantenimiento>(MantenimientoVirtualPath);
    }
>>>>>>> 4b4602e (Creacion de los servicios, interfaces,json de la clase mantenimiento)
}




<<<<<<< HEAD
=======
}


>>>>>>> b9342b3 (Creacion de los servicios de maquinaria)
=======
>>>>>>> 4b4602e (Creacion de los servicios, interfaces,json de la clase mantenimiento)
/*FolderPath = $"{Configuration["Folders:Clima"]}";: En esta línea, se está utilizando la configuración proporcionada
 * para acceder a la ruta de la carpeta donde se almacenan los archivos */