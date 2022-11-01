using System.Linq;
using CashMachine.Interfaces;
using CashMachine.Validations;

namespace CashMachine.Models
{
    public class CashMachine : ICashMachine
    {
        private readonly User _user;
        public CashMachine(User user)
        {
            _user = user;
        }
        
        public int Withdraw(int amount)
        {
            UserBankAccountBalanceValidations.BankAccountValidation(_user.Id, _user.AccountBalance, amount);
           _user.AccountBalance -= WithdrawsValidator.WithDrawlValidator(amount);

          return WithdrawsValidator.WithDrawlValidator(amount);
        }

        public void Insert(int[] cash)
        {
            BanknoteValidator.BanknoteValidation(cash);
            _user.AccountBalance += cash.Sum();
        }
    }
}