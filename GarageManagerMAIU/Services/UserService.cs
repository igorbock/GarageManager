using GarageLib.Interfaces;

namespace GarageManagerMAIU.Services;

public class UserService : IUserService
{
    private readonly IHttpClientFactory _httpClientFactory;

    public UserService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public Task LoginAsync(string username, string password)
    {
        using HttpClient client = _httpClientFactory.CreateClient();



        throw new NotImplementedException();
    }

    public Task LogoutAsync()
    {
        throw new NotImplementedException();
    }
}
