using System;
using BankAccounts.Abstractions;
using BankAccounts.Enums;

namespace BankAccounts.Accounts
{
    public class HelpToBuyAccount : IBankAccount
    {
        private double _balance;
        private const double InterestRate = 0.01;

        private HelpToBuyAccount(double balance)
        {
            _balance = balance;
        }

        public static IBankAccount Create(double balance) => new HelpToBuyAccount(balance);
        
        public void Deposit(double amount)
        {
            throw new NotImplementedException();
        }

        public double Withdraw(double amount)
        {
            throw new System.NotImplementedException();
        }

        public double Balance => _balance;

        public AccountType Type => AccountType.HelpToBuy;
        
        public void CalculateInterest()
        {
            _balance += _balance * InterestRate;
        }
    }
}