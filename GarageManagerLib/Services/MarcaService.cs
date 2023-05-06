namespace GarageManagerLib.Services;

public class MarcaService : ServiceAbstract<Marca>
{
    public MarcaService(HttpClient? p_httpClient, string p_endpoint) : base(p_httpClient, p_endpoint) { }

    public override async Task<int> Atualizar(Marca p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Put);

    public override async Task<int> Criar(Marca p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Post);

    public override async Task<int> Excluir(int p_codigo) => await EnviarParaWS(_endpoint, p_codigo);

    public override async Task<IEnumerable<Marca>> Ler(int? p_codigo) => await EnviarParaWS(_endpoint, p_codigo);
}
