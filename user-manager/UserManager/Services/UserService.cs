using System.Threading.Tasks;
using System;
using UserManager.Abstractions;
using UserManager.Abstractions.Factories;
using UserManager.Abstractions.Repositories;
using UserManager.Abstractions.Services;

namespace UserManager.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserFactory _userFactory;

        public UserService(IUserRepository userRepository, IUserFactory userFactory)
        {
            _userRepository = userRepository;
            _userFactory = userFactory;
        }

        public async Task SignUpAsync(string emailAddress, string name, string password)
        {
            var user = _userFactory.Create(emailAddress, name, password);

            if(emailAddress.Contains("@") is false)
            {
                throw new Exception("The users email address is invalid");
            }

            await _userRepository.AddAsync(user);
        }
    }
}