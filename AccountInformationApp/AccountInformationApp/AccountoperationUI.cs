using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountInformationApp
{
    public partial class AccountOperationUI : Form
    {
        Account accountObj = new Account();
        //public double amount = 10000;

        
        public AccountOperationUI()
        {
            InitializeComponent();
        }

      

        private void createButton_Click(object sender, EventArgs e)
        {
           // Account accountObj=new Account();
            accountObj.AccountNumber= accountTextBox.Text;
            accountObj.CustomerName = customerTextBox.Text;
            
           // MessageBox.Show("Account Number:" + "" + accountObj.accountNumber + "\nName:" + "" + accountObj.customerName);

            MessageBox.Show(accountObj.CustomerInfo());
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            accountObj.DepositeAmount = Convert.ToDouble(amountTextBox.Text);
            //accountObj.balance = accountObj.balance + Convert.ToDouble(amountTextBox.Text);
            MessageBox.Show(accountObj.Deposite());
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            accountObj.WithdrawAmount = Convert.ToDouble(amountTextBox.Text);
            //if (accountObj.balance > withdrawAmount)
            //{
            //    accountObj.balance = accountObj.balance - withdrawAmount;
            //    MessageBox.Show("your balance is :" + accountObj.balance);
            //}
            //else
            //{
            //    MessageBox.Show("You have not sufficint balance.");
            //}
            MessageBox.Show(accountObj.WithDraw());
        }

        private void reportButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show(accountObj.CustomerName+"," + "" + "your account number:" + "" + accountObj.AccountNumber + "" + "and it's balance:" + "" + accountObj.Balance+"taka");
           // MessageBox.Show(accountObj.AccountReport());

        }
    }
}
