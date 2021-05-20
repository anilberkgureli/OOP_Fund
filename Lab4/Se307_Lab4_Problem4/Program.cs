using System;

namespace Se307_Lab4_Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMathClass mathClass = new MyMathClass(3.1415, 2.7182);
            
            Console.WriteLine("The random x number which is produced by the program is: "+ mathClass.randomNumber());
            Console.WriteLine("The result of e raised to the power of x: "+mathClass.EPowerOfX());
            Console.WriteLine("The random radius number r is: "+mathClass.randomRadius());
            Console.WriteLine("The circle's area (pi*r^2) is: " + mathClass.calculateCircle());


        }
    }
}
