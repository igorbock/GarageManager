using GarageManagerLib.Interfaces;
using GarageManagerLib.Models;
using GarageManagerLib.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace GarageManageWASM.Pages;

public partial class Pecas : IPage<Peca>
{
    [Inject]
    public ServiceAbstract<Peca>? PecaService { get; set; }

    public IQueryable<Peca>? IQueryablePecas { get; set; } = new List<Peca>().AsQueryable();
    protected Peca PecaAtual { get; set; } = new Peca();

    protected ErrorBoundary? Error { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (PecaService is null) throw new ArgumentNullException();

        IQueryablePecas = (await PecaService.Ler(null)).AsQueryable();
        PecaAtual = new Peca();
    }

    public async Task Apagar(Peca entidade)
    {
        if (PecaService is null) throw new ArgumentNullException();
        if (entidade is null) throw new ArgumentNullException();

        PecaAtual = entidade;
        await PecaService.Excluir(entidade.Id);
        await OnInitializedAsync();
        await InvokeAsync(() => StateHasChanged());
    }

    public async Task Editar(Peca entidade)
    {
        if (PecaService is null) throw new ArgumentNullException();
        if (entidade is null) throw new ArgumentNullException();

        PecaAtual = entidade;
        await InvokeAsync(() => StateHasChanged());
    }

    public async Task Salvar()
    {
        if (PecaService is null) throw new ArgumentNullException();
        if (PecaAtual is null) throw new ArgumentNullException();

        await PecaService.Criar(PecaAtual);
        await OnInitializedAsync();
    }
}
