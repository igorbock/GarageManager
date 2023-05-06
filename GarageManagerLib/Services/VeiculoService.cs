namespace GarageManagerLib.Services;

public class VeiculoService : ServiceAbstract<Veiculo>
{
    public VeiculoService(HttpClient p_httpClient, string p_endpoint) : base(p_httpClient, p_endpoint) { }

    public async Task<int> Atualizar(Veiculo p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Put);

    public async Task<int> Criar(Veiculo p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Post);

    public async Task<int> Excluir(Veiculo p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Delete);

    public async Task<IEnumerable<Veiculo>> Ler(int? p_codigo) => await EnviarParaWS(_endpoint, p_codigo);
}
