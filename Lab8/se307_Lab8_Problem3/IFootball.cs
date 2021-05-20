using System;
using System.Collections.Generic;
using System.Text;

namespace se307_Lab8_Problem3
{
    interface IFootball : ISports
    {
        void homeTeamScored(int homeScored);
        void visitingTeamScored(int visitScored);

        void endOfQuarter();
    }
}
