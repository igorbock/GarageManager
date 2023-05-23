using GarageManagerRazorLib.Interfaces;
using GarageManagerRazorLib.Models;
using GarageManagerRazorLib.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using GarageManagerRazorLib.DTOs;
using GarageManagerRazorLib.Enums;

namespace GarageManageWASM.Pages;

public partial class OrdemServicos : IPage<OrdemServicoDTO>
{
    [Inject]
    public ServiceAbstract<OrdemServico, OrdemServicoDTO>? OrdemServicoService { get; set; }
    [Inject]
    public ServiceAbstract<Veiculo, VeiculoDTO>? VeiculoService { get; set; }
    [Inject]
    public ServiceAbstract<Cliente, Cliente>? ClienteService { get; set; }

    public IQueryable<OrdemServicoDTO>? IQueryableOrdemServicos { get; set; } = new List<OrdemServicoDTO>().AsQueryable();
    public IQueryable<VeiculoDTO>? IQueryableVeiculos { get; set; } = new List<VeiculoDTO>().AsQueryable();
    public IQueryable<Cliente>? IQueryableClientes { get; set; } = new List<Cliente>().AsQueryable();
    protected OrdemServico OrdemServicoAtual { get; set; } = new OrdemServico();
    protected Veiculo VeiculoAtual { get; set; } = new Veiculo();
    protected Cliente ClienteAtual { get; set; } = new Cliente();

    protected ErrorBoundary? Error { get; set; }
    protected Dictionary<int, string>? StatusOrdemServico { get; set; } = new Dictionary<int, string>();

    protected override async Task OnInitializedAsync()
    {
        if (OrdemServicoService is null) throw new ArgumentNullException();
        if (VeiculoService is null) throw new ArgumentNullException();
        if (ClienteService is null) throw new ArgumentNullException();

        IQueryableOrdemServicos = (await OrdemServicoService.Ler(null)).AsQueryable();
        IQueryableVeiculos = (await VeiculoService.Ler(null)).AsQueryable();
        IQueryableClientes = (await ClienteService.Ler(null)).AsQueryable();
        OrdemServicoAtual = new OrdemServico();
        VeiculoAtual = new Veiculo();
        ClienteAtual = new Cliente();

        if (StatusOrdemServico!.Count == 0)
            foreach(var status in Enum.GetNames(typeof(E_STATUS)))
                StatusOrdemServico!.Add((int)Enum.Parse<E_STATUS>(status), status);
    }

    public async Task Apagar(OrdemServicoDTO entidade)
    {
        if (OrdemServicoService is null) throw new ArgumentNullException();
        if (entidade is null) throw new ArgumentNullException();

        OrdemServicoAtual = new OrdemServico
        {
            Id = entidade.Id,
            Cliente = new Cliente { Id = entidade.IdCliente },
            Esperados = entidade.Esperados,
            Fim = entidade.Fim,
            IdCliente = entidade.IdCliente,
            IdVeiculo = entidade.IdVeiculo,
            Inicio = entidade.Inicio,
            Lavacao = entidade.Lavacao,
            Mecanico = entidade.Mecanico,
            Pagamento = entidade.Pagamento,
            Realizados = entidade.Realizados,
            Status = entidade.Status,
            Veiculo = new Veiculo { Id = entidade.IdVeiculo }
        };
        await OrdemServicoService.Excluir(entidade.Id);
        await OnInitializedAsync();
        await InvokeAsync(() => StateHasChanged());
    }

    public async Task Editar(OrdemServicoDTO entidade)
    {
        if (OrdemServicoService is null) throw new ArgumentNullException();
        if (entidade is null) throw new ArgumentNullException();

        OrdemServicoAtual = new OrdemServico
        {
            Id = entidade.Id,
            Cliente = new Cliente { Id = entidade.IdCliente },
            Esperados = entidade.Esperados,
            Fim = entidade.Fim,
            IdCliente = entidade.IdCliente,
            IdVeiculo = entidade.IdVeiculo,
            Inicio = entidade.Inicio,
            Lavacao = entidade.Lavacao,
            Mecanico = entidade.Mecanico,
            Pagamento = entidade.Pagamento,
            Realizados = entidade.Realizados,
            Status = entidade.Status,
            Veiculo = new Veiculo { Id = entidade.IdVeiculo }
        };
        VeiculoAtual = OrdemServicoAtual.Veiculo;
        ClienteAtual = OrdemServicoAtual.Cliente;
        await InvokeAsync(() => StateHasChanged());
    }

    public async Task Salvar()
    {
        if (OrdemServicoService is null) throw new ArgumentNullException();
        if (OrdemServicoAtual is null) throw new ArgumentNullException();

        OrdemServicoAtual.Cliente = null;
        OrdemServicoAtual.IdCliente = ClienteAtual.Id;
        OrdemServicoAtual.Veiculo = null;
        OrdemServicoAtual.IdVeiculo = VeiculoAtual.Id;
        await OrdemServicoService.Salvar(OrdemServicoAtual);
        await OnInitializedAsync();
    }
}
