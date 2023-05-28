using GarageManagerRazorLib.Interfaces;
using GarageManagerRazorLib.Models;
using GarageManagerRazorLib.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace GarageManageWASM.Pages;

public partial class Marcas : IPage<Marca>
{
    [Inject]
    public ServiceAbstract<Marca, Marca>? MarcaService { get; set; }

    public IQueryable<Marca>? IQueryableMarcas { get; set; } = new List<Marca>().AsQueryable();
    protected Marca MarcaAtual { get; set; } = new Marca();

    protected ErrorBoundary? Error { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (MarcaService is null) throw new ArgumentNullException();

        IQueryableMarcas = (await MarcaService.Ler(null)).AsQueryable();
        MarcaAtual = new Marca();
    }

    public async Task Salvar()
    {
        if (MarcaService is null) throw new ArgumentNullException();
        if (MarcaAtual is null) throw new ArgumentNullException();
        if (string.IsNullOrWhiteSpace(MarcaAtual.Nome)) throw new ArgumentException();

        await MarcaService.Salvar(MarcaAtual);
        await OnInitializedAsync();
    }

    public async Task Editar(Marca entidade)
    {
        if (MarcaService is null) throw new ArgumentNullException();
        if (entidade is null) throw new ArgumentNullException();
        if (string.IsNullOrWhiteSpace(entidade.Nome)) throw new ArgumentException();

        MarcaAtual = entidade;
        await InvokeAsync(() => StateHasChanged());
    }

    public async Task Apagar(Marca entidade)
    {
        if (MarcaService is null) throw new ArgumentNullException();
        if (entidade is null) throw new ArgumentNullException();
        if (string.IsNullOrWhiteSpace(entidade.Nome)) throw new ArgumentException();

        MarcaAtual = entidade;
        await MarcaService.Excluir(entidade.Id);
        await OnInitializedAsync();
        await InvokeAsync(() => StateHasChanged());
    }

    protected async Task TratarErro()
    {
        if (Error is null) return;

        Error.Recover();
        await InvokeAsync(() => StateHasChanged());
    }
}
