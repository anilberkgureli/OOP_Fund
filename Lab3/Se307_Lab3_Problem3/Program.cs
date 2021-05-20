using System;

namespace Se307_Lab3_Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 1;

            while (row <= 10) {
                int column = 1;
                if (row % 2 == 0) {
                    Console.Write(" ");//print function is that for C# 
                }
                for (column=1; column <= 20;column++) ; // For loop had been wriiten wrong. It's been corrected
                {
                    Console.Write(" * "); //print function is that for C# 

                }
                Console.WriteLine(); // print function is that for C# 
                row++; // changed row ++ 
            }
        }
    }
}
