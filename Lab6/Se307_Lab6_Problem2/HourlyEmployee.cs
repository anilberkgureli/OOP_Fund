using System;
using System.Collections.Generic;
using System.Text;

namespace Se307_Lab6_Problem2
{
    class HourlyEmployee : Employee
    {
        private int weeklyWorkHours;
        public HourlyEmployee(int securityNo, string name, string lastName, string birthDate, int phoneNumber, string address,int weeklyWorkHours)
        {
            base.FirstName = name;
            base.LastName1 = lastName;
            base.SecurityNumber = securityNo;
            base.BirthDate = birthDate;
            base.PhoneNumber = phoneNumber;
            base.Adress = address;
            this.WeeklyWorkHours = weeklyWorkHours;
        }

        
        private int hourlySalary = 50;

        public int WeeklyWorkHours { get => weeklyWorkHours; set => weeklyWorkHours = value; }

        public override double WeeklySalary()
        {
            if (WeeklyWorkHours > 40)
            {
                Console.WriteLine("He worked extra time so he deserved double price for his extra hours");
                return (hourlySalary * WeeklyWorkHours) + (WeeklyWorkHours - 40) * 2;
            }
            else
                return hourlySalary * WeeklyWorkHours;
            
        }
    }
}
