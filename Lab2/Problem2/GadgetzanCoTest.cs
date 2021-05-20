using System;

namespace Lab2_Se320_Problem2
{
    class GadgetzanCoTest
    {
        static void Main(string[] args)
        {
            GadgetzanCo gadgetz = new GadgetzanCo(1000,"item",0,0);

            gadgetz.calculateCost(); //For calculating total cost
            gadgetz.displayCost();   //For display all values and total cost        
        }
    }
}
