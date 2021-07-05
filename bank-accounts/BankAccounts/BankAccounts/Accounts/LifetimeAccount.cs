using BankAccounts.Abstractions;
using BankAccounts.Enums;

namespace BankAccounts.Accounts
{
    public class LifetimeAccount : IBankAccount
    {
        private double _balance;
        private const double InterestRate = 0.015;

        private LifetimeAccount(double balance)
        {
            _balance = balance;
        }

        public static IBankAccount Create(double balance) => new LifetimeAccount(balance: balance);
        
        public void Deposit(double amount)
        {
            throw new System.NotImplementedException();
        }

        public double Withdraw(double amount)
        {
            throw new System.NotImplementedException();
        }

        public double Balance => _balance;
        
        public AccountType Type => AccountType.Lifetime;
        
        public void CalculateInterest()
        {
            _balance += _balance * InterestRate;
        }
    }
}