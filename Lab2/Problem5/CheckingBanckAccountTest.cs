using System;

namespace Lab2_Se307_Problem5
{
    class CheckingBanckAccountTest
    {
        static void Main(string[] args)
        {
            CheckingBanckAccount cba = new CheckingBanckAccount("123654789", "Anıl Berk Gureli",10);

            Console.WriteLine("***Current account information***");
            cba.display();
            Console.WriteLine("-----------------------------------");

            cba.deposit(10.5);
            cba.display();
            Console.WriteLine("---------------------------------");
            cba.check(40.0);
            cba.display();


        }
    }
}
