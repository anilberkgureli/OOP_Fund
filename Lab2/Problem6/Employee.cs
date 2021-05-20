using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Se307_Problem6
{
    class Employee
    {
        private String firstName, lastName;
        private int age;
        private String employeePosition;
        private int workHours;
        private double paymentForEachHour;

        public Employee(String firsName,String lastName,int age,String position,int workSchedule,double salaryForHours)
        {
            
            this.firstName = firsName;
            this.lastName = lastName;
            this.age = age;
            this.employeePosition = position;
            this.workHours = workSchedule;
            this.paymentForEachHour = salaryForHours;

        }

        //Set and get methods are below
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public string EmployeePosition { get => employeePosition; set => employeePosition = value; }
        public int WorkHours { get => workHours; set => workHours = value; }
        public double PaymentForEachHour { get => paymentForEachHour; set => paymentForEachHour = value; }
       
        
        double salary;
        public double calculateWeeklySalary()
        {
            
            return salary = workHours * paymentForEachHour;
        }

        public void displayEmployeeInformation()
        {
            Console.WriteLine("First Name: "+firstName);
            Console.WriteLine("Last Name: "+lastName);
            Console.WriteLine("Age: "+age);
            Console.WriteLine("Position: "+employeePosition);
            Console.WriteLine("Weekly Salary: "+calculateWeeklySalary());


        }
    }
}
