namespace lab_ex4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingAccount saving = new SavingAccount(1000, 0.05);
            saving.Deposit(500);
            saving.ApplyInterest();
            saving.Withdraw(200);
            Console.WriteLine($"So du tai khoan tiet kiem: {saving.GetBalance()}");

            CheckAccount check = new CheckAccount(2000, 5);
            check.Deposit(300);
            check.Withdraw(100);
            Console.WriteLine($"kiem tra so du tai khoan: {check.GetBalance()}");
        }
    }
}
