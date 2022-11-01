﻿namespace CashMachine.Interfaces
{
    public interface ICashMachine
    {
        int Withdraw(int amount);
        void Insert(int[] cash);
    }

}