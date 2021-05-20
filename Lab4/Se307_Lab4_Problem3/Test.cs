using System;

namespace Se307_Lab4_Problem3
{
    class Test
    {
        static void Main(string[] args)
        {
            CodeOfPoints cop = new CodeOfPoints();

            cop.setScoring();
            cop.getScorings();

            Console.WriteLine("The average score which has been given by rewiever in a specified column(4) is "+cop.getRewieverAvg(3));
            Console.WriteLine("The average score for a contender in a specified row(3) is " + cop.getContenderAvg(2));

        }
    }
}
