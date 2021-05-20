using System;
using System.Collections.Generic;
using System.Text;

namespace Se307_Lab8_Problem1
{
    abstract class Shape : IComparison, IMovement
    {
        public abstract double area();
        public void comparison(String shapeName)
        {
            Console.WriteLine(shapeName + " is larger than the other");
        }
      

        public void movement(int move)
        {
            Console.WriteLine("Shapa has moved "+ move + " units");
        }
    }

}