using basic_auth_example.Models;

namespace basic_auth_example.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
    }
}
