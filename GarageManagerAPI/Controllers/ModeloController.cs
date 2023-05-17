namespace GarageManagerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ModeloController : AbstractController, IModelo
{
    public ModeloController(HttpClient p_httpClient, Context.Modelo p_modelo) : base(p_httpClient, p_modelo) { }

    [HttpPost]
    public IGMActionResult CreateModelo(Modelo p_modelo)
    {
        try
        {
            _modelo!.Modelos?.Add(p_modelo);
            return new GMOk(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }

    [HttpGet]
    public IGMActionResult ReadModelo(int? p_modelo)
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
                return new GMJson(m_modelos, _options);
            }

            return new GMJson(_modelo!.Modelos?.Find(p_modelo), _options);
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }

    [HttpPut]
    public IGMActionResult UpdateModelo(Modelo p_modelo)
    {
        try
        {
            _modelo!.Modelos?.Update(p_modelo);
            return new GMOk(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }

    [HttpDelete]
    public IGMActionResult DeleteModelo(int p_codigo)
    {
        try
        {
            var m_modelo = _modelo?.Modelos?.Find(p_codigo) ?? throw new ArgumentNullException();
            _modelo!.Modelos?.Remove(m_modelo);
            return new GMOk(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }
}
