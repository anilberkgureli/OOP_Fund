using System;

namespace Se307_Lab6_Problem2
{
    class Test
    {
        static void Main(string[] args)
        {
            SalariedEmployees mahmut = new SalariedEmployees(1,"mahmut","yavuz","01.01.1994",53169131,"istanbul");
            Console.WriteLine("Mahmut'un maaşı: " + mahmut.WeeklySalary());
            Console.WriteLine("---------------------------------------------------");
            HourlyEmployee mehmet = new HourlyEmployee(2,"mehmet","topal","12.06.1995",537637989,"izmir",42);
            Console.WriteLine("Mehmet'in maaşı: "+mehmet.WeeklySalary());
            Console.WriteLine("---------------------------------------------------");
            ComissionEmployee abdullah = new ComissionEmployee(3,"abdullah","yılmaz","29.12.1997",535535335,"manisa",15,30);
            Console.WriteLine("Abdullah'ın maaşı: " + abdullah.WeeklySalary());
            Console.WriteLine("---------------------------------------------------");
            BaseSalariedComissionEmp mustafa = new BaseSalariedComissionEmp(4,"mustafa","orhan","05.05.1993",532638979,"ankara",14,30);
            mustafa.ExtraPaymentFlag = true;
            Console.WriteLine("Mustafanın maaşı: "+mustafa.WeeklySalary());
        }
    }
}
