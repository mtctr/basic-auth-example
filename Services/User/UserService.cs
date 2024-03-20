using basic_auth_example.Models;
namespace basic_auth_example.Services
{
    public class UserService : IUserService
    {
        private List<User> _users;
        public UserService()
        {
            _users = new List<User>()
            {
                new User(1,"Test","User", "admin", "password")
            };
        }
        public User Authenticate(string username, string password)
        {
            return _users.SingleOrDefault(x => x.Username == username && x.Password == password);
        }
        
    }
}
