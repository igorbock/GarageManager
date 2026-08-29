using System.Configuration;

namespace GarageManager.Auth
{
    public static class JwtOptions
    {
        public static string Key => ConfigurationManager.AppSettings["Jwt:Key"] ?? "GarageManager_SuperSecret_2026_HS256_Key_32!!";
        public static string Issuer => ConfigurationManager.AppSettings["Jwt:Issuer"] ?? "GarageManager";
        public static string Audience => ConfigurationManager.AppSettings["Jwt:Audience"] ?? "GarageManager";
        public static string Algorithm => ConfigurationManager.AppSettings["Jwt:Algorithm"] ?? "HS256";

        public static string GetSecurityAlgorithm()
        {
            return Algorithm switch
            {
                "HS384" => Microsoft.IdentityModel.Tokens.SecurityAlgorithms.HmacSha384,
                "HS512" => Microsoft.IdentityModel.Tokens.SecurityAlgorithms.HmacSha512,
                _ => Microsoft.IdentityModel.Tokens.SecurityAlgorithms.HmacSha256
            };
        }

        public static int GetMinKeyLength()
        {
            return Algorithm switch
            {
                "HS384" => 48,
                "HS512" => 64,
                _ => 32
            };
        }
    }
}
