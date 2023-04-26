namespace GarageManagerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VeiculoController : AbstractController, IVeiculo
{
    public VeiculoController(HttpClient p_httpClient, Context.Modelo p_modelo) : base(p_httpClient, p_modelo) { }

    [HttpPost("create")]
    public  ActionResult CreateVeiculo(Veiculo p_veiculo)
    {
        try
        {
            _modelo.Veiculos?.Add(p_veiculo);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("read")]
    public  ActionResult ReadVeiculo(int? p_veiculo)
    {
        try
        {
            if (p_veiculo is null)
                return Json(_modelo.Veiculos, _options);

            return Json(_modelo.Veiculos?.Find(p_veiculo), _options);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("update")]
    public  ActionResult UpdateVeiculo(Veiculo p_veiculo)
    {
        try
        {
            _modelo.Veiculos?.Update(p_veiculo);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("delete")]
    public  ActionResult DeleteVeiculo(Veiculo p_veiculo)
    {
        try
        {
            _modelo.Veiculos?.Remove(p_veiculo);
            return Ok(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
