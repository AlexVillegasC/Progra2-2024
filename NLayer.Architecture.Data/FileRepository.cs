using Newtonsoft.Json;

namespace NLayer.Architecture.Data;

public class FileRepository : IFileRepository
{
    public async Task<T> ReadJsonFileAsync<T>(string filePath)
    {
        // Verificar si el archivo existe
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"Error: El archivo no existe en la ruta especificada: {filePath}");
            throw new FileNotFoundException($"El archivo no existe: {filePath}");
        }

        using StreamReader reader = new StreamReader(filePath);
        string json = await reader.ReadToEndAsync();
        return JsonConvert.DeserializeObject<T>(json);

       
    }
    public async Task<List<T>> ReadListJsonAsync<T>(string filePath)
    {
        using StreamReader reader = new StreamReader(filePath);
        string list = await reader.ReadToEndAsync();
        return JsonConvert.DeserializeObject<List<T>>(list);
    }

    public async Task<List<T>> ReadJsonFileListAsync<T>(string filePath)
    {
        using StreamReader reader = new StreamReader(filePath);
        string json = await reader.ReadToEndAsync();
        return JsonConvert.DeserializeObject<List<T>>(json);
    }

    public async Task WriteJsonFileAsync<T>(string filePath, T data)
    {
        string json = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);
        using StreamWriter writer = new StreamWriter(filePath);
        await writer.WriteAsync(json);
    }
}