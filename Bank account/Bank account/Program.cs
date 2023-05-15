namespace Bank_account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.deposite(1000);
            account.deposite(300);
            account.withdraw(108);
            account.withdraw(1000);
        }
    }
}