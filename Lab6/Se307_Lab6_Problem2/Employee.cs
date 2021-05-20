using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Se307_Lab6_Problem2
{
    class Employee
    {
        private int securityNumber;
        private String firstName, LastName;
        private string birthDate;
        private int phoneNumber;
        private string adress;

        public int SecurityNumber { get => securityNumber; set => securityNumber = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Adress { get => adress; set => adress = value; }

      
        public virtual double WeeklySalary()
        {
            return 0;
        }

       public bool checkBirtday()
        {
            DateTime date = DateTime.Parse(birthDate.Trim());
            CultureInfo cul = CultureInfo.CurrentCulture;

            int weekNum = cul.Calendar.GetWeekOfYear( date, CalendarWeekRule.FirstDay, DayOfWeek.Monday);

            int currenWeekNum = cul.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday);

            Console.WriteLine("Today his birthday!");
            if (currenWeekNum == weekNum)
            {
                return true;
            }

            else return false;
    


        }
    }
}
