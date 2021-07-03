using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserManager.Abstractions;
using UserManager.Abstractions.Factories;
using UserManager.Abstractions.Models;
using UserManager.Abstractions.Repositories;
using UserManager.Abstractions.Services;
using UserManager.Factories;
using UserManager.Repositories;
using UserManager.Services;

namespace UserManager
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await InitialVersion();
        }

        private static async Task InitialVersion()
        {
            IUserFactory factory = new UserFactory();
            IUserRepository repository = new InMemoryUserRepository();
            IUserService userService = new UserService(repository, factory);

            await userService.SignUpAsync("joe.bloggs@hotmail.com", "Joe Bloggs", "Test123");
            await userService.SignUpAsync("mary.bloggs@hotmail.com", "Mary Bloggs", "Test321");

            List<IUser> users = await repository.GetAllAsync();

            foreach (IUser user in users)
            {
                Console.WriteLine($"Id: {user.Id} Name: {user.Name} Email: {user.EmailAddress}");
            }
            
            foreach (IIdentifiable identifiable in users)
            {
                Console.WriteLine($"Identifiable entity found with id {identifiable.Id}");
            }
        }
    }
}
