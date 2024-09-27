using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsApp
{
    internal class SavingsAccount: Account
    {
        private double interest = 2.4;
        const double fee = 2.25;

        public double Interest
        {
            get { return interest; }
            set { interest = value; }
        }

        public SavingsAccount(int number, string name, double balance, double interest)
            :base(number, name,balance)
        {
            Number = number;
            Name = name;
            Balance = balance;
            Interest = interest;    

        }

        public override void Deposit(double amount)
        {
            double newBalance = (Balance + amount) - fee;
        }

        public override void Withdraw(double amount)
        {
            double newBalance = (Balance - amount) - fee;   
        }
    }
}
