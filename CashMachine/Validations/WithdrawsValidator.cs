using System.ComponentModel;
using CashMachine.Exceptions;
using CashMachine.Models;

namespace CashMachine.Validations
{
    public class WithdrawsValidator
    {
        public static int WithDrawlValidator(int amount)
        {
            if (amount < 0 || amount % 5 != 0)
            {
                throw new InvalidAmountRequestException();
            }

            return amount;
        }
    }
}