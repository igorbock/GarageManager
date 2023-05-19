using GarageManagerRazorLib.Interfaces;
using GarageManagerRazorLib.Models;
using GarageManagerRazorLib.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;

namespace GarageManageWASM.Pages;

public partial class OrdemServicos : IPage<OrdemServico>
{
    [Inject]
    public ServiceAbstract<OrdemServico, OrdemServico>? OrdemServicoService { get; set; }

    public IQueryable<OrdemServico>? IQueryableOrdemServicos { get; set; } = new List<OrdemServico>().AsQueryable();
    protected OrdemServico OrdemServicoAtual { get; set; } = new OrdemServico();

    protected ErrorBoundary? Error { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (OrdemServicoService is null) throw new ArgumentNullException();

        IQueryableOrdemServicos = (await OrdemServicoService.Ler(null)).AsQueryable();
        OrdemServicoAtual = new OrdemServico();
    }

    public async Task Apagar(OrdemServico entidade)
    {
        if (OrdemServicoService is null) throw new ArgumentNullException();
        if (entidade is null) throw new ArgumentNullException();

        OrdemServicoAtual = entidade;
        await OrdemServicoService.Excluir(entidade.Id);
        await OnInitializedAsync();
        await InvokeAsync(() => StateHasChanged());
    }

    public async Task Editar(OrdemServico entidade)
    {
        if (OrdemServicoService is null) throw new ArgumentNullException();
        if (entidade is null) throw new ArgumentNullException();

        OrdemServicoAtual = entidade;
        await InvokeAsync(() => StateHasChanged());
    }

    public async Task Salvar()
    {
        if (OrdemServicoService is null) throw new ArgumentNullException();
        if (OrdemServicoAtual is null) throw new ArgumentNullException();

        await OrdemServicoService.Salvar(OrdemServicoAtual);
        await OnInitializedAsync();
    }
}
