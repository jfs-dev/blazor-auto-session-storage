using blazor_auto_session_storage.Client.Interfaces;

namespace blazor_auto_session_storage.Client.Services;

public class SessionStorageService(Blazored.SessionStorage.ISessionStorageService sessionStorageService) : ISessionStorageService
{
    public async Task SetItemAsync<T>(string key, T value) =>
        await sessionStorageService.SetItemAsync(key, value);

    public async Task<T> GetItemAsync<T>(string key) =>
        await sessionStorageService.GetItemAsync<T>(key);

    public async Task RemoveItemAsync(string key) =>
        await sessionStorageService.RemoveItemAsync(key);

    public async Task ClearAsync() =>
        await sessionStorageService.ClearAsync();
}
