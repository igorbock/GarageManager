namespace GarageManagerLib.Services;

public class ClienteService : ServiceAbstract<Cliente>
{
    public ClienteService(HttpClient p_httpClient, string p_endpoint) : base(p_httpClient, p_endpoint) { }

    public async Task<int> Atualizar(Cliente p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Put);

    public async Task<int> Criar(Cliente p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Post);

    public async Task<int> Excluir(Cliente p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Delete);

    public async Task<IEnumerable<Cliente>> Ler(int? p_codigo) => await EnviarParaWS(_endpoint, p_codigo);
}
