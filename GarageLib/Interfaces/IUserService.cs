using System.Threading.Tasks;

namespace GarageLib.Interfaces
{
    public interface IUserService
    {
        Task LoginAsync(string username, string password);
        Task LogoutAsync();
    }
}
