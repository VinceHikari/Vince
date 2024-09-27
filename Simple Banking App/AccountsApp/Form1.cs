using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsApp
{
    public partial class BankingApp : Form
    {
        private List<Account> accounts = new List<Account>();
        public BankingApp()
        {
            InitializeComponent();
        }

        private void checkingRadio_CheckedChanged(object sender, EventArgs e)
        {
            withdrawField.Enabled = true;
            interestField.Enabled = false;
        }

        private void savingsRadio_CheckedChanged(object sender, EventArgs e)
        {
            withdrawField.Enabled = false;
            interestField.Enabled = true;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {

            int accountNumber = Convert.ToInt32(accountField.Text);
            string clientName = clientField.Text;
            double balance = Convert.ToDouble(balanceField.Text);
            double dailyLimit = Convert.ToDouble(withdrawField.Text);
            double interestRate = Convert.ToDouble(interestField.Text);

            if (withdrawField.Enabled == false && interestField.Enabled == true)
            {
                SavingsAccount savings = new SavingsAccount(accountNumber, clientName, balance, interestRate);
                accounts.Add(savings);

                MessageBox.Show("Your Savings account has been created");
            }

            else if (withdrawField.Enabled == true && interestField.Enabled == false )
            {
                CheckingAccount checking = new CheckingAccount(accountNumber, clientName, balance, dailyLimit);
                accounts.Add(checking);
                MessageBox.Show("Your Checking account has been created");
            }

            else
            {
                MessageBox.Show("Please select an account type");
            }

            accountField.Clear();
            clientField.Clear();
            balanceField.Clear();
            withdrawField.Clear();
            interestField.Clear();

            MessageBox.Show($" The number of accounts stored is {accounts.Count}");








        }
    }
}