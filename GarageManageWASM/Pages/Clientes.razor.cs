using GarageManagerLib.Interfaces;
using GarageManagerLib.Models;
using GarageManagerLib.Services;
using Microsoft.AspNetCore.Components;

namespace GarageManageWASM.Pages;

public partial class Clientes : IPage<Cliente>
{
    [Inject]
    public ServiceAbstract<Cliente>? ClienteService { get; set; }

    public IQueryable<Cliente>? IQueryableCliente { get; set; } = new List<Cliente>().AsQueryable();
    protected Cliente ClienteAtual { get; set; } = new Cliente();

    protected override async Task OnInitializedAsync()
    {
        if (ClienteService is null) throw new ArgumentNullException();

        IQueryableCliente = (await ClienteService.Ler(null)).AsQueryable();
        ClienteAtual = new Cliente();
    }

    public async Task Apagar(Cliente entidade)
    {
        if (ClienteService is null) throw new ArgumentNullException();
        if (entidade is null) throw new ArgumentNullException();
        if (string.IsNullOrWhiteSpace(entidade.Nome)) throw new ArgumentException();

        ClienteAtual = entidade;
        await ClienteService.Excluir(entidade.Id);
        await OnInitializedAsync();
        await InvokeAsync(() => StateHasChanged());
    }

    public async Task Editar(Cliente entidade)
    {
        if (ClienteService is null) throw new ArgumentNullException();
        if (entidade is null) throw new ArgumentNullException();
        if (string.IsNullOrWhiteSpace(entidade.Nome)) throw new ArgumentException();

        ClienteAtual = entidade;
        await InvokeAsync(() => StateHasChanged());
    }

    public async Task Salvar()
    {
        if (ClienteService is null) throw new ArgumentNullException();
        if (ClienteAtual is null) throw new ArgumentNullException();
        if (string.IsNullOrWhiteSpace(ClienteAtual.Nome)) throw new ArgumentException();

        await ClienteService.Criar(ClienteAtual);
        await OnInitializedAsync();
    }
}

