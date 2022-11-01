using CashMachine.Exceptions;
using CashMachine.Models;

namespace CashMachine.Validations
{
    public class UserBankAccountBalanceValidations
    {
        public static void BankAccountValidation(int id, int bankAccountBalance, int amount)
        {
            var user = new User(id, bankAccountBalance);
            if (user.AccountBalance - WithdrawsValidator.WithDrawlValidator(amount) < 0)
            {
                throw new NotEnoughFundsException();
            }
        }
    }
}