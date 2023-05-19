namespace GarageManagerAPI.Controllers;

public class OrdensServicoPecasController : AbstractController, IControllerCRUD<OrdemServicoPecas>
{
    public OrdensServicoPecasController(HttpClient p_httpClient, Context.Modelo p_modelo) : base(p_httpClient, p_modelo) { }

    [HttpPost]
    public IGMActionResult Save(OrdemServicoPecas entidade)
    {
        try
        {
            if (entidade.Id == 0)
                _modelo!.OrdensServicoPecas?.Add(entidade);
            else
                _modelo!.OrdensServicoPecas?.Update(entidade);
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
                return new GMJson(_modelo!.OrdensServicoPecas, _options);

            return new GMJson(_modelo!.OrdensServicoPecas?.Find(codigo), _options);
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
            var entidade = _modelo?.OrdensServicoPecas?.Find(codigo) ?? throw new ArgumentNullException();
            _modelo!.OrdensServicoPecas?.Remove(entidade);
            return new GMOk(_modelo.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }
}
