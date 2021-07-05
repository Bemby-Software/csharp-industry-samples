using BankAccounts.Enums;

namespace BankAccounts.Abstractions
{
    public interface IBankAccount
    {
        void Deposit(double amount);
        double Withdraw(double amount);
        double Balance { get; }
        AccountType Type { get; }
        void CalculateInterest();
    }
}