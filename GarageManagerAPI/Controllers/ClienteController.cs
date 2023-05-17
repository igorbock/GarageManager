namespace GarageManagerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClienteController : AbstractController, ICliente
{
    public ClienteController(HttpClient p_httpClient, Context.Modelo p_modelo) : base(p_httpClient, p_modelo) { }

    [HttpPost]
    public IGMActionResult CreateCliente(Cliente p_cliente)
    {
        try
        {
            _modelo!.Clientes?.Add(p_cliente);
            return new GMOk(_modelo!.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }

    [HttpGet]
    public IGMActionResult ReadCliente(int? p_cliente)
    {
        try
        {
            if (p_cliente is null)
                return new GMJson(_modelo!.Clientes, _options);

            return new GMJson(_modelo!.Clientes?.Find(p_cliente), _options);
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }

    [HttpPut]
    public IGMActionResult UpdateCliente(Cliente p_cliente)
    {
        try
        {
            _modelo!.Clientes?.Update(p_cliente);
            return new GMOk(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }

    [HttpDelete]
    public IGMActionResult DeleteCliente(Cliente p_cliente)
    {
        try
        {
            _modelo!.Clientes?.Remove(p_cliente);
            return new GMOk(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }
}
