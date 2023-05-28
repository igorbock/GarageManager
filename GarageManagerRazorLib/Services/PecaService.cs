namespace GarageManagerRazorLib.Services;

public class PecaService : ServiceAbstract<Peca, Peca>
{
    public PecaService(HttpClient p_httpClient, string p_endpoint) : base(p_httpClient, p_endpoint) { }

    public override async Task<int> Salvar(Peca p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Post);

    public override async Task<int> Excluir(int p_codigo) => await EnviarParaWS(_endpoint, p_codigo);

    public override async Task<IEnumerable<Peca>> Ler(int? p_codigo) => await EnviarParaWS(_endpoint, p_codigo);
}
