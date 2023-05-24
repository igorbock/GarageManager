using Blazorise;
using GarageManagerRazorLib.Interfaces;
using GarageManagerRazorLib.Models;
using GarageManagerRazorLib.Services;
using Microsoft.AspNetCore.Components;

namespace GarageManageWASM.Pages;

public partial class Marcas : IPage<Marca>
{
    [Inject]
    public ServiceAbstract<Marca, Marca>? MarcaService { get; set; }

    public List<Marca>? IQueryableMarcas { get; set; }
    protected Marca? MarcaAtual { get; set; } = new Marca();

    private Modal? ModalCRUD { get; set; }
    private Task ShowModal() => ModalCRUD!.Show();
    private Task HideModal() => ModalCRUD!.Hide();

    private Modal? ModalApagar { get; set; }
    private Task ShowModalApagar() => ModalApagar!.Show();
    private Task HideModalApagar() => ModalApagar!.Hide();

    protected override async Task OnInitializedAsync()
    {
        if (MarcaService is null) throw new ArgumentNullException();

        IQueryableMarcas = (await MarcaService.Ler(null)).ToList();
        MarcaAtual = new Marca();
        await base.OnInitializedAsync();
    }

    private async Task Cancelar()
    {
        await HideModal();
        MarcaAtual = new Marca();
    }

    private async Task Novo()
    {
        MarcaAtual = new Marca();
        await ShowModal();
    }

    public async Task Salvar()
    {
        if (MarcaService is null) throw new ArgumentNullException();
        if (MarcaAtual is null) throw new ArgumentNullException();
        if (string.IsNullOrWhiteSpace(MarcaAtual.Nome)) throw new ArgumentException();

        await MarcaService.Salvar(MarcaAtual);
        await OnInitializedAsync();
        await HideModal();
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
        await HideModalApagar();
    }
}
