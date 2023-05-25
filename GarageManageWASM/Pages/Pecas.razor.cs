using Blazorise;
using GarageManagerRazorLib.Interfaces;
using GarageManagerRazorLib.Models;
using GarageManagerRazorLib.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace GarageManageWASM.Pages;

public partial class Pecas : IPage<Peca>
{
    [Inject]
    public ServiceAbstract<Peca, Peca>? PecaService { get; set; }

    public IQueryable<Peca>? IQueryablePecas { get; set; } = new List<Peca>().AsQueryable();
    protected Peca PecaAtual { get; set; } = new Peca();

    protected ErrorBoundary? Error { get; set; }

    private Modal? ModalCRUD { get; set; }
    private Task ShowModal() => ModalCRUD!.Show();
    private Task HideModal() => ModalCRUD!.Hide();

    private Modal? ModalApagar { get; set; }
    private Task ShowModalApagar() => ModalApagar!.Show();
    private Task HideModalApagar() => ModalApagar!.Hide();

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

        await PecaService.Salvar(PecaAtual);
        await OnInitializedAsync();
        await HideModal();
    }

    public async Task Novo()
    {
        PecaAtual = new Peca();

        await ShowModal();
    }

    private async Task Cancelar()
    {
        await HideModal();
        PecaAtual = new Peca();
    }
}
