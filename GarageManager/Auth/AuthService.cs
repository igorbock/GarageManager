using System;
using System.Collections.ObjectModel;
using Dapper;
using GarageManager.Data;

namespace GarageManager.Auth
{
    public class AuthService
    {
        private readonly ITokenService _tokenService;

        public AuthService() : this(new TokenService()) { }
        public AuthService(ITokenService tokenService) { _tokenService = tokenService; }

        public string Autenticar(string documentoOuEmail, string senha)
        {
            if (string.IsNullOrWhiteSpace(documentoOuEmail) || string.IsNullOrWhiteSpace(senha))
                throw new ArgumentException("Informe usuário e senha.");

            using (var conn = GarageDb.OpenConnection())
            {
                var row = conn.QueryFirstOrDefault<dynamic>(
                    @"SELECT u.id AS UsuarioId, u.hash, u.inativo, f.id AS FuncionarioId, f.id_empresa AS EmpresaId, p.nome AS Nome
                      FROM usuario u
                      JOIN funcionario f ON f.id = u.id_colaborador
                      JOIN pessoa p ON p.id = f.id_pessoa
                      LEFT JOIN pessoa pf ON pf.id = f.id_pessoa
                      WHERE (pf.documento = @doc OR pf.email = @doc OR p.nome = @doc)
                      LIMIT 1",
                    new { doc = documentoOuEmail.Trim() });

                if (row == null) throw new UnauthorizedAccessException("Usuário não encontrado.");
                if ((long)(row.inativo ?? 0) == 1) throw new UnauthorizedAccessException("Usuário inativo.");
                string hash = (string)row.hash;
                bool ok;
                try { ok = BCrypt.Net.BCrypt.Verify(senha, hash); }
                catch { ok = senha == hash; }
                if (!ok) throw new UnauthorizedAccessException("Senha inválida.");

                int usuarioId = Convert.ToInt32(row.UsuarioId);
                int empresaId = Convert.ToInt32(row.EmpresaId);
                string nome = (string)row.Nome;

                var claims = new ObservableCollection<ClaimModel>
                {
                    new ClaimModel { Chave = "empresa_id", Valor = empresaId.ToString() },
                    new ClaimModel { Chave = System.Security.Claims.ClaimTypes.Name, Valor = nome }
                };

                var jwt = new JsonWebToken
                {
                    Issuer = JwtOptions.Issuer,
                    Audience = JwtOptions.Audience,
                    Subject = usuarioId.ToString(),
                    Claims = claims,
                    Key = JwtOptions.Key,
                    Algorithm = JwtOptions.Algorithm,
                    Expiration = null
                };

                string token = _tokenService.CriarTokenAsync(jwt).GetAwaiter().GetResult();

                Sessao.UsuarioId = usuarioId;
                Sessao.EmpresaId = empresaId;
                Sessao.Token = token;
                Sessao.UsuarioNome = nome;
                Sessao.Principal = _tokenService.ValidarToken(token);

                return token;
            }
        }

        public void Logout()
        {
            Sessao.Clear();
        }

        public bool EstaAutenticado()
        {
            if (string.IsNullOrWhiteSpace(Sessao.Token)) return false;
            return new TokenService().TryLerToken(Sessao.Token, out _);
        }
    }
}
