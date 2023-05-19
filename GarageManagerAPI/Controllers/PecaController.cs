namespace GarageManagerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PecaController : AbstractController, IControllerCRUD<Peca>
{
    public PecaController(HttpClient p_httpClient, Context.Modelo p_modelo) : base(p_httpClient, p_modelo) { }

    [HttpPost]
    public IGMActionResult Save(Peca entidade)
    {
        try
        {
            if (entidade.Id == 0)
                _modelo!.Pecas?.Add(entidade);
            else
                _modelo!.Pecas?.Update(entidade);
            return new GMOk(_modelo.SaveChanges());
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
                return new GMJson(_modelo!.Pecas, _options);

            return new GMJson(_modelo!.Pecas?.Find(codigo), _options);
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
            var entidade = _modelo?.Pecas?.Find(codigo) ?? throw new ArgumentNullException();
            _modelo!.Pecas?.Remove(entidade);
            return new GMOk(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }
}
