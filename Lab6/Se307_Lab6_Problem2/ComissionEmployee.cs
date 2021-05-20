using System;
using System.Collections.Generic;
using System.Text;

namespace Se307_Lab6_Problem2
{
    class ComissionEmployee:Employee
    {

        private int salesAmount;
        private int rate;
        public ComissionEmployee(int securityNo, string name, string lastName, string birthDate, int phoneNumber, string address,int salesAmount,int rate)
        {
            base.FirstName = name;
            base.LastName1 = lastName;
            base.SecurityNumber = securityNo;
            base.BirthDate = birthDate;
            base.PhoneNumber = phoneNumber;
            base.Adress = address;
            this.SalesAmount = salesAmount;
            this.Rate = rate;
        }

        public override double WeeklySalary()
        {
            return Rate * SalesAmount;
        }

        public int SalesAmount { get => salesAmount; set => salesAmount = value; }
        public int Rate { get => rate; set => rate = value; }
    }
}
