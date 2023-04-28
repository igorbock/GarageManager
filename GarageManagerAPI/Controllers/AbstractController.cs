namespace GarageManagerAPI.Controllers;

public abstract class AbstractController : Controller
{
    protected readonly HttpClient? _httpClient;
    protected readonly Context.Modelo? _modelo;
    protected readonly JsonSerializerOptions _options;

    public AbstractController(HttpClient? p_httpClient, Context.Modelo? p_modelo)
    {
        _httpClient = p_httpClient;
        _modelo = p_modelo;
        _options = new JsonSerializerOptions { Encoder = JavaScriptEncoder.Create(UnicodeRanges.All) };
    }
}
