using GarageManagerLib.Models;
using GarageManagerLib.Services;
using GarageManageWASM;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<ServiceAbstract<Marca>>(_ => new MarcaService(new HttpClient(), "https://localhost:7134/api/marca"));
builder.Services.AddScoped<ServiceAbstract<Modelo>>(_ => new ModeloService(new HttpClient(), "https://localhost:7134/api/modelo"));
builder.Services.AddScoped<ServiceAbstract<Veiculo>>(_ => new VeiculoService(new HttpClient(), "https://localhost:7134/api/veiculo"));
builder.Services.AddScoped<ServiceAbstract<Cliente>>(_ => new ClienteService(new HttpClient(), "https://localhost:7134/api/cliente"));

await builder.Build().RunAsync();
