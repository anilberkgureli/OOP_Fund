using System;
using System.Collections.Generic;
using System.Text;

namespace Se307_Lab6_Problem2
{
    class BaseSalariedComissionEmp:Employee
    {
        private int salesAmount, rate;
        private int constantSalary=500;
        private bool extraPaymentFlag = false;
        public BaseSalariedComissionEmp(int securityNo, string name, string lastName, string birthDate, int phoneNumber, string address, int salesAmount, int rate)
        {
            base.SecurityNumber = securityNo;
            base.FirstName = name;
            base.LastName1 = lastName;
            base.BirthDate = birthDate;
            base.PhoneNumber = phoneNumber;
            base.Adress = address;
            this.salesAmount = salesAmount;
            this.rate = rate;
            
        }
        public override double WeeklySalary()
        {

            double salary = constantSalary + (Rate * SalesAmount);
            if (extraPaymentFlag == true)
            {
                Console.WriteLine("Also we have %5 bonus for current pay period");
                return (salary + salary * 0.05);
            }
            else
                return salary;
        }

        


        public int SalesAmount { get => salesAmount; set => salesAmount = value; }
        public int Rate { get => rate; set => rate = value; }
        public int ConstantSalary { get => constantSalary; set => constantSalary = value; }
        public bool ExtraPaymentFlag { get => extraPaymentFlag; set => extraPaymentFlag = value; }
    }
}
