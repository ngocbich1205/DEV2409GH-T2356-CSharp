using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_ex4._1
{
    abstract class Account
    {
        protected double Balance;
        public Account(double initialBalance) {
            Balance = initialBalance;
        }
        public abstract void Deposit(double money);
        public abstract void Withdraw(double money);
        public double GetBalance()
        { return Balance; }
    }
}
