using GarageManagerRazorLib.DTOs;

namespace GarageManagerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdemServicoController : AbstractController, IControllerCRUD<OrdemServico>
{
    public OrdemServicoController(HttpClient? p_httpClient, Context.Modelo? p_modelo) : base(p_httpClient, p_modelo) { }

    [HttpPost]
    public IGMActionResult Save(OrdemServico entidade)
    {
        try
        {
            entidade.Inicio = DateTime.SpecifyKind(entidade.Inicio!.Value, DateTimeKind.Utc);
            entidade.Fim = DateTime.SpecifyKind(entidade.Fim!.Value, DateTimeKind.Utc);

            if (entidade.Id == 0)
                _modelo!.OrdensServico?.Add(entidade);
            else
                _modelo!.OrdensServico?.Update(entidade);
            return new GMOk(_modelo?.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }

    [HttpGet]
    public IGMActionResult Read(int? codigo)
    {
        try
        {
            if (codigo is not null)
                return new GMJson(_modelo?.OrdensServico!.Find(codigo), _options);


            var ordens = from ordem in _modelo!.OrdensServico!.AsNoTracking()
                            join cliente in _modelo!.Clientes!.AsNoTracking() on ordem.IdCliente equals cliente.Id
                            join veiculo in _modelo!.Veiculos!.AsNoTracking() on ordem.IdVeiculo equals veiculo.Id
                            orderby ordem.Id descending
                            select new OrdemServicoDTO
                            {
                                Id = ordem.Id,
                                Inicio = ordem.Inicio,
                                Fim = ordem.Fim,
                                Esperados = ordem.Esperados,
                                Realizados = ordem.Realizados,
                                Mecanico = ordem.Mecanico,
                                Status = ordem.Status,
                                Lavacao = ordem.Lavacao,
                                Pagamento = ordem.Pagamento,
                                IdVeiculo = veiculo.Id,
                                Veiculo = $"{veiculo!.Modelo!.Nome} - {veiculo!.Modelo!.Marca!.Nome}", 
                                IdCliente = cliente.Id,
                                Cliente = cliente.Nome,
                                Telefone = cliente.Telefone
                            };
            return new GMJson(ordens, _options);
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }

    [HttpDelete]
    public IGMActionResult Delete(int codigo)
    {
        try
        {
            var entidade = _modelo?.OrdensServico?.Find(codigo) ?? throw new ArgumentNullException();
            _modelo?.OrdensServico?.Remove(entidade);
            return new GMOk(_modelo?.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }
}
