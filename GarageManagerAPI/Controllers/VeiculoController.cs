namespace GarageManagerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VeiculoController : AbstractController, IControllerCRUD<Veiculo>
{
    public VeiculoController(HttpClient p_httpClient, Context.Modelo p_modelo) : base(p_httpClient, p_modelo) { }

    [HttpPost]
    public IGMActionResult Save(Veiculo entidade)
    {
        try
        {
            if (entidade.Id == 0)
                _modelo!.Veiculos?.Add(entidade);
            else
                _modelo!.Veiculos?.Update(entidade);
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
                return new GMJson(_modelo!.Veiculos, _options);

            return new GMJson(_modelo!.Veiculos?.Find(codigo), _options);
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
            var entidade = _modelo!.Veiculos?.Find(codigo);
            _modelo!.Veiculos?.Remove(entidade ?? throw new ArgumentNullException());
            return new GMOk(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }
}
