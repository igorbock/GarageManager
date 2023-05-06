namespace GarageManagerLib.Services;

public class PecaService : ServiceAbstract<Peca>
{
    public PecaService(HttpClient p_httpClient, string p_endpoint) : base(p_httpClient, p_endpoint) { }

    public async Task<int> Atualizar(Peca p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Put);

    public async Task<int> Criar(Peca p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Post);

    public async Task<int> Excluir(Peca p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Delete);

    public async Task<IEnumerable<Peca>> Ler(int? p_codigo) => await EnviarParaWS(_endpoint, p_codigo);
}
