using Blazorise;
using GarageManagerRazorLib.DTOs;
using GarageManagerRazorLib.Interfaces;
using GarageManagerRazorLib.Models;
using GarageManagerRazorLib.Services;
using Microsoft.AspNetCore.Components;

namespace GarageManageWASM.Pages;

public partial class Modelos : IPage<ModeloDTO>
{
    [Inject]
    public ServiceAbstract<Modelo, ModeloDTO>? ModeloService { get; set; }
    [Inject]
    public ServiceAbstract<Marca, Marca>? MarcaService { get; set; }

    public IQueryable<ModeloDTO>? IQueryableModelos { get; set; } = new List<ModeloDTO>().AsQueryable();
    public IQueryable<Marca>? IQueryableMarcas { get; set; } = new List<Marca>().AsQueryable();
    protected ModeloDTO ModeloDTOAtual { get; set; } = new ModeloDTO();
    protected Marca MarcaAtual { get; set; } = new Marca();

    private Modal? ModalCRUD { get; set; }
    private Task ShowModal() => ModalCRUD!.Show();
    private Task HideModal() => ModalCRUD!.Hide();

    private Modal? ModalApagar { get; set; }
    private Task ShowModalApagar() => ModalApagar!.Show();
    private Task HideModalApagar() => ModalApagar!.Hide();

    private async Task Cancelar()
    {
        await HideModal();
        ModeloDTOAtual = new ModeloDTO();
    }

    protected override async Task OnInitializedAsync()
    {
        if (ModeloService is null) throw new ArgumentNullException();
        if (MarcaService is null) throw new ArgumentNullException();

        IQueryableModelos = (await ModeloService.Ler(null)).AsQueryable();
        IQueryableMarcas = (await MarcaService.Ler(null)).AsQueryable();
        ModeloDTOAtual = new ModeloDTO();
        MarcaAtual = new Marca();
    }

    public async Task Apagar(ModeloDTO entidade)
    {
        if (ModeloService is null) throw new ArgumentNullException();
        if (entidade is null) throw new ArgumentNullException();
        if (string.IsNullOrWhiteSpace(entidade.Nome)) throw new ArgumentException();

        ModeloDTOAtual = entidade;
        await ModeloService.Excluir(entidade.Id);
        await OnInitializedAsync();
        await InvokeAsync(() => StateHasChanged());
    }

    public async Task Editar(ModeloDTO entidade)
    {
        if (ModeloService is null) throw new ArgumentNullException();
        if (entidade is null) throw new ArgumentNullException();
        if (string.IsNullOrWhiteSpace(entidade.Nome)) throw new ArgumentException();

        ModeloDTOAtual = entidade;
        MarcaAtual = new Marca { Id = entidade.IdMarca, Nome = entidade.Marca };
        await InvokeAsync(() => StateHasChanged());
    }

    private void VerificaNullable(ServiceAbstract<Modelo, ModeloDTO>? service, ModeloDTO? entidade)
    {
        if (service is null) throw new ArgumentNullException();
        if (entidade is null) throw new ArgumentNullException();
        if (string.IsNullOrWhiteSpace(entidade.Nome)) throw new ArgumentException();
    }

    public async Task Salvar()
    {
        VerificaNullable(ModeloService, ModeloDTOAtual);

        ModeloDTOAtual.IdMarca = MarcaAtual.Id;
        ModeloDTOAtual.Marca = null;
        var ModeloAtual = new Modelo { Id = ModeloDTOAtual.Id, Nome = ModeloDTOAtual.Nome, IdMarca = ModeloDTOAtual.IdMarca, Marca = new Marca { Id = ModeloDTOAtual.IdMarca, Nome = ModeloDTOAtual.Marca } };
        await ModeloService!.Salvar(ModeloAtual);
        await OnInitializedAsync();
        await HideModal();
    }

    public async Task Novo()
    {
        ModeloDTOAtual = new ModeloDTO();
        MarcaAtual = new Marca();

        await ShowModal();
    }
}

