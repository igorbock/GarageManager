namespace GarageManagerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MarcaController : AbstractController, IMarca
{
    public MarcaController(HttpClient p_httpClient, Context.Modelo p_modelo) : base(p_httpClient, p_modelo) { }

    [HttpPost]
    public ActionResult CreateMarca(Marca p_marca)
    {
        try
        {
            if (p_marca.Id == 0)
                _modelo?.Marcas?.Add(p_marca);
            else
                _modelo?.Marcas?.Update(p_marca);
            return Ok(_modelo?.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    public ActionResult ReadMarca(int? p_marca)
    {
        try
        {
            if (p_marca is null)
                return Json(_modelo?.Marcas, _options);

            return Json(_modelo?.Marcas?.Find(p_marca), _options);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public ActionResult UpdateMarca(Marca p_marca)
    {
        try
        {
            _modelo?.Marcas?.Update(p_marca);
            return Ok(_modelo?.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete]
    public ActionResult DeleteMarca(int p_codigo)
    {
        try
        {
            var m_marca = _modelo?.Marcas?.Find(p_codigo) ?? throw new ArgumentNullException();
            _modelo?.Marcas?.Remove(m_marca);
            return Ok(_modelo?.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
