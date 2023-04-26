namespace GarageManagerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdemServicoController : AbstractController, IOrdemServico
{
    public OrdemServicoController(HttpClient p_httpClient, Context.Modelo p_modelo) : base(p_httpClient, p_modelo) { }

    [HttpPost]
    public ActionResult CreateOrdemServico(OrdemServico p_ordemServico)
    {
        try
        {
            _modelo.OrdensServico?.Add(p_ordemServico);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    public ActionResult ReadOrdemServico(int? p_ordemServico)
    {
        try
        {
            if (p_ordemServico is null)
                return Json(_modelo.OrdensServico, _options);

            return Json(_modelo.OrdensServico?.Find(p_ordemServico), _options);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public ActionResult UpdateOrdemServico(OrdemServico p_ordemServico)
    {
        try
        {
            _modelo.OrdensServico?.Update(p_ordemServico);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete]
    public ActionResult DeleteOrdemServico(OrdemServico p_ordemServico)
    {
        try
        {
            _modelo.OrdensServico?.Remove(p_ordemServico);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
