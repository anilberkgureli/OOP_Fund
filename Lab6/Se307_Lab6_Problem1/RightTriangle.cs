using System;
using System.Collections.Generic;
using System.Text;

namespace Se307_Lab6_Problem1
{
    class RightTriangle : Triangle
    {
        private int height;
        private int sideLengthBase;
        private int sideLengthHipo;

        public RightTriangle(int height, int sideLengthBase, int sideLengthHipo) : base(height, sideLengthBase, sideLengthHipo)
        {
            this.Height = height;
            this.SideLengthBase = sideLengthBase;
            this.SideLengthHipo = sideLengthHipo;
        }

        public override double area()
        {
            return 0.5 * (height * sideLengthBase);
        }

        public override double circumference()
        {
            return Height + SideLengthBase + SideLengthHipo;
        }
        public int Height { get => height; set => height = value; }
        public int SideLengthBase { get => sideLengthBase; set => sideLengthBase = value; }
        public int SideLengthHipo { get => sideLengthHipo; set => sideLengthHipo = value; }
    }

}
