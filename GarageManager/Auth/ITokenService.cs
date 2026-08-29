using System.Security.Claims;

namespace GarageManager.Auth
{
    public interface ITokenService
    {
        System.Threading.Tasks.Task<string> CriarTokenAsync(JsonWebToken jsonWebToken);
        ClaimsPrincipal ValidarToken(string token);
        bool TryLerToken(string token, out ClaimsPrincipal principal);
    }
}
