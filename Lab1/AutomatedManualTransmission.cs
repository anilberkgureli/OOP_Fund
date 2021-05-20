using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class AutomatedManualTransmission : Gearbox
    {
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
            Console.WriteLine("Gear has bee taken to reverse");
        }

    
    }
}
