using System;

namespace CashMachine.Exceptions
{
    public class UnacceptableBanknoteException : Exception
    {
        public UnacceptableBanknoteException() : base("The machine doesn't accept this banknote.")
        {

        }
    }
}