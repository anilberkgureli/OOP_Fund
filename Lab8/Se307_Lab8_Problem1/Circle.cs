using System;
using System.Collections.Generic;
using System.Text;

namespace Se307_Lab8_Problem1
{
    class Circle : Shape 
    {
        int radius;
        double pi = 3.14;

        public Circle(int r, double pi)
        {
            this.radius = r;
            this.pi = pi;
        }

        public override double area()
        {
            return pi * (radius * radius);
        }

        
    }
}
