namespace NLayer.Architecture.Data;

public interface IFileRepository
{
    Task<T> ReadJsonFileAsync<T>(string filePath);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    Task<List<T>> ReadListJsonAsync<T>(string filePath);
=======
    Task<List<T>> ReadJsonFileListAsync<T>(string filePath);
>>>>>>> d6270bd (Advilleg - Post Temperatures)
=======
    Task<List<T>> ReadJsonFileListAsync<T>(string filePath);
>>>>>>> d6270bd (Advilleg - Post Temperatures)
=======
    Task<List<T>> ReadJsonFileListAsync<T>(string filePath);
>>>>>>> d6270bd (Advilleg - Post Temperatures)
=======
    Task<List<T>> ReadJsonFileListAsync<T>(string filePath);
>>>>>>> d6270bd (Advilleg - Post Temperatures)
    Task WriteJsonFileAsync<T>(string filePath, T data);
}