using UserManager.Abstractions;
using UserManager.Abstractions.Factories;
using UserManager.Abstractions.Models;
using UserManager.Models;

namespace UserManager.Factories
{
    public class UserFactory : IUserFactory
    {
        public IUser Create(string emailAddress, string name, string password)
        {
            return new User()
            {
                EmailAddress = emailAddress,
                Name = name,
                Password = password
            };
        }
    }
}