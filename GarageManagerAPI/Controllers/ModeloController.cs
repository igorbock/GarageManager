namespace GarageManagerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ModeloController : AbstractController, IModelo
{
    public ModeloController(HttpClient p_httpClient, Context.Modelo p_modelo) : base(p_httpClient, p_modelo) { }

    [HttpPost("create")]
    public  ActionResult CreateModelo(Modelo p_modelo)
    {
        try
        {
            _modelo.Modelos?.Add(p_modelo);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("read")]
    public  ActionResult ReadModelo(int? p_modelo)
    {
        try
        {
            if (p_modelo is null)
                return Json(_modelo.Marcas, _options);

            return Json(_modelo.Modelos?.Find(p_modelo), _options);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("update")]
    public  ActionResult UpdateModelo(Modelo p_modelo)
    {
        try
        {
            _modelo.Modelos?.Update(p_modelo);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("delete")]
    public  ActionResult DeleteModelo(Modelo p_modelo)
    {
        try
        {
            _modelo.Modelos?.Remove(p_modelo);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
