using ArrangementData.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SharedLibrary.ReservationRepositories1;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped<IReservationRepository,ReservationService>();

builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
});

await builder.Build().RunAsync();
