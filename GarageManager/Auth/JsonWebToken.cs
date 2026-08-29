using System.Collections.ObjectModel;

namespace GarageManager.Auth
{
    public class JsonWebToken
    {
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string Subject { get; set; }
        public ObservableCollection<ClaimModel> Claims { get; set; }
        public string Key { get; set; }
        public string Algorithm { get; set; }
        public System.DateTime? Expiration { get; set; }
    }
}
