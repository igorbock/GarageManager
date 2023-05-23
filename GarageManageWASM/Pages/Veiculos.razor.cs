using GarageManagerRazorLib.DTOs;
using GarageManagerRazorLib.Interfaces;
using GarageManagerRazorLib.Models;
using GarageManagerRazorLib.Services;
using Microsoft.AspNetCore.Components;

namespace GarageManageWASM.Pages;

public partial class Veiculos : IPage<VeiculoDTO>
{
    [Inject]
    public ServiceAbstract<Veiculo, VeiculoDTO>? VeiculoService { get; set; }
    [Inject]
    public ServiceAbstract<Modelo, ModeloDTO>? ModeloService { get; set; }
    [Inject]
    public ServiceAbstract<Marca, Marca>? MarcaService { get; set; }

    public IQueryable<VeiculoDTO>? IQueryableVeiculos { get; set; } = new List<VeiculoDTO>().AsQueryable();
    public IQueryable<ModeloDTO>? IQueryableModelos { get; set; } = new List<ModeloDTO>().AsQueryable();
    public IQueryable<Marca>? IQueryableMarcas { get; set; } = new List<Marca>().AsQueryable();
    protected Veiculo VeiculoAtual { get; set; } = new Veiculo();
    protected Modelo ModeloAtual { get; set; } = new Modelo();
    protected Marca MarcaAtual { get; set; } = new Marca();

    protected async override Task OnInitializedAsync()
    {
        if (VeiculoService is null) throw new ArgumentNullException();
        if (ModeloService is null) throw new ArgumentNullException();
        if (MarcaService is null) throw new ArgumentNullException();

        IQueryableVeiculos = (await VeiculoService.Ler(null)).AsQueryable();
        IQueryableModelos = (await ModeloService.Ler(null)).AsQueryable();
        IQueryableMarcas = (await MarcaService.Ler(null)).AsQueryable();
        VeiculoAtual = new Veiculo();
        ModeloAtual = new Modelo();
        MarcaAtual = new Marca();
    }

    public async Task Apagar(VeiculoDTO entidade)
    {
        if (VeiculoService is null) throw new ArgumentNullException();
        if (VeiculoAtual is null) throw new ArgumentNullException();

        VeiculoAtual = new Veiculo
        {
            Id = entidade.Id,
            Ano = entidade.Ano,
            Cor = entidade.Cor,
            IdModelo = entidade.IdModelo,
            Km = entidade.Km,
            Placa = entidade.Placa,
            Modelo = new Modelo
            {
                Id = entidade.IdModelo,
                IdMarca = entidade.IdMarca,
                Marca = new Marca { Id = entidade.IdMarca, Nome = entidade.Marca },
                Nome = entidade.Modelo
            }
        };
        await VeiculoService!.Excluir(entidade.Id);
        await OnInitializedAsync();
        await InvokeAsync(() => StateHasChanged());
    }

    public async Task Editar(VeiculoDTO entidade)
    {
        if (VeiculoService is null) throw new ArgumentNullException();
        if (VeiculoAtual is null) throw new ArgumentNullException();

        VeiculoAtual = new Veiculo
        {
            Id = entidade.Id,
            Ano = entidade.Ano,
            Cor = entidade.Cor,
            IdModelo = entidade.IdModelo,
            Km = entidade.Km,
            Placa = entidade.Placa,
            Modelo = new Modelo
            {
                Id = entidade.IdModelo,
                IdMarca = entidade.IdMarca,
                Marca = new Marca { Id = entidade.IdMarca, Nome = entidade.Marca },
                Nome = entidade.Modelo
            }
        };
        ModeloAtual = VeiculoAtual.Modelo;
        MarcaAtual = ModeloAtual.Marca;
        await InvokeAsync(() => StateHasChanged());
    }

    public async Task Salvar()
    {
        if (VeiculoService is null) throw new ArgumentNullException();
        if (VeiculoAtual is null) throw new ArgumentNullException();

        ModeloAtual.Marca = null;
        ModeloAtual.IdMarca = MarcaAtual.Id;
        VeiculoAtual.Modelo = null;
        VeiculoAtual.IdModelo = ModeloAtual.Id;
        await VeiculoService.Salvar(VeiculoAtual);
        await OnInitializedAsync();
    }

    public Task Novo()
    {
        ModeloAtual = new Modelo();
        MarcaAtual = new Marca();
        VeiculoAtual = new Veiculo();

        return Task.CompletedTask;
    }
}
