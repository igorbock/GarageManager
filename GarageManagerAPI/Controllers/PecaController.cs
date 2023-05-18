namespace GarageManagerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PecaController : AbstractController, IPeca
{
    public PecaController(HttpClient p_httpClient, Context.Modelo p_modelo) : base(p_httpClient, p_modelo) { }

    [HttpPost]
    public IGMActionResult CreatePeca(Peca p_peca)
    {
        try
        {
            _modelo!.Pecas?.Add(p_peca);
            return new GMOk(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }

    [HttpGet]
    public IGMActionResult ReadPeca(int? p_peca)
    {
        try
        {
            if (p_peca is null)
                return new GMJson(_modelo!.Pecas, _options);

            return new GMJson(_modelo!.Pecas?.Find(p_peca), _options);
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }

    [HttpPut]
    public IGMActionResult UpdatePeca(Peca p_peca)
    {
        try
        {
            _modelo!.Pecas?.Update(p_peca);
            return new GMOk(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }

    [HttpDelete]
    public IGMActionResult DeletePeca(Peca p_peca)
    {
        try
        {
            _modelo!.Pecas?.Remove(p_peca);
            return new GMOk(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }
}
