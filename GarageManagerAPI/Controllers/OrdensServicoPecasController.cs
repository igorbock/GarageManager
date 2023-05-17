namespace GarageManagerAPI.Controllers;

public class OrdensServicoPecasController : AbstractController
{
    public OrdensServicoPecasController(HttpClient p_httpClient, Context.Modelo p_modelo) : base(p_httpClient, p_modelo) { }

    [HttpPost]
    public IGMActionResult CreateOrdensServicoPecas(OrdemServicoPecas p_ordemServico)
    {
        try
        {
            _modelo!.OrdensServicoPecas?.Add(p_ordemServico);
            return new GMOk(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }

    [HttpGet]
    public IGMActionResult ReadOrdensServicoPecas(int? p_ordemServico)
    {
        try
        {
            if (p_ordemServico is null)
                return new GMJson(_modelo!.OrdensServicoPecas, _options);

            return new GMJson(_modelo!.OrdensServicoPecas?.Find(p_ordemServico), _options);
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }

    [HttpPut]
    public IGMActionResult UpdateOrdensServicoPecas(OrdemServicoPecas p_ordemServico)
    {
        try
        {
            _modelo!.OrdensServicoPecas?.Update(p_ordemServico);
            return new GMOk(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }

    [HttpDelete]
    public IGMActionResult DeleteOrdensServicoPecas(OrdemServicoPecas p_ordemServico)
    {
        try
        {
            _modelo!.OrdensServicoPecas?.Remove(p_ordemServico);
            return new GMOk(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }
}
