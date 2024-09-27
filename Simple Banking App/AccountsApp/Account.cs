using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{

    internal abstract class Account
    {
        private int number;
        private string name;
        private double balance;
        
        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public double Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

     
        public Account(int number, string name, double balance)
        {
            Number = number;
            Balance = balance;
            Name = name;

           
    
        }

        public abstract void Deposit(double amount);

        public abstract void Withdraw(double amount);   
        

        
    }
}
