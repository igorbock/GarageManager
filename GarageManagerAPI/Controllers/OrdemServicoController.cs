namespace GarageManagerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdemServicoController : AbstractController, IOrdemServico
{
    public OrdemServicoController(HttpClient? p_httpClient, Context.Modelo? p_modelo) : base(p_httpClient, p_modelo) { }

    [HttpPost]
    public IGMActionResult CreateOrdemServico(OrdemServico p_ordemServico)
    {
        try
        {
            _modelo?.OrdensServico?.Add(p_ordemServico);
            return new GMOk(_modelo?.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }

    [HttpGet]
    public IGMActionResult ReadOrdemServico(int? p_ordemServico)
    {
        try
        {
            if (p_ordemServico is null)
                return new GMJson(_modelo?.OrdensServico, _options);

            var ordem = _modelo?.OrdensServico?.FirstOrDefault(a => a.Id == p_ordemServico);
            var lista = new List<OrdemServico>
            {
                ordem ?? throw new Exception()
            };
            return new GMJson(lista, _options);
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }

    [HttpPut]
    public IGMActionResult UpdateOrdemServico(OrdemServico p_ordemServico)
    {
        try
        {
            _modelo?.OrdensServico?.Update(p_ordemServico);
            return new GMOk(_modelo?.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }

    [HttpDelete]
    public IGMActionResult DeleteOrdemServico(OrdemServico p_ordemServico)
    {
        try
        {
            _modelo?.OrdensServico?.Remove(p_ordemServico);
            return new GMOk(_modelo?.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }
}
