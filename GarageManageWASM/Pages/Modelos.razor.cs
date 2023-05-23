using GarageManagerRazorLib.DTOs;
using GarageManagerRazorLib.Interfaces;
using GarageManagerRazorLib.Models;
using GarageManagerRazorLib.Services;
using Microsoft.AspNetCore.Components;

namespace GarageManageWASM.Pages;

public partial class Modelos : IPage<ModeloDTO>
{
    [Inject]
    public ServiceAbstract<Modelo, ModeloDTO>? ModeloService { get; set; }
    [Inject]
    public ServiceAbstract<Marca, Marca>? MarcaService { get; set; }

    public IQueryable<ModeloDTO>? IQueryableModelos { get; set; } = new List<ModeloDTO>().AsQueryable();
    public IQueryable<Marca>? IQueryableMarcas { get; set; } = new List<Marca>().AsQueryable();
    protected Modelo ModeloAtual { get; set; } = new Modelo();
    protected Marca MarcaAtual { get; set; } = new Marca();

    protected override async Task OnInitializedAsync()
    {
        if (ModeloService is null) throw new ArgumentNullException();
        if (MarcaService is null) throw new ArgumentNullException();

        IQueryableModelos = (await ModeloService.Ler(null)).AsQueryable();
        IQueryableMarcas = (await MarcaService.Ler(null)).AsQueryable();
        ModeloAtual = new Modelo();
        MarcaAtual = new Marca();
    }

    public async Task Apagar(ModeloDTO entidade)
    {
        if (ModeloService is null) throw new ArgumentNullException();
        if (entidade is null) throw new ArgumentNullException();
        if (string.IsNullOrWhiteSpace(entidade.Nome)) throw new ArgumentException();

        ModeloAtual = new Modelo { Id = entidade.Id, Nome = entidade.Nome, IdMarca = entidade.IdMarca, Marca = new Marca { Id = entidade.Id, Nome = entidade.Marca } };
        await ModeloService.Excluir(entidade.Id);
        await OnInitializedAsync();
        await InvokeAsync(() => StateHasChanged());
    }

    public async Task Editar(ModeloDTO entidade)
    {
        if (ModeloService is null) throw new ArgumentNullException();
        if (entidade is null) throw new ArgumentNullException();
        if (string.IsNullOrWhiteSpace(entidade.Nome)) throw new ArgumentException();

        ModeloAtual = new Modelo { Id = entidade.Id, Nome = entidade.Nome, IdMarca = entidade.IdMarca, Marca = new Marca { Id = entidade.IdMarca, Nome = entidade.Marca } };
        MarcaAtual = ModeloAtual.Marca;
        await InvokeAsync(() => StateHasChanged());
    }

    private void VerificaNullable(ServiceAbstract<Modelo, ModeloDTO>? service, Modelo? entidade)
    {
        if (service is null) throw new ArgumentNullException();
        if (entidade is null) throw new ArgumentNullException();
        if (string.IsNullOrWhiteSpace(entidade.Nome)) throw new ArgumentException();
    }

    public async Task Salvar()
    {
        VerificaNullable(ModeloService, ModeloAtual);

        ModeloAtual.IdMarca = MarcaAtual.Id;
        ModeloAtual.Marca = null;
        await ModeloService!.Salvar(ModeloAtual);
        await OnInitializedAsync();
    }

    public Task Novo()
    {
        ModeloAtual = new Modelo();
        MarcaAtual = new Marca();

        return Task.CompletedTask;
    }
}

