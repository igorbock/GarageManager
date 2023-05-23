namespace GarageManagerRazorLib.Services;

public class OrdemServicoService : ServiceAbstract<OrdemServico, OrdemServicoDTO>
{
    public OrdemServicoService(HttpClient p_httpClient, string p_endpoint) : base(p_httpClient, p_endpoint) { }

    public override async Task<int> Salvar(OrdemServico p_entidade) => await EnviarParaWS(_endpoint, p_entidade, HttpMethod.Post);

    public override async Task<int> Excluir(int p_codigo) => await EnviarParaWS(_endpoint, p_codigo);

    public override async Task<IEnumerable<OrdemServicoDTO>> Ler(int? p_codigo) => await EnviarParaWS(_endpoint, p_codigo);
}
