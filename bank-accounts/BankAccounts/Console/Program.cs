using BankAccounts;
using static System.Console;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var lifeTimeAccount = new BankAccount(AccountType.Lifetime, 300);
            var helpToBuyAccount = new BankAccount(AccountType.HelpToBuy, 2000);
            var flexAccount = new BankAccount(AccountType.Flexible, 50);
            var personalAccount = new BankAccount(AccountType.Personal, 600);
            
            
        }
    }
}