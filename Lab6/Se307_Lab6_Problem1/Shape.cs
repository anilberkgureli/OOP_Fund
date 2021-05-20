using System;
using System.Collections.Generic;
using System.Text;

namespace Se307_Lab6_Problem1
{
    class Shape
    {
        public virtual double area() 
        {
            return 0; // We are returning 0 for now because we'll override it in other classes
        }

        public virtual double circumference()
        {
            return 0;
        }
    }
}
