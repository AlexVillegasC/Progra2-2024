using NLayer.Architecture.Data;
using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.ReporteInventario;



namespace DataAccess.Layer.FileRepositories;
public class ReporteInventarioRepository : FileRepository, IReporteInventarioRepository
{
    //esta la ruta para acceder a los archivos json
    private string MaquinariaVirtualPath = "Maquinaria.json";
    private string HerramientasVirtualPath = "Herramientas.json";
    private string MantenimientoVirtualPath = "Mantenimiento.json";

    // es una propiedad privada que almacena la ruta de la carpeta donde se encuentran los archivos JSON que contienen los datos
    private string FolderPath { get; set; }

    //constructor de la clase que accede a la configuracion de la aplicacion
    public ReporteInventarioRepository(IConfiguration configuration)
    {
        FolderPath = $"{configuration["Folders:MaquinariaAgricola"]}";
        MaquinariaVirtualPath = FolderPath + MaquinariaVirtualPath;
        HerramientasVirtualPath = FolderPath + HerramientasVirtualPath;
        MantenimientoVirtualPath = FolderPath + MantenimientoVirtualPath;
    }


    // Método para leer el archivo JSON que contiene datos de maquinaria y devolverlos como una lista de objetos Maquinaria
    public async Task<List<Maquinaria>> GetMaquinaria()
    {
        // Lee el contenido del archivo JSON utilizando el método ReadJsonFileAsync
        return await ReadJsonFileAsync<List<Maquinaria>>(MaquinariaVirtualPath);
    }


    // Método para agregar una nueva maquinaria al archivo JSON
    public async Task AddMaquinarias(Maquinaria maquinaria)
    {
        // Lee la lista actual de maquinarias del archivo JSON
        List<Maquinaria> elemento = await ReadJsonFileAsync<List<Maquinaria>>(MaquinariaVirtualPath);

        if(elemento != null)
        {
            elemento.Add(maquinaria);

            await WriteJsonFileAsync(MaquinariaVirtualPath, elemento);
        }
    }


    // Método para actualizar la lista de maquinarias en el archivo JSON
    public async Task<bool> UpdateMaquinaria(IEnumerable<Maquinaria> maquinaria)
    {
        // Convierte la colección de maquinarias en una lista
        List<Maquinaria> elementos = maquinaria.ToList();

        try
        {
            // Intenta escribir esta lista en el archivo JSON utilizando el método WriteJsonFileAsync
            await WriteJsonFileAsync(MaquinariaVirtualPath, elementos);
            return true;
        }catch(Exception genericException)
        {
            return false;
        }
    }

    // Método para eliminar todas las maquinarias del archivo JSON
    public async Task<bool> DeleteMaquinaria()
    {
        // Crea una nueva lista vacía de maquinarias
        List<Maquinaria> elementos = new();

        try
        {
            // Intenta escribir esta lista vacía en el archivo JSON utilizando el método WriteJsonFileAsync(si lo hace entonces el json estaria vacio)
            await WriteJsonFileAsync(MaquinariaVirtualPath, elementos);
            return true;

        }catch(Exception genericException)
        {
            return false;
        }

    }


    


    public async Task<List<Herramientas>> GetHerramientas()
    {
        return await ReadJsonFileAsync<List<Herramientas>>(HerramientasVirtualPath); 
    }


    public async Task AddHerramientas(Herramientas herramientas)
    {
        List<Herramientas> elemento = await ReadJsonFileAsync<List<Herramientas>>(HerramientasVirtualPath);

        if(elemento != null)
        {
        elemento.Add(herramientas);

            await WriteJsonFileAsync(HerramientasVirtualPath, elemento);
        }
    }


    public async Task<bool> UpdateHerramientas(IEnumerable<Herramientas> herramientas)
    {
        List<Herramientas> elementos= herramientas.ToList();

        try
        {
            await WriteJsonFileAsync(HerramientasVirtualPath, elementos);
            return true;
        }
        catch(Exception genericException)
        {
            return false;
        }
            
    } 


    public async Task<bool> DeleteHerramientas()
    {
        List<Herramientas> elementos = new();

        try
        {
            await WriteJsonFileAsync(HerramientasVirtualPath, elementos);
            return true;
        }
        catch(Exception genericException)
        {
            return false;
        }


    }

   



    public async Task<List<Mantenimiento>> GetMantenimiento()
    {   
        return await ReadJsonFileAsync<List<Mantenimiento>>(MantenimientoVirtualPath);
    }


    public async Task AddMantenimiento(Mantenimiento mantenimiento)
    {
        List<Mantenimiento> elemento = await ReadJsonFileAsync<List<Mantenimiento>>(MantenimientoVirtualPath);

        if (elemento != null)
        { 
        
        elemento.Add(mantenimiento);

            await WriteJsonFileAsync(MantenimientoVirtualPath, elemento);
        }
    }
    public async Task<bool> UpdateMantenimiento(IEnumerable<Mantenimiento> mantenimiento)
    {

        List<Mantenimiento> elementos = mantenimiento.ToList();


        try
        {

            await WriteJsonFileAsync(MantenimientoVirtualPath, elementos);
            return true;
        }
        catch (Exception genericException)
        {
            return false;
        }

    }




    public async Task<bool> DeleteMantenimiento()
    {
        
        List<Mantenimiento> elementos = new();

        try
        {
 
            await WriteJsonFileAsync(MantenimientoVirtualPath, elementos);
            return true;

        }
        catch (Exception genericException)
        {
            return false;
        }

    }



}


/*FolderPath = $"{Configuration["Folders:Clima"]}";: En esta línea, se está utilizando la configuración proporcionada
 * para acceder a la ruta de la carpeta donde se almacenan los archivos */