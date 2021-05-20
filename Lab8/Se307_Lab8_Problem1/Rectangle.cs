using System;
using System.Collections.Generic;
using System.Text;

namespace Se307_Lab8_Problem1
{
    class Rectangle : Shape
    {
        private int sideA,sideB;
        
        public Rectangle(int A, int B)
        {
            this.sideA = A;
            this.sideB = B;
        }

        public override double area()
        {
            return sideA * sideB;
        }
    }
}
