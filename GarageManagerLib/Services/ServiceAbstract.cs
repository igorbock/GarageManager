namespace GarageManagerLib.Services;

public abstract class ServiceAbstract
{
    protected readonly HttpClient _httpClient;
    protected readonly string _endpoint;

    public ServiceAbstract(HttpClient p_httpClient, string p_endpoint)
    {
        _httpClient = p_httpClient;
        _endpoint = p_endpoint;
    }

    protected async Task<int> EnviarParaWS<TipoT>(string p_endereco, TipoT p_entidade, HttpMethod p_metodo)
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

        var resposta = await response.Content.ReadAsStringAsync();
        if (int.TryParse(resposta, out int value))
            return value;

        throw new Exception(resposta);
    }

    protected Task<IEnumerable<TipoT>> EnviarParaWS<TipoT>(string p_endereco, int? p_codigo)
    {
        throw new NotImplementedException();
    }
}
