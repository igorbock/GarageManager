namespace GarageManagerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdemServicoController : AbstractController, IControllerCRUD<OrdemServico>
{
    public OrdemServicoController(HttpClient? p_httpClient, Context.Modelo? p_modelo) : base(p_httpClient, p_modelo) { }

    [HttpPost]
    public IGMActionResult Save(OrdemServico entidade)
    {
        try
        {
            if (entidade.Id == 0)
                _modelo!.OrdensServico?.Add(entidade);
            else
                _modelo!.OrdensServico?.Update(entidade);
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
                return new GMJson(_modelo?.OrdensServico, _options);

            var ordem = _modelo?.OrdensServico?.FirstOrDefault(a => a.Id == codigo);
            var lista = new List<OrdemServico>
            {
                ordem ?? throw new Exception()
            };
            return new GMJson(lista, _options);
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
            var entidade = _modelo?.OrdensServico?.Find(codigo) ?? throw new ArgumentNullException();
            _modelo?.OrdensServico?.Remove(entidade);
            return new GMOk(_modelo?.SaveChanges());
        }
        catch (Exception ex)
        {
            return new GMBadRequest(ex.Message);
        }
    }
}
