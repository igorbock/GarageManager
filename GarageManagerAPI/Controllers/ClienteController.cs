namespace GarageManagerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClienteController : AbstractController, IControllerCRUD<Cliente>
{
    public ClienteController(HttpClient p_httpClient, Context.Modelo p_modelo) : base(p_httpClient, p_modelo) { }

    [HttpPost]
    public IGMActionResult Save(Cliente entidade)
    {
        try
        {
            if (entidade.Id == 0)
                _modelo!.Clientes?.Add(entidade);
            else
                _modelo!.Clientes?.Update(entidade);
            return new GMOk(_modelo!.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }

    [HttpGet]
    public IGMActionResult Read(int? codigo)
    {
        try
        {
            if (codigo is null)
                return new GMJson(_modelo!.Clientes, _options);

            return new GMJson(_modelo!.Clientes?.Find(codigo), _options);
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }

    [HttpDelete]
    public IGMActionResult Delete(int codigo)
    {
        try
        {
            var m_marca = _modelo?.Clientes?.Find(codigo) ?? throw new ArgumentNullException();
            _modelo!.Clientes?.Remove(m_marca);
            return new GMOk(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }
}
