namespace GarageManagerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PecaController : AbstractController, IPeca
{
    public PecaController(HttpClient p_httpClient, Context.Modelo p_modelo) : base(p_httpClient, p_modelo) { }

    [HttpPost]
    public ActionResult CreatePeca(Peca p_peca)
    {
        try
        {
            _modelo.Pecas?.Add(p_peca);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    public ActionResult ReadPeca(int? p_peca)
    {
        try
        {
            if (p_peca is null)
                return Json(_modelo.Pecas, _options);

            return Json(_modelo.Pecas?.Find(p_peca), _options);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public ActionResult UpdatePeca(Peca p_peca)
    {
        try
        {
            _modelo.Pecas?.Update(p_peca);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete]
    public ActionResult DeletePeca(Peca p_peca)
    {
        try
        {
            _modelo.Pecas?.Remove(p_peca);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
