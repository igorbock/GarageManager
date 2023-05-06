namespace GarageManagerLib.Services;

public class OrdemServicoPecasService : ServiceAbstract<OrdemServicoPecas>
{
    public OrdemServicoPecasService(HttpClient p_httpClient, string p_endpoint) : base(p_httpClient, p_endpoint) { }

    public async Task<int> Atualizar(OrdemServicoPecas p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Put);

    public async Task<int> Criar(OrdemServicoPecas p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Post);

    public async Task<int> Excluir(OrdemServicoPecas p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Delete);

    public async Task<IEnumerable<OrdemServicoPecas>> Ler(int? p_codigo) => await EnviarParaWS(_endpoint, p_codigo);
}
