namespace blazor_auto_session_storage.Client.Interfaces;

public interface ISessionStorageService
{
    Task SetItemAsync<T>(string key, T value);
    Task<T> GetItemAsync<T>(string key);
    Task RemoveItemAsync(string key);
    Task ClearAsync();
}
