using System.ComponentModel.DataAnnotations;

namespace basic_auth_example.Models
{
    public record UserModel
    {        
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }        
    }

    public record User(int Id, string FirstName, string LastName, string Username, string Password) 
    {        
    }
}
