using GarageManagerLib.Models;
using GarageManagerLib.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace GarageManageWASM.Pages;

public partial class Marcas
{
    [Inject]
    public ServiceAbstract<Marca>? MarcaService { get; set; }

    public IQueryable<Marca>? IQueryableMarcas { get; set; } = new List<Marca>().AsQueryable();
    protected Marca MarcaAtual { get; set; } = new Marca();

    protected ErrorBoundary? Error { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (MarcaService is null) throw new ArgumentNullException();

        IQueryableMarcas = (await MarcaService.Ler(null)).AsQueryable();
        MarcaAtual = new Marca();
    }

    protected async Task Salvar()
    {
        if (MarcaService is null) throw new ArgumentNullException();
        if (MarcaAtual is null) throw new ArgumentNullException();
        if (string.IsNullOrWhiteSpace(MarcaAtual.Nome)) throw new ArgumentException();

        await MarcaService.Criar(MarcaAtual);
        await OnInitializedAsync();
    }

    protected async Task Editar(Marca p_marca)
    {
        if (MarcaService is null) throw new ArgumentNullException();
        if (p_marca is null) throw new ArgumentNullException();
        if (string.IsNullOrWhiteSpace(p_marca.Nome)) throw new ArgumentException();

        MarcaAtual = p_marca;
        await InvokeAsync(() => StateHasChanged());
    }

    protected async Task Apagar(Marca p_marca)
    {
        if (MarcaService is null) throw new ArgumentNullException();
        if (p_marca is null) throw new ArgumentNullException();
        if (string.IsNullOrWhiteSpace(p_marca.Nome)) throw new ArgumentException();

        MarcaAtual = p_marca;
        await MarcaService.Excluir(p_marca.Id);
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
