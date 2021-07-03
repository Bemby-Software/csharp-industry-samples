using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManager.Abstractions;
using UserManager.Abstractions.Models;
using UserManager.Abstractions.Repositories;
using UserManager.Models;

namespace UserManager.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        private readonly List<User> _users;

        public InMemoryUserRepository()
        {
            _users = new List<User>();
        }

        public Task AddAsync(IUser user)
        {
            var highestUserId = _users.OrderBy(u => u.Id).FirstOrDefault();
            user.Id = highestUserId?.Id + 1 ?? 1;
            _users.Add(user as User);
            return Task.CompletedTask;
        }

        public Task<List<IUser>> GetAllAsync()
        {
            List<IUser> usersList = _users.Cast<IUser>().ToList();
            return Task.FromResult(usersList);
        }
    }
}