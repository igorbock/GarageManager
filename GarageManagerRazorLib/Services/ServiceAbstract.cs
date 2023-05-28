namespace GarageManagerRazorLib.Services;

public abstract class ServiceAbstract<TipoT, TipoDTO> where TipoT : IEntidade
{
    protected readonly HttpClient _httpClient;
    protected readonly string _endpoint;

    public ServiceAbstract(HttpClient p_httpClient, string p_endpoint)
    {
        _httpClient = p_httpClient;
        _endpoint = p_endpoint;
    }

    public virtual Task<int> Salvar(TipoT p_entidade) => throw new NotImplementedException();

    public virtual Task<int> Excluir(int p_codigo) => throw new NotImplementedException();

    public virtual Task<IEnumerable<TipoDTO>> Ler(int? p_codigo) => throw new NotImplementedException();

    protected async Task<int> EnviarParaWS(string p_endereco, TipoT p_entidade, HttpMethod p_metodo)
    {
        HttpResponseMessage? response;
        switch (p_metodo.Method)
        {
            case "POST": response = await _httpClient.PostAsJsonAsync(p_endereco, p_entidade); break;
            case "PUT": response = await _httpClient.PutAsJsonAsync(p_endereco, p_entidade); break;
            case "DELETE": response = await _httpClient.DeleteAsync(p_endereco); break;
            default: throw new NotImplementedException();
        }

        if (response is null)
            throw new Exception();

        var resposta = await response.Content.ReadFromJsonAsync<GMJson>();
        if (int.TryParse(resposta!.Content!.ToString(), out int value))
            return value;

        throw new Exception(resposta!.Content!.ToString());
    }

    protected async Task<int> EnviarParaWS(string p_endereco, int p_codigo)
    {
        HttpResponseMessage? response;
        response = await _httpClient.DeleteAsync($"{p_endereco}?codigo={p_codigo}");

        if (response is null)
            throw new Exception();

        var resposta = await response.Content.ReadFromJsonAsync<GMJson>();
        if (int.TryParse(resposta!.Content!.ToString(), out int value))
            return value;

        throw new Exception(resposta!.Content!.ToString());
    }

    protected async Task<IEnumerable<TipoDTO>> EnviarParaWS(string p_endereco, int? p_codigo)
    {
        HttpResponseMessage? response;
        var m_url = $"{p_endereco}?codigo={p_codigo}";

        if (p_codigo.HasValue)
            response = await _httpClient.GetAsync(m_url);
        else
            response = await _httpClient.GetAsync(p_endereco);

        if (response is null)
            throw new Exception();

        var resposta = await response.Content.ReadFromJsonAsync<GMJson>();
        if (string.IsNullOrWhiteSpace(resposta!.Content!.ToString()))
            return new List<TipoDTO>().AsEnumerable();

        var enumerable = JsonSerializer.Deserialize<IEnumerable<TipoDTO>>(resposta!.Content!.ToString()!);
        if (enumerable is null)
            throw new Exception();

        return enumerable;
    }
}
