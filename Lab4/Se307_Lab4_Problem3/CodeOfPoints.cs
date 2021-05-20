using System;
using System.Collections.Generic;
using System.Text;

namespace Se307_Lab4_Problem3
{
    class CodeOfPoints
    {
        int[,] table = new int[3,4];

        public int[,] Table { get => table; set => table = value; }

        public void getScorings()
        {
            for (int i=0;i<3;i++)
            {
                for (int j=0;j<4;j++)
                {
                    Console.Write(table[i,j]+" ");

                }
                Console.WriteLine();

            }
        }

        private readonly Random random = new Random();

        public void setScoring()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                   table[i, j] = random.Next(10);
                }               

            }
        }
        public double getRewieverAvg(int column)
        {
            int sum = 0;
            double average = 0;
            for (int j = 0; j < 3; j++)
            {
                sum = sum + table[j, column];
            }

            average = sum / table.GetLength(0); //getLength(0) shows us first dimension of matrix
            return (average);

        }

        public double getContenderAvg(int row)
        {
            int sum = 0;
            double average = 0;
            for (int i=0;i<4; i++)
            {
                sum = sum + table[row, i];
            }

            average = sum / table.GetLength(1); //getLength(1) shows us 2nd dimension of matrix
            return (average);
            
        }
    }
}
