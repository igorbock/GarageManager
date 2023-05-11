namespace GarageManagerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VeiculoController : AbstractController, IVeiculo
{
    public VeiculoController(HttpClient p_httpClient, Context.Modelo p_modelo) : base(p_httpClient, p_modelo) { }

    [HttpPost]
    public ActionResult CreateVeiculo(Veiculo p_veiculo)
    {
        try
        {
            _modelo!.Veiculos?.Add(p_veiculo);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    public ActionResult ReadVeiculo(int? p_veiculo)
    {
        try
        {
            if (p_veiculo is null)
                return Json(_modelo!.Veiculos, _options);

            return Json(_modelo!.Veiculos?.Find(p_veiculo), _options);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public ActionResult UpdateVeiculo(Veiculo p_veiculo)
    {
        try
        {
            _modelo!.Veiculos?.Update(p_veiculo);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete]
    public ActionResult DeleteVeiculo(int p_codigo)
    {
        try
        {
            var m_veiculo = _modelo!.Veiculos?.Find(p_codigo);
            _modelo!.Veiculos?.Remove(m_veiculo ?? throw new ArgumentNullException());
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
