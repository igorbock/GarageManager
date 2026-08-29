using System.Security.Claims;

namespace GarageManager.Data
{
    public static class Sessao
    {
        public static int? UsuarioId { get; set; }
        public static int? EmpresaId { get; set; }
        public static string Token { get; set; }
        public static string UsuarioNome { get; set; }
        public static ClaimsPrincipal Principal { get; set; }

        public static void Clear()
        {
            UsuarioId = null;
            EmpresaId = null;
            Token = null;
            UsuarioNome = null;
            Principal = null;
        }

        public static bool EstaAutenticado()
        {
            if (string.IsNullOrWhiteSpace(Token)) return false;
            try { return new Auth.TokenService().TryLerToken(Token, out _); }
            catch { return false; }
        }
    }
}
