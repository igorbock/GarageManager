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
            var query_insert = $"INSERT INTO oficina.veiculos (\"Placa\", \"Cor\", \"Ano\", \"Km\", \"IdModelo\") VALUES ('{entidade.Placa}', '{entidade.Cor}', {entidade.Ano}, {entidade.Km}, {entidade.IdModelo});";
            var query_update = $"UPDATE oficina.veiculos SET \"Placa\" = '{entidade.Placa}', \"Cor\" = '{entidade.Cor}', \"Ano\" = {entidade.Ano}, \"Km\" = {entidade.Km}, \"IdModelo\" = {entidade.IdModelo} WHERE \"Id\" = {entidade.Id};";
            int rows = 0;

            if (entidade.Id == 0)
                rows = _modelo!.Database.ExecuteSqlRaw(query_insert);
            else
                rows = _modelo!.Database.ExecuteSqlRaw(query_update);

            return new GMOk(rows);
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
            if (codigo is not null)
                return new GMJson(_modelo!.Veiculos?.Find(codigo), _options);

            var veiculo = from veic in _modelo!.Veiculos
                          join modelo in _modelo!.Modelos! on veic.IdModelo equals modelo.Id
                          join marca in _modelo!.Marcas! on modelo.IdMarca equals marca.Id
                          orderby veic.Id descending
                          select new
                          {
                              Id = veic.Id,
                              Placa = veic.Placa,
                              Cor = veic.Cor,
                              Ano = veic.Ano,
                              Km = veic.Km,
                              IdModelo = modelo.Id,
                              Modelo = modelo.Nome,
                              IdMarca = marca.Id,
                              Marca = marca.Nome
                          };
            return new GMJson(veiculo, _options);            
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
