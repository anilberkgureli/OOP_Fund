using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Wheel
    {
        private double diameter;

        public double Diameter { get => diameter; set => diameter = value; }

        public Wheel(double diameter)
        {
            this.diameter = diameter;
        }
    }
}
