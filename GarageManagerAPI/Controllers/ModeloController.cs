namespace GarageManagerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ModeloController : AbstractController, IModelo
{
    public ModeloController(HttpClient p_httpClient, Context.Modelo p_modelo) : base(p_httpClient, p_modelo) { }

    [HttpPost]
    public ActionResult CreateModelo(Modelo p_modelo)
    {
        try
        {
            _modelo!.Modelos?.Add(p_modelo);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    public ActionResult ReadModelo(int? p_modelo)
    {
        try
        {
            if (p_modelo is null)
            {
                var m_modelos = from modelo in _modelo!.Modelos
                                join marca in _modelo!.Marcas! on modelo.IdMarca equals marca.Id
                                select new
                                {
                                    Id = modelo.Id,
                                    Nome = modelo.Nome,
                                    IdMarca = modelo.IdMarca
                                };
                return Json(m_modelos, _options);
            }

            return Json(_modelo!.Modelos?.Find(p_modelo), _options);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public ActionResult UpdateModelo(Modelo p_modelo)
    {
        try
        {
            _modelo!.Modelos?.Update(p_modelo);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete]
    public ActionResult DeleteModelo(int p_codigo)
    {
        try
        {
            var m_modelo = _modelo?.Modelos?.Find(p_codigo) ?? throw new ArgumentNullException();
            _modelo!.Modelos?.Remove(m_modelo);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
