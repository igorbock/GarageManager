using GarageManagerRazorLib.Interfaces;
using GarageManagerRazorLib.Models;
using GarageManagerRazorLib.Services;
using Microsoft.AspNetCore.Components;

namespace GarageManageWASM.Pages;

public partial class Veiculos : IPage<Veiculo>
{
    [Inject]
    public ServiceAbstract<Veiculo, Veiculo>? VeiculoService { get; set; }

    public IQueryable<Veiculo>? IQueryableVeiculos { get; set; } = new List<Veiculo>().AsQueryable();
    protected Veiculo VeiculoAtual { get; set; } = new Veiculo();

    protected async override Task OnInitializedAsync()
    {
        if (VeiculoService is null) throw new ArgumentNullException();

        IQueryableVeiculos = (await VeiculoService.Ler(null)).AsQueryable();
        VeiculoAtual = new Veiculo();
    }

    public async Task Apagar(Veiculo entidade)
    {
        if (VeiculoService is null) throw new ArgumentNullException();
        if (VeiculoAtual is null) throw new ArgumentNullException();
        if (string.IsNullOrWhiteSpace(VeiculoAtual.Nome)) throw new ArgumentException();

        VeiculoAtual = entidade;
        await VeiculoService!.Excluir(entidade.Id);
        await OnInitializedAsync();
        await InvokeAsync(() => StateHasChanged());
    }

    public async Task Editar(Veiculo entidade)
    {
        if (VeiculoService is null) throw new ArgumentNullException();
        if (VeiculoAtual is null) throw new ArgumentNullException();
        if (string.IsNullOrWhiteSpace(VeiculoAtual.Nome)) throw new ArgumentException();

        VeiculoAtual = entidade;
        await InvokeAsync(() => StateHasChanged());
    }

    public async Task Salvar()
    {
        if (VeiculoService is null) throw new ArgumentNullException();
        if (VeiculoAtual is null) throw new ArgumentNullException();

        await VeiculoService.Salvar(VeiculoAtual);
        await OnInitializedAsync();
    }
}
