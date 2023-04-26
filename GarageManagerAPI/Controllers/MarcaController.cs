namespace GarageManagerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MarcaController : AbstractController, IMarca
{
    public MarcaController(HttpClient p_httpClient, Context.Modelo p_modelo) : base(p_httpClient, p_modelo) { }

    [HttpPost("create")]
    public  ActionResult CreateMarca(Marca p_marca)
    {
        try
        {
            _modelo.Marcas?.Add(p_marca);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("read")]
    public  ActionResult ReadMarca(int? p_marca)
    {
        try
        {
            if (p_marca is null)
                return Json(_modelo.Marcas, _options);

            return Json(_modelo.Marcas?.Find(p_marca), _options);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("update")]
    public  ActionResult UpdateMarca(Marca p_marca)
    {
        try
        {
            _modelo.Marcas?.Update(p_marca);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("delete")]
    public  ActionResult DeleteMarca(Marca p_marca)
    {
        try
        {
            _modelo.Marcas?.Remove(p_marca);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
