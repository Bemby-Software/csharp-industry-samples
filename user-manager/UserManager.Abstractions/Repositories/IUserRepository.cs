using System.Collections.Generic;
using System.Threading.Tasks;
using UserManager.Abstractions.Models;

namespace UserManager.Abstractions.Repositories
{
    public interface IUserRepository
    {
         Task AddAsync(IUser user);

         Task<List<IUser>> GetAllAsync();
    }
}