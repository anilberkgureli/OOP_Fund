using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class ManuelTranmission:Gearbox
    {




    public void shiftUp()
        {
            Console.WriteLine("Gear has been shifted up!");
        }
    public void shiftDown()
        {
            Console.WriteLine("Gear has been shifted down!");
        }

        public override void reverse()
        {
            Console.WriteLine("Gear has been taken to reverse");
            
        }

        public override double[] gearRatio()
        {
            throw new NotImplementedException();
        }

        public override int[] currentGear()
        {
            throw new NotImplementedException();
        }
    }
}
