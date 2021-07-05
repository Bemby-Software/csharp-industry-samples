using BankAccounts.Abstractions;
using BankAccounts.Enums;

namespace BankAccounts.Accounts
{
    public class FlexibleAccount : IBankAccount
    {
        private double _balance;
        private const double InterestRate = 0.025;

        private FlexibleAccount(double balance)
        {
            _balance = balance;
        }

        public static IBankAccount Create(double balance) => new FlexibleAccount(balance);
        
        
        public void Deposit(double amount)
        {
            
        }

        public double Withdraw(double amount)
        {
            throw new System.NotImplementedException();
        }

        public double Balance => _balance;
        
        public AccountType Type => AccountType.Flexible;
        
        public void CalculateInterest()
        {
            _balance += _balance * InterestRate;
        }
    }
}