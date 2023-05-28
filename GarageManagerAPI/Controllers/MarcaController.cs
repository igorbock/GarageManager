namespace GarageManagerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MarcaController : AbstractController, IControllerCRUD<Marca>
{
    public MarcaController(HttpClient p_httpClient, Context.Modelo p_modelo) : base(p_httpClient, p_modelo) { }

    [HttpPost]
    public IGMActionResult Save(Marca entidade)
    {
        try
        {
            if (entidade.Id == 0)
                _modelo?.Marcas?.Add(entidade);
            else
                _modelo?.Marcas?.Update(entidade);
            return new GMOk(_modelo?.SaveChanges());
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
                return new GMJson(_modelo?.Marcas!.OrderByDescending(a => a.Id), _options);                

            return new GMJson(_modelo?.Marcas?.Find(codigo), _options);
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
            var m_marca = _modelo?.Marcas?.Find(codigo) ?? throw new ArgumentNullException();
            _modelo?.Marcas?.Remove(m_marca);
            return new GMOk(_modelo?.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }
}
