using GarageManagerRazorLib.Interfaces;
using GarageManagerRazorLib.Services;
using Microsoft.AspNetCore.Components;

namespace GarageManageWASM.Shared;

public partial class GMGrid<TipoT> where TipoT : IEntidade
{
    [Parameter]
    public IQueryable<TipoT>? IQueryable { get; set; }
    [Parameter]
    public ServiceAbstract<TipoT, TipoT>? Service { get; set; }

    private IEntidade? _entidade;
    [Parameter]
    public TipoT? EntidadeAtual
	{
		get => (TipoT)_entidade!;
		set
		{
			if ((IEntidade)value! == _entidade)
				return;

			_entidade = value;
			if (ValueChanged.HasDelegate)
			{
				ValueChanged.InvokeAsync();
			}
		}
	}

	[Parameter]
    public EventCallback<ChangeEventArgs> ValueChanged { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
    }

    protected async Task Editar(TipoT? entidade)
    {
        if (Service is null) throw new ArgumentNullException();
        if (entidade is null) throw new ArgumentNullException();

        EntidadeAtual = entidade;
        await InvokeAsync(() => StateHasChanged());
    }

    protected async Task Salvar()
    {
        if (Service is null) throw new ArgumentNullException();
        if (EntidadeAtual is null) throw new ArgumentNullException();
        if (string.IsNullOrWhiteSpace(EntidadeAtual.Nome)) throw new ArgumentException();

        await Service.Salvar(EntidadeAtual);
        await InvokeAsync(() => StateHasChanged());
    }

    protected async Task Apagar(TipoT? entidade)
    {
        if (Service is null) throw new ArgumentNullException();
        if (entidade is null) throw new ArgumentNullException();

        EntidadeAtual = default;
        await Service.Excluir(entidade.Id);
        await OnInitializedAsync();
        await InvokeAsync(() => StateHasChanged());
    }
}
