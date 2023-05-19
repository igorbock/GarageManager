namespace GarageManagerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ModeloController : AbstractController, IControllerCRUD<Modelo>
{
    public ModeloController(HttpClient p_httpClient, Context.Modelo p_modelo) : base(p_httpClient, p_modelo) { }

    [HttpPost]
    public IGMActionResult Save(Modelo entidade)
    {
        try
        {
            if (entidade.Id == 0)
                _modelo!.Modelos?.Add(entidade);
            else
                _modelo!.Modelos?.Update(entidade);
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
            {
                var m_modelos = from modelo in _modelo!.Modelos
                                join marca in _modelo!.Marcas! on modelo.IdMarca equals marca.Id
                                orderby modelo.Id
                                select new
                                {
                                    Id = modelo.Id,
                                    Nome = modelo.Nome,
                                    IdMarca = marca.Id,
                                    Marca = marca.Nome
                                };
                return new GMJson(m_modelos, _options);
            }

            return new GMJson(_modelo!.Modelos?.Find(codigo), _options);
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
            var m_modelo = _modelo?.Modelos?.Find(codigo) ?? throw new ArgumentNullException();
            _modelo!.Modelos?.Remove(m_modelo);
            return new GMOk(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }
}
