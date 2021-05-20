using System;
using System.Collections.Generic;
using System.Text;

namespace Se307_Lab4_Problem4
{
    class MyMathClass
    {
        private double PI;
        private double E;
        private int x; //we will use that for random number
        private int r; //we will use that for calculating a circle's area
       

        public MyMathClass(double pi, double e)
        {
          this.  PI = pi;
          this.  E = e;
        }

        private readonly Random random = new Random();
       

        public int X { get => x; set => x = value; }
        public int R { get => r; set => r = value; }

        public int randomNumber() //This method will produce a random number less than 10
        {

            return x=random.Next(10);    
        
        }

        public double EPowerOfX()
        {
            
            return Math.Pow(E,X);
        }

        public int randomRadius()
        {

            return R = random.Next(10); 
        }
        public double calculateCircle()
        {
            return PI * Math.Pow(R,2);
        }


    }
}
