using System;
using System.Collections.Generic;
using System.Text;

namespace Se307_Lab6_Problem1
{
    class Rectangle : Shape
    {
        private int sideLengthX;
        private int sideLengthY;

        //Setter and getters
        public int SideLengthX { get => sideLengthX; set => sideLengthX = value; }
        public int SideLengthY { get => sideLengthY; set => sideLengthY = value; }

        public Rectangle(int sideLengthX,int sideLengthY) {
            this.SideLengthX = sideLengthX;
            this.SideLengthY = sideLengthY;

        }

        public override double area()
        {
            return SideLengthX*SideLengthY;
        }

        public override double circumference()
        {
            return 2*(SideLengthX + SideLengthY);
        }

    }
}
