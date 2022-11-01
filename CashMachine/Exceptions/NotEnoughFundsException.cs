using System;

namespace CashMachine.Exceptions
{
    public class NotEnoughFundsException : Exception
    {
        public NotEnoughFundsException() : base("Not enough funds in account!")
        {

        }
    }
}