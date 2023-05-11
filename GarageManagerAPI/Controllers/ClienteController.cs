namespace GarageManagerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClienteController : AbstractController, ICliente
{
    public ClienteController(HttpClient p_httpClient, Context.Modelo p_modelo) : base(p_httpClient, p_modelo) { }

    [HttpPost]
    public ActionResult CreateCliente(Cliente p_cliente)
    {
        try
        {
            _modelo!.Clientes?.Add(p_cliente);
            return Ok(_modelo!.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    public ActionResult ReadCliente(int? p_cliente)
    {
        try
        {
            if (p_cliente is null)
                return Json(_modelo!.Clientes, _options);

            return Json(_modelo!.Clientes?.Find(p_cliente), _options);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public ActionResult UpdateCliente(Cliente p_cliente)
    {
        try
        {
            _modelo!.Clientes?.Update(p_cliente);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete]
    public ActionResult DeleteCliente(Cliente p_cliente)
    {
        try
        {
            _modelo!.Clientes?.Remove(p_cliente);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
