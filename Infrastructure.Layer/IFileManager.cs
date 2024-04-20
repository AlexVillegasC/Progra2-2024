namespace DataAccess.Layer;

public interface IFileManager
{
    Task<T> ReadJsonFileAsync<T>(string filePath);
    Task WriteJsonFileAsync<T>(string filePath, T data);
}
