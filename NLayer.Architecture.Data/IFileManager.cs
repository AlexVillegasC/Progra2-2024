namespace NLayer.Architecture.Data;

public interface IFileRepository
{
    Task<T> ReadJsonFileAsync<T>(string filePath);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 081ea19 (Advilleg - Post Temperatures)
    Task<List<T>> ReadListJsonAsync<T>(string filePath);
=======
    Task<List<T>> ReadJsonFileListAsync<T>(string filePath);
>>>>>>> d6270bd (Advilleg - Post Temperatures)
<<<<<<< HEAD
=======
    Task<List<T>> ReadJsonFileListAsync<T>(string filePath);
>>>>>>> d6270bd (Advilleg - Post Temperatures)
=======
>>>>>>> 081ea19 (Advilleg - Post Temperatures)
    Task WriteJsonFileAsync<T>(string filePath, T data);
}