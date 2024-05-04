namespace NLayer.Architecture.Data;

public interface IFileRepository
{
    Task<T> ReadJsonFileAsync<T>(string filePath);
    Task WriteJsonFileAsync<T>(string filePath, T data);
    Task<List<T>> ReadJsonFileListAsync<T>(string filePath);
    Task AddElementToJsonFileAsync<T>(string filePath,T value);
}