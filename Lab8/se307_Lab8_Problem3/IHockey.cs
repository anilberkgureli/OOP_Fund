using System;
using System.Collections.Generic;
using System.Text;

namespace se307_Lab8_Problem3
{
    interface IHockey :ISports
    {
        void homeGoalScored();
        void visitingGoalScored();
        void endOfPeriod();
        void overTimePeriod();


    }
}
