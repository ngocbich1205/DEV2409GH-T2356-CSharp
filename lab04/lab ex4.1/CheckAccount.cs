using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_ex4._1
{
    internal class CheckAccount : Account
    {
        private double fee;

        public CheckAccount(double initialBalance, double fee) : base(initialBalance)
        {
            this.fee = fee;
        }

        public override void Deposit(double money)
        {
            Balance += money;
            Console.WriteLine($"{money} da duoc gui. So du moi: {Balance}");
        }

        public override void Withdraw(double money)
        {
            if (money + fee > Balance)
            {
                Console.WriteLine("Khong du so du de rut moi nhap lai!");
            }
            else
            {
                Balance -= (money + fee);
                Console.WriteLine($"{money} da duoc rut voi muc phi {fee}. so du moi: {Balance}");
            }
        }
    }
}
