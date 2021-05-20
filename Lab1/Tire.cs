using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Tire
    {
        private double width;
        private float airPressure;

        public double Width { get => width; set => width = value; }
        public float AirPressure { get => airPressure; set => airPressure = value; }

        public Tire(double width,float airPressure)//constructor
        {
            this.width = width;
            this.airPressure = airPressure;
        }
    }
}
