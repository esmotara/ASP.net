using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInformationApp
{
    class Account
    {
        private  string accountNumber;
        private string customerName;
        private double balance=0;
        private double depositeAmount;
        private double withdrawAmount;


        public Account(string accountNumber, string customerName)
        {
            this.accountNumber = accountNumber;
            this.customerName = customerName;
        }

        public Account()
        {
            balance = 0;
        }

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public double Balance
        {
            get { return balance; }
        }

        public double DepositeAmount
        {
            get { return depositeAmount; }
            set { depositeAmount = value; }
        }

        public double WithdrawAmount
        {
            get { return withdrawAmount; }
            set { withdrawAmount = value; }
        }


        public string CustomerInfo()
        {
          return  "Account Number :" + "" + AccountNumber + "\nName :" + "" + CustomerName;
        }

        public string Deposite()
        {
            balance = Balance + DepositeAmount;
            return "Your balance is: " + Balance;
        }

        public string WithDraw()
        {
            if (Balance > WithdrawAmount)
            {
              balance = Balance - WithdrawAmount;
              return "Your balance is : " + Balance;

            }
            else
            {
               return "You have not sufficint balance.";
            }
        }


       // public string AccountReport()
      //  {

        //    return CustomerName + "," + " " + "your account number :" + " " + AccountNumber + " " + "and it's balance :" + " " +
                  // Balance + " " + "Taka";

       // }

        
    }
}
