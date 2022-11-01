namespace CashMachine.Models
{
    public class User
    {
        public int Id { get; }
        public int AccountBalance { get; set; }

        public User(int id, int accountBalance)
        {
            Id = id;
            AccountBalance = accountBalance;
        }
    }
}