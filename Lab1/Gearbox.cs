using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    abstract class Gearbox
    {
        abstract public void reverse();
        abstract public double[] gearRatio();
        abstract public int[] currentGear();
       
                         
    }
}
