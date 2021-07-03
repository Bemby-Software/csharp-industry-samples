using UserManager.Abstractions;
using UserManager.Abstractions.Models;

namespace UserManager.Models
{
    public class User : IUser
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        

        public string Password { get; set; }
        
        public string EmailAddress { get; set; }
    }
}