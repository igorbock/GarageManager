namespace GarageManagerLib.Services;

public class ModeloService : ServiceAbstract<Modelo>
{
    public ModeloService(HttpClient p_httpClient, string p_endpoint) : base(p_httpClient, p_endpoint) { }

    public async Task<int> Atualizar(Modelo p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Put);

    public async Task<int> Criar(Modelo p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Post);

    public async Task<int> Excluir(Modelo p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Delete);

    public async Task<IEnumerable<Modelo>> Ler(int? p_codigo) => await EnviarParaWS(_endpoint, p_codigo);
}
