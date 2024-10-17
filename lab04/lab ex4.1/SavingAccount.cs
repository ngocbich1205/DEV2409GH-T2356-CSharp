using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_ex4._1
{
    internal class SavingAccount : Account
    {
        private double rate;

        public SavingAccount(double initialBalance, double rate) : base(initialBalance)
        {
            this.rate = rate;
        }

        public override void Deposit(double money)
        {
            Balance += money;
            Console.WriteLine($"{money} da duoc gui. so du moi: {Balance}");
        }

        public override void Withdraw(double money)
        {
            if (money > Balance)
            {
                Console.WriteLine("khong du so du!");
            }
            else
            {
                Balance -= money;
                Console.WriteLine($"{money} da duoc rut. so du moi: {Balance}");
            }
        }

        public void ApplyInterest()
        {
            Balance += Balance * rate;
            Console.WriteLine($"lai suat duoc ap dung theo ti le {rate}. so du moi: {Balance}");
        }
    }
}
