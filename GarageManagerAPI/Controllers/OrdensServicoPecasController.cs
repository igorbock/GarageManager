namespace GarageManagerAPI.Controllers;

public class OrdensServicoPecasController : AbstractController
{
    public OrdensServicoPecasController(HttpClient p_httpClient, Context.Modelo p_modelo) : base(p_httpClient, p_modelo) { }

    [HttpPost("create")]
    public ActionResult CreateOrdensServicoPecas(OrdemServicoPecas p_ordemServico)
    {
        try
        {
            _modelo.OrdensServicoPecas?.Add(p_ordemServico);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("read")]
    public ActionResult ReadOrdensServicoPecas(int? p_ordemServico)
    {
        try
        {
            if (p_ordemServico is null)
                return Json(_modelo.OrdensServicoPecas, _options);

            return Json(_modelo.OrdensServicoPecas?.Find(p_ordemServico), _options);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("update")]
    public ActionResult UpdateOrdensServicoPecas(OrdemServicoPecas p_ordemServico)
    {
        try
        {
            _modelo.OrdensServicoPecas?.Update(p_ordemServico);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("delete")]
    public ActionResult DeleteOrdensServicoPecas(OrdemServicoPecas p_ordemServico)
    {
        try
        {
            _modelo.OrdensServicoPecas?.Remove(p_ordemServico);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
