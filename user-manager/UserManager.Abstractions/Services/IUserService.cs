using System.Threading.Tasks;

namespace UserManager.Abstractions.Services
{
    public interface IUserService
    {
         Task SignUpAsync(string emailAddress, string name, string password);
    }
}