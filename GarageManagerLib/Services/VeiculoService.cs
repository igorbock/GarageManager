namespace GarageManagerLib.Services;

public class VeiculoService : ServiceAbstract<Veiculo>
{
    public VeiculoService(HttpClient p_httpClient, string p_endpoint) : base(p_httpClient, p_endpoint) { }

    public override async Task<int> Atualizar(Veiculo p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Put);

    public override async Task<int> Criar(Veiculo p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Post);

    public override async Task<int> Excluir(int p_codigo) => await EnviarParaWS(_endpoint, p_codigo);

    public override async Task<IEnumerable<Veiculo>> Ler(int? p_codigo) => await EnviarParaWS(_endpoint, p_codigo);
}
