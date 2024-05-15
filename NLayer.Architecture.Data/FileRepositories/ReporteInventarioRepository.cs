using NLayer.Architecture.Data;
using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.ReporteInventario;
using NLayer.Architecture.Bussines.Models.ControlMaquinaria;




<<<<<<< HEAD

<<<<<<< HEAD
=======

<<<<<<< HEAD
>>>>>>> 6e723fd (Creacion de los servicios de maquinaria)
=======
=======
>>>>>>> b9342b3 (Creacion de los servicios de maquinaria)
>>>>>>> 148fca9 (Creacion de los servicios de maquinaria)
namespace DataAccess.Layer.FileRepositories;
public class ReporteInventarioRepository : FileRepository, IReporteInventarioRepository
{
    //esta la ruta para acceder a los archivos json
    private string MaquinariaVirtualPath = "Maquinaria.json";
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    private string HerramientasVirtualPath = "Herramientas.json";
    private string MantenimientoVirtualPath = "Mantenimiento.json";
=======
=======
    private string HerramientasVirtualPath = "Herramientas.json";
>>>>>>> 2366e09 (Herramientas)
=======
    private string HerramientasVirtualPath = "Herramientas.json";
=======
>>>>>>> b9342b3 (Creacion de los servicios de maquinaria)
>>>>>>> 148fca9 (Creacion de los servicios de maquinaria)
=======
    private string HerramientasVirtualPath = "Herramientas.json";
=======
>>>>>>> b9342b3 (Creacion de los servicios de maquinaria)
=======
    private string HerramientasVirtualPath = "Herramientas.json";
>>>>>>> d564e34 (Herramientas)
>>>>>>> 0d03d42 (Herramientas)

>>>>>>> 6e723fd (Creacion de los servicios de maquinaria)

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
<<<<<<< HEAD
=======
>>>>>>> 148fca9 (Creacion de los servicios de maquinaria)
=======
>>>>>>> 0d03d42 (Herramientas)
        HerramientasVirtualPath = FolderPath + HerramientasVirtualPath;
        MantenimientoVirtualPath = FolderPath + MantenimientoVirtualPath;
    }

    //metodo para leer el archivo json y los delvuelve como un onjeto



=======
<<<<<<< HEAD
<<<<<<< HEAD
=======
        HerramientasVirtualPath = FolderPath + HerramientasVirtualPath;
>>>>>>> 2366e09 (Herramientas)
    }

    //metodo para leer el archivo json y los delvuelve como un onjeto
<<<<<<< HEAD
>>>>>>> 6e723fd (Creacion de los servicios de maquinaria)
=======



>>>>>>> 2366e09 (Herramientas)
=======
=======
=======
        HerramientasVirtualPath = FolderPath + HerramientasVirtualPath;
>>>>>>> d564e34 (Herramientas)
>>>>>>> 0d03d42 (Herramientas)
    }

    //metodo para leer el archivo json y los delvuelve como un onjeto
<<<<<<< HEAD
>>>>>>> b9342b3 (Creacion de los servicios de maquinaria)
<<<<<<< HEAD
>>>>>>> 148fca9 (Creacion de los servicios de maquinaria)
=======
=======



>>>>>>> d564e34 (Herramientas)
>>>>>>> 0d03d42 (Herramientas)
    public async Task<Maquinaria> GetMaquinaria()
    {
        return await ReadJsonFileAsync<Maquinaria>(MaquinariaVirtualPath);
    }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 2366e09 (Herramientas)
=======
>>>>>>> 148fca9 (Creacion de los servicios de maquinaria)
=======
=======
>>>>>>> d564e34 (Herramientas)
>>>>>>> 0d03d42 (Herramientas)

    public async Task<Herramientas> GetHerramientas()
    {
        return await ReadJsonFileAsync<Herramientas>(HerramientasVirtualPath); 
    }

    
<<<<<<< HEAD

    public  async Task<Mantenimiento> GetMantenimiento()
    {
        return await ReadJsonFileAsync<Mantenimiento>(MantenimientoVirtualPath);
    }
=======
>>>>>>> 2366e09 (Herramientas)
}




<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 148fca9 (Creacion de los servicios de maquinaria)
=======
}


<<<<<<< HEAD
>>>>>>> 6e723fd (Creacion de los servicios de maquinaria)
=======
>>>>>>> d0c9cc2 (Creacion de los servicios, interfaces,json de la clase mantenimiento)
=======
>>>>>>> b9342b3 (Creacion de los servicios de maquinaria)
>>>>>>> 148fca9 (Creacion de los servicios de maquinaria)
/*FolderPath = $"{Configuration["Folders:Clima"]}";: En esta línea, se está utilizando la configuración proporcionada
 * para acceder a la ruta de la carpeta donde se almacenan los archivos */