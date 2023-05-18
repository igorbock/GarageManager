namespace GarageManagerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VeiculoController : AbstractController, IVeiculo
{
    public VeiculoController(HttpClient p_httpClient, Context.Modelo p_modelo) : base(p_httpClient, p_modelo) { }

    [HttpPost]
    public IGMActionResult CreateVeiculo(Veiculo p_veiculo)
    {
        try
        {
            _modelo!.Veiculos?.Add(p_veiculo);
            return new GMOk(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }

    [HttpGet]
    public IGMActionResult ReadVeiculo(int? p_veiculo)
    {
        try
        {
            if (p_veiculo is null)
                return new GMJson(_modelo!.Veiculos, _options);

            return new GMJson(_modelo!.Veiculos?.Find(p_veiculo), _options);
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }

    [HttpPut]
    public IGMActionResult UpdateVeiculo(Veiculo p_veiculo)
    {
        try
        {
            _modelo!.Veiculos?.Update(p_veiculo);
            return new GMOk(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }

    [HttpDelete]
    public IGMActionResult DeleteVeiculo(int p_codigo)
    {
        try
        {
            var m_veiculo = _modelo!.Veiculos?.Find(p_codigo);
            _modelo!.Veiculos?.Remove(m_veiculo ?? throw new ArgumentNullException());
            return new GMOk(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }
}
