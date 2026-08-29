using System;
using System.Collections.ObjectModel;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace GarageManager.Auth
{
    public class TokenService : ITokenService
    {
        public Task<string> CriarTokenAsync(JsonWebToken jsonWebToken)
        {
            int minLen = JwtOptions.GetMinKeyLength();
            if (string.IsNullOrWhiteSpace(jsonWebToken.Key) || jsonWebToken.Key.Length < minLen)
                throw new ArgumentException($"A chave deve ter no mínimo {minLen} caracteres para {JwtOptions.Algorithm}.");

            var key = string.IsNullOrWhiteSpace(jsonWebToken.Key) ? JwtOptions.Key : jsonWebToken.Key;
            var algorithm = string.IsNullOrWhiteSpace(jsonWebToken.Algorithm) ? JwtOptions.GetSecurityAlgorithm() : JwtOptions.GetSecurityAlgorithm();
            var issuer = string.IsNullOrWhiteSpace(jsonWebToken.Issuer) ? JwtOptions.Issuer : jsonWebToken.Issuer;
            var audience = string.IsNullOrWhiteSpace(jsonWebToken.Audience) ? JwtOptions.Audience : jsonWebToken.Audience;

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, algorithm);

            if (!string.IsNullOrWhiteSpace(jsonWebToken.Subject))
            {
                jsonWebToken.Claims ??= new ObservableCollection<ClaimModel>();
                var subject = new ClaimModel { Chave = ClaimTypes.NameIdentifier, Valor = jsonWebToken.Subject };
                jsonWebToken.Claims.Add(subject);
            }

            var jwt = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                expires: jsonWebToken.Expiration,
                claims: jsonWebToken.Claims?.TransformarClaims(),
                signingCredentials: credentials);

            var handler = new JwtSecurityTokenHandler();
            var token = handler.WriteToken(jwt);
            return Task.FromResult(token);
        }

        public ClaimsPrincipal ValidarToken(string token)
        {
            if (string.IsNullOrWhiteSpace(token)) throw new ArgumentException("Token vazio.");
            var handler = new JwtSecurityTokenHandler();
            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtOptions.Key)),
                ValidateIssuer = true,
                ValidIssuer = JwtOptions.Issuer,
                ValidateAudience = true,
                ValidAudience = JwtOptions.Audience,
                ValidateLifetime = false,
                ClockSkew = TimeSpan.Zero
            };
            return handler.ValidateToken(token, validationParameters, out _);
        }

        public bool TryLerToken(string token, out ClaimsPrincipal principal)
        {
            principal = null;
            try { principal = ValidarToken(token); return true; }
            catch { return false; }
        }
    }
}
