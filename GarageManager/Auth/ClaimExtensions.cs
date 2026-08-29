using System.Collections.ObjectModel;

namespace GarageManager.Auth
{
    public static class ClaimExtensions
    {
        public static ObservableCollection<System.Security.Claims.Claim> TransformarClaims(this ObservableCollection<ClaimModel> claims)
        {
            var retorno = new ObservableCollection<System.Security.Claims.Claim>();
            if (claims == null) return retorno;
            foreach (var claim in claims)
                retorno.Add(new System.Security.Claims.Claim(claim.Chave, claim.Valor ?? ""));
            return retorno;
        }
    }
}
