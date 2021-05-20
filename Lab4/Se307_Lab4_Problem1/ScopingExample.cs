using System;

namespace Se320_Lab4_Problem1
{
    class ScopingExample
    {
        private static int x = 1;
        static void Main(string[] args)
        {
            //code

            Console.WriteLine(parameterVariable(10));
            Console.WriteLine(localVariable());
            instanceVariable();
        }
        static int parameterVariable(int x)
        {
            //parameter variable
            
            x = x + 1;
            return x;
        }
        static int localVariable()
        {
            //local variable
            int x = 5;
            return x;
        }

        static void instanceVariable()
        {
            //instance variable
            Console.WriteLine("instance variable x : "+x);
        }
    }
}
