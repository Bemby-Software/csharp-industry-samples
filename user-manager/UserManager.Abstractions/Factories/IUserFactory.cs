
using UserManager.Abstractions.Models;

namespace UserManager.Abstractions.Factories
{
    public interface IUserFactory
    {
        IUser Create(string emailAddress, string name, string password);
    }
}