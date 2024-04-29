using ArrangementData.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SharedLibrary.ArrangeRepositories;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped<IArrangeRepository, ArrangeService>();

builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
});

await builder.Build().RunAsync();
