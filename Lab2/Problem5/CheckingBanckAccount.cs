using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Se307_Problem5
{
    class CheckingBanckAccount
    {
        private string accountNumber;
        private string accountHolderName;
        private double currentBalance;

        public string AccountNumber { get => accountNumber; set => accountNumber = value; }
        public string AccountHolderName { get => accountHolderName; set => accountHolderName = value; }
        public double CurrentBalance { get => currentBalance; set => currentBalance = value; }


        public CheckingBanckAccount(string accountNumber,string accountHolderName,double currentBalance)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.currentBalance = currentBalance;
        }

        public double deposit(double depositValue)
        {
            Console.WriteLine("Doposit process on progress..");
            return currentBalance = currentBalance + depositValue;
           
        }
        public double check(double checkValue)
        {
            Console.WriteLine("Check process in progress...");
           

            if (currentBalance<100.0)
            {
                checkValue = checkValue + 4.8;
            }
            else if(currentBalance>=100.0)
            {
                checkValue = checkValue;
            }
            return currentBalance = currentBalance - checkValue;
        }

        public void display()
        {
            Console.WriteLine("Account Number: "+AccountNumber);
            Console.WriteLine("Account Holder: "+AccountHolderName);
            Console.WriteLine("Current Balance: "+CurrentBalance);
        }
    }
}
