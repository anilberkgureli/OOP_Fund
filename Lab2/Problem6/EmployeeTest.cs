using System;

namespace Lab2_Se307_Problem6
{
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Mahmut","Yılmaz",42,"worker",56,75.5);
            emp.calculateWeeklySalary();
            emp.displayEmployeeInformation();
        }
    }
}
