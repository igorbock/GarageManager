using Blazorise;
using GarageManagerRazorLib.DTOs;
using GarageManagerRazorLib.Interfaces;
using GarageManagerRazorLib.Models;
using GarageManagerRazorLib.Services;
using Microsoft.AspNetCore.Components;

namespace GarageManageWASM.Pages;

public partial class Veiculos : IPage<VeiculoDTO>
{
    [Inject]
    public ServiceAbstract<Veiculo, VeiculoDTO>? VeiculoService { get; set; }
    [Inject]
    public ServiceAbstract<Modelo, ModeloDTO>? ModeloService { get; set; }
    [Inject]
    public ServiceAbstract<Marca, Marca>? MarcaService { get; set; }

    public IQueryable<VeiculoDTO>? IQueryableVeiculos { get; set; } = new List<VeiculoDTO>().AsQueryable();
    public IQueryable<ModeloDTO>? IQueryableModelos { get; set; } = new List<ModeloDTO>().AsQueryable();
    public IQueryable<Marca>? IQueryableMarcas { get; set; } = new List<Marca>().AsQueryable();
    protected VeiculoDTO VeiculoDTOAtual { get; set; } = new VeiculoDTO();
    protected Modelo ModeloAtual { get; set; } = new Modelo();
    protected Marca MarcaAtual { get; set; } = new Marca();

    private Modal? ModalCRUD { get; set; }
    private Task ShowModal() => ModalCRUD!.Show();
    private Task HideModal() => ModalCRUD!.Hide();

    private Modal? ModalApagar { get; set; }
    private Task ShowModalApagar() => ModalApagar!.Show();
    private Task HideModalApagar() => ModalApagar!.Hide();

    protected async override Task OnInitializedAsync()
    {
        if (VeiculoService is null) throw new ArgumentNullException();
        if (ModeloService is null) throw new ArgumentNullException();
        if (MarcaService is null) throw new ArgumentNullException();

        IQueryableVeiculos = (await VeiculoService.Ler(null)).AsQueryable();
        IQueryableModelos = (await ModeloService.Ler(null)).AsQueryable();
        IQueryableMarcas = (await MarcaService.Ler(null)).AsQueryable();
        VeiculoDTOAtual = new VeiculoDTO();
        ModeloAtual = new Modelo();
        MarcaAtual = new Marca();
    }

    public async Task Apagar(VeiculoDTO entidade)
    {
        if (VeiculoService is null) throw new ArgumentNullException();
        if (VeiculoDTOAtual is null) throw new ArgumentNullException();

        VeiculoDTOAtual = entidade;
        await VeiculoService!.Excluir(entidade.Id);
        await OnInitializedAsync();
        await InvokeAsync(() => StateHasChanged());
    }

    public async Task Editar(VeiculoDTO entidade)
    {
        if (VeiculoService is null) throw new ArgumentNullException();
        if (VeiculoDTOAtual is null) throw new ArgumentNullException();

        VeiculoDTOAtual = entidade;
        ModeloAtual = new Modelo { Id = entidade.IdModelo, Nome = entidade.Modelo, IdMarca = entidade.IdMarca, Marca = new Marca { Id = entidade.IdMarca, Nome = entidade.Marca } };
        MarcaAtual = ModeloAtual.Marca;
        await InvokeAsync(() => StateHasChanged());
    }

    public async Task Salvar()
    {
        if (VeiculoService is null) throw new ArgumentNullException();
        if (VeiculoDTOAtual is null) throw new ArgumentNullException();

        ModeloAtual.Marca = null;
        //ModeloAtual.IdMarca = MarcaAtual.Id;
        VeiculoDTOAtual.Modelo = null;
        //VeiculoDTOAtual.IdModelo = ModeloAtual.Id;
        var VeiculoAtual = new Veiculo
        {
            Id = VeiculoDTOAtual.Id,
            Ano = VeiculoDTOAtual.Ano,
            Cor = VeiculoDTOAtual.Cor,
            IdModelo = VeiculoDTOAtual.IdModelo,
            Km = VeiculoDTOAtual.Km,
            Modelo = ModeloAtual,
            Placa = VeiculoDTOAtual.Placa
        };
        await VeiculoService.Salvar(VeiculoAtual);
        await OnInitializedAsync();
        await HideModal();
    }

    public async Task Novo()
    {
        ModeloAtual = new Modelo();
        MarcaAtual = new Marca();
        VeiculoDTOAtual = new VeiculoDTO();

        await ShowModal();
    }

    private async Task Cancelar()
    {
        await HideModal();
        VeiculoDTOAtual = new VeiculoDTO();
    }
}
