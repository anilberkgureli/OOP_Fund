using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Suspension
    {
        private float springRate;

        public float SpringRate { get => springRate; set => springRate = value; }

        public Suspension(float springRate)
        {
            this.springRate = springRate;
        }
        
       }
}
