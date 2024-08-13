using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddBlazoredSessionStorage();
builder.Services.AddScoped<blazor_auto_session_storage.Client.Interfaces.ISessionStorageService, blazor_auto_session_storage.Client.Services.SessionStorageService>();

await builder.Build().RunAsync();
