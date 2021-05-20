using System;
using System.Collections.Generic;
using System.Text;

namespace Se307_Lab6_Problem1
{
    class ScaleneTriangle : Triangle
    {
        private int sideA, sideB, sideC;
        private double s; // We will use Heron formula for calculating area of scalene triangle
        public ScaleneTriangle(int sideA, int sideB, int sideC) : base(sideA, sideB, sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;

            S = (SideA + SideB + SideC) * 0.5;
        }

        public override double area()
        {

            return Math.Sqrt(S * (S - SideA) * (S - SideB) * (S - SideC));
        }

        public override double circumference()
        {
            return sideA + sideB + sideC;
        }
        public int SideA { get => sideA; set => sideA = value; }
        public int SideB { get => sideB; set => sideB = value; }
        public int SideC { get => sideC; set => sideC = value; }
        public double S { get => s; set => s = value; }
    }
}
