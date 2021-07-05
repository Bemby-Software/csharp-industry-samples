using BankAccounts.Abstractions;
using BankAccounts.Enums;

namespace BankAccounts.Accounts
{
    public class PersonalAccount : IBankAccount
    {
        private double _balance;
        private const double InterestRate = 0.005;

        private PersonalAccount(double balance)
        {
            _balance = balance;
        }

        public static IBankAccount Create(double balance) => new PersonalAccount(balance);
        
        
        public void Deposit(double amount)
        {
            throw new System.NotImplementedException();
        }

        public double Withdraw(double amount)
        {
            throw new System.NotImplementedException();
        }

        public double Balance => _balance;
        
        public AccountType Type => AccountType.Personal;
        
        public void CalculateInterest()
        {
            _balance += _balance * InterestRate;
        }
    }
}