using System.Collections.Generic;
using BankAccounts.Abstractions;
using BankAccounts.Accounts;
using static System.Console;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var accounts = new List<IBankAccount>()
            {
                LifetimeAccount.Create(balance: 300),
                HelpToBuyAccount.Create(balance: 2000),
                FlexibleAccount.Create( balance: 50),
                PersonalAccount.Create(balance: 600),
            };

            foreach (IBankAccount account in accounts)
            {
                WriteLine($"Calculating interest for account {account.Type} current balance {account.Balance}");
                account.CalculateInterest();
                WriteLine($"Calculated interest for account {account.Type} new balance is {account.Balance}");
            }
            
        }
    }
}