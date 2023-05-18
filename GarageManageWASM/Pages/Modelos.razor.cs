using GarageManagerRazorLib.Interfaces;
using GarageManagerRazorLib.Models;
using GarageManagerRazorLib.Services;
using Microsoft.AspNetCore.Components;

namespace GarageManageWASM.Pages;

public partial class Modelos : IPage<Modelo>
{
    [Inject]
    public ServiceAbstract<Modelo>? ModeloService { get; set; }

    public IQueryable<Modelo>? IQueryableModelos { get; set; } = new List<Modelo>().AsQueryable();
    protected Modelo ModeloAtual { get; set; } = new Modelo();

    protected override async Task OnInitializedAsync()
    {
        if (ModeloService is null) throw new ArgumentNullException();

        IQueryableModelos = (await ModeloService.Ler(null)).AsQueryable();
        ModeloAtual = new Modelo();
    }

    public async Task Apagar(Modelo entidade)
    {
        if (ModeloService is null) throw new ArgumentNullException();
        if (entidade is null) throw new ArgumentNullException();
        if (string.IsNullOrWhiteSpace(entidade.Nome)) throw new ArgumentException();

        ModeloAtual = entidade;
        await ModeloService.Excluir(entidade.Id);
        await OnInitializedAsync();
        await InvokeAsync(() => StateHasChanged());
    }

    public async Task Editar(Modelo entidade)
    {
        if (ModeloService is null) throw new ArgumentNullException();
        if (entidade is null) throw new ArgumentNullException();
        if (string.IsNullOrWhiteSpace(entidade.Nome)) throw new ArgumentException();

        ModeloAtual = entidade;
        await InvokeAsync(() => StateHasChanged());
    }

    public async Task Salvar()
    {
        if (ModeloService is null) throw new ArgumentNullException();
        if (ModeloAtual is null) throw new ArgumentNullException();
        if (string.IsNullOrWhiteSpace(ModeloAtual.Nome)) throw new ArgumentException();

        await ModeloService.Criar(ModeloAtual);
        await OnInitializedAsync();
    }
}

