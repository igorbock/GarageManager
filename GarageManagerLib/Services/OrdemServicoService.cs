namespace GarageManagerLib.Services;

public class OrdemServicoService : ServiceAbstract, IService<OrdemServico>
{
    public OrdemServicoService(HttpClient p_httpClient, string p_endpoint) : base(p_httpClient, p_endpoint) { }

    public async Task<int> Atualizar(OrdemServico p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Put);

    public async Task<int> Criar(OrdemServico p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Post);

    public async Task<int> Excluir(OrdemServico p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Delete);

    public async Task<IEnumerable<OrdemServico>> Ler(int? p_codigo) => await EnviarParaWS<OrdemServico>(_endpoint, p_codigo);
}
