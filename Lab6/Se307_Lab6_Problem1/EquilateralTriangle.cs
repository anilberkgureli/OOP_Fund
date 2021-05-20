using System;
using System.Collections.Generic;
using System.Text;

namespace Se307_Lab6_Problem1
{
    class EquilateralTriangle : Triangle
    {
        private int sideLength;
        private double height;
        public EquilateralTriangle(int sideLength) : base(sideLength, sideLength, sideLength)
        {
            this.SideLength = sideLength;
            Height = (sideLength * Math.Sqrt(3) * 0.5);
        }



        public override double area()
        {
            return 0.5 * (sideLength * height);
        }

        public override double circumference()
        {
            return 3 * sideLength;
        }

        public int SideLength { get => sideLength; set => sideLength = value; }
        public double Height { get => height; set => height = value; }
    }
}
