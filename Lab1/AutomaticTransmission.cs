using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class AutomaticTransmission:Gearbox {
        public override int[] currentGear()
        {
            throw new NotImplementedException();
        }

        public override double[] gearRatio()
        {
            throw new NotImplementedException();
        }

        public override void reverse()
        {
            Console.WriteLine("Gear has been taken to reverse");
        }

          
        public void setGear()
        {
            Console.WriteLine("Gear is setting automatically");
        }
        
    }
}
