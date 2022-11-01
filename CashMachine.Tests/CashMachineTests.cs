using System;
using CashMachine.Exceptions;
using CashMachine.Models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CashMachine.Tests
{
    [TestClass]
    public class CashMachineTests
    {
        private User _user;
        private Models.CashMachine _cashMachine;

        [TestInitialize]
        public void Setup()
        {
            _user = new User(1, 100);
            _cashMachine = new Models.CashMachine(_user);
        }

        [TestMethod]
        public void Insert_InsertValidCash_UserAccountShowsRightBalance()
        {
            int[] cash = { 5, 10, 20, 50, 100 };
            
            _cashMachine.Insert(cash);

            _user.AccountBalance.Should().Be(285);
        }

        [TestMethod]
        public void Insert_InsertInvalidCash_ShouldReturnUnacceptableBanknoteException()
        {
            int[] cash = { 500 };

            Action act = () =>
                _cashMachine.Insert(cash);

            act.Should().Throw<UnacceptableBanknoteException>()
                .WithMessage("The machine doesn't accept this banknote.");
        }

        [TestMethod]
        public void Withdraw_WithdrawCorrectAmountFromAccount_ShouldReturnRightBalance()
        {
            int amount = 50;

            _cashMachine.Withdraw(amount);

            _user.AccountBalance.Should().Be(50);
        }

        [TestMethod]
        public void Withdraw_WithdrawIncorrectAmountFromAccount_ShouldReturnInvalidAmountRequestException()
        {
            int amount = 47;

            Action act = () =>
                _cashMachine.Withdraw(amount);

            act.Should().Throw<InvalidAmountRequestException>()
                .WithMessage("Invalid withdraw amount!");
        }

        [TestMethod]
        public void Withdraw_WithdrawMoreThanAvailableBalance_ShouldReturnInvalidAmountRequestException()
        {
            int amount = 150;

            Action act = () =>
                _cashMachine.Withdraw(amount);

            act.Should().Throw<NotEnoughFundsException> ()
                .WithMessage("Not enough funds in account!");
        }
    }
}
