using System;
using System.Collections.Generic;
using System.Text;

namespace Se307_Lab6_Problem2
{
    class SalariedEmployees : Employee
    {
        /* private int securityNumber;
         private String firstName, LastName;
         private string birthDate;
         private int phoneNumber;
         private string adress;*/
        public SalariedEmployees(int securityNo, string name, string lastName, string birthDate, int phoneNumber, string address)
        {
            base.SecurityNumber = securityNo;
            base.PhoneNumber = phoneNumber;
            base.FirstName = name;
            base.LastName1 = lastName;
            base.BirthDate = birthDate;
            base.Adress = address;

        }
        private int constantSalary = 500;
        public override double WeeklySalary()
        {
            if (checkBirtday() == true)
            {
                return constantSalary + 200;
            }
            else
                return constantSalary;
            //  return constantSalary;

        }



    }
}
