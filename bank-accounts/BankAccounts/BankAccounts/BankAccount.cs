using System;

namespace BankAccounts
{
    public class BankAccount
    {
        private readonly AccountType _type;
        private double _balance;

        private const double HelpToBuyInterestRatePercentage = 0.01;
        private const double PersonalInterestRatePercentage = 0.005;
        private const double LifetimeInterestRatePercentage = 0.015;
        private const double FlexibleInterestRatePercentage = 0.025;
        

        public BankAccount(AccountType type, double balance = 0)
        {
            _type = type;
            _balance = balance;
        }
        
        
        public void Deposit(double amount)
        {
            switch (_type)
            {
                case AccountType.HelpToBuy:
                    _balance += amount;
                    break;
                case AccountType.Personal:
                    _balance += amount;
                    break;
                case AccountType.Lifetime:
                    _balance += amount;
                    break;
                case AccountType.Flexible:
                    _balance += amount;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(_type), _type, null);
            }
        }

        public double Withdraw(double amount)
        {
            var newBalance = _balance - amount;
            if (newBalance < 0)
            {
                throw new InvalidOperationException(
                    $"You cannot withdraw this amount it would leave you minus {newBalance}");
            }
            
            switch (_type)
            {
                case AccountType.HelpToBuy:
                    _balance -= amount;
                    break;
                case AccountType.Personal:
                    _balance -= amount;
                    break;
                case AccountType.Lifetime:
                    _balance -= amount;
                    break;
                case AccountType.Flexible:
                    _balance -= amount;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(_type), _type, null);
            }

            return amount;
        }

        public double Balance => _balance;

        public AccountType Type => _type;

        public void CalculateInterest()
        {
            switch (_type)
            {
                case AccountType.HelpToBuy:
                    CalculateInterest(HelpToBuyInterestRatePercentage);
                    break;
                case AccountType.Personal:
                    CalculateInterest(PersonalInterestRatePercentage);
                    break;
                case AccountType.Lifetime:
                    CalculateInterest(LifetimeInterestRatePercentage);
                    break;
                case AccountType.Flexible:
                    CalculateInterest(FlexibleInterestRatePercentage);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(_type), _type, null);
            }
        }

        private void CalculateInterest(double percentage) 
            => _balance += _balance * percentage;
    }
}
