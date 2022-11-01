using System.Linq;
using CashMachine.Exceptions;

namespace CashMachine.Validations
{
    public class BanknoteValidator
    {
        public static void BanknoteValidation(int[] cash)
        {
            int[] banknotesAcceptable = { 5, 10, 20, 50, 100 };

            if (!cash.ToList().All(banknotes => banknotesAcceptable.Contains(banknotes)))
            {
                throw new UnacceptableBanknoteException();
            }
        }
    }
}