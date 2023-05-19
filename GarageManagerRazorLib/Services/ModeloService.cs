namespace GarageManagerRazorLib.Services;

public class ModeloService : ServiceAbstract<Modelo, ModeloDTO>
{
    public ModeloService(HttpClient p_httpClient, string p_endpoint) : base(p_httpClient, p_endpoint) { }

    public override async Task<int> Salvar(Modelo p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Post);

    public override async Task<int> Excluir(int p_codigo) => await EnviarParaWS(_endpoint, p_codigo);

    public override async Task<IEnumerable<ModeloDTO>> Ler(int? p_codigo) => await EnviarParaWS(_endpoint, p_codigo);
}
