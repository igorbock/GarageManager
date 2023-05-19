using GarageManagerRazorLib.DTOs;
using GarageManagerRazorLib.Models;
using GarageManagerRazorLib.Services;
using GarageManageWASM;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<ServiceAbstract<Marca, Marca>>(_ => new MarcaService(new HttpClient(), "https://localhost:7134/api/marca"));
builder.Services.AddScoped<ServiceAbstract<Modelo, ModeloDTO>>(_ => new ModeloService(new HttpClient(), "https://localhost:7134/api/modelo"));
builder.Services.AddScoped<ServiceAbstract<Veiculo, Veiculo>>(_ => new VeiculoService(new HttpClient(), "https://localhost:7134/api/veiculo"));
builder.Services.AddScoped<ServiceAbstract<Cliente, Cliente>>(_ => new ClienteService(new HttpClient(), "https://localhost:7134/api/cliente"));
builder.Services.AddScoped<ServiceAbstract<Peca, Peca>>(_ => new PecaService(new HttpClient(), "https://localhost:7134/api/peca"));
builder.Services.AddScoped<ServiceAbstract<OrdemServico, OrdemServico>>(_ => new OrdemServicoService(new HttpClient(), "https://localhost:7134/api/ordemservico"));
builder.Services.AddScoped<ServiceAbstract<OrdemServicoPecas, OrdemServicoPecas>>(_ => new OrdemServicoPecasService(new HttpClient(), "https://localhost:7134/api/ordemservicopecas"));

await builder.Build().RunAsync();
