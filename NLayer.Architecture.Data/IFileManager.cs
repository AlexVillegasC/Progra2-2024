namespace NLayer.Architecture.Data;

public interface IFileRepository
{
    Task<T> ReadJsonFileAsync<T>(string filePath);
    Task WriteJsonFileAsync<T>(string filePath, T data);
}