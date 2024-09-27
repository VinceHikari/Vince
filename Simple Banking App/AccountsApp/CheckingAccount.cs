using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsApp
{
    internal class CheckingAccount:Account
    {
        private double limit;

        public double Limit
        {
            get { return limit; }
            set { limit = value; }
        }

        const int fee = 1;


        public CheckingAccount(int number, string name, double balance, double limit)
            :base(number,name,balance)
        {
            
            Limit = limit;
        }

        public override void Deposit (double amount)
        {

            double newBalance = (amount + Balance) - fee;
        }

        public override void Withdraw(double amount)
        {
            double newBalance = (Balance - amount) - fee;
        }
    }
}
