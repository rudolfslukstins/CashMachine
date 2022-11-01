using System;

namespace CashMachine.Exceptions
{
    public class InvalidAmountRequestException : Exception
    {
        public InvalidAmountRequestException() : base("Invalid withdraw amount!")
        {

        }
    }
}