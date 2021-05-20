using System;
using System.Collections.Generic;
using System.Text;

namespace Se307_Lab4_Problem2
{
    class Robot
    {
        private int x;
        private int y;

        private int leftReference;
        public Robot(int x, int y) // this is our constructor method and also it gives us the first position of the robot
        {
            this.x = x;
            this.y = y;
        }

        public int getXaxis()
        {

            return x;

        }

        public int getYaxis()
        {
            return y;
        }

        
        public void moveLeft(int leftReference)
        {
            Console.WriteLine("Robot is moving left...");
            x = x -leftReference;

        }

        public void moveRight(int rightReference)
        {
            Console.WriteLine("Robot is moving right...");
            x = x + rightReference;
        }

        public void moveUpward(int upReference)
        {
            Console.WriteLine("Robot is moving forward");
            y = y + upReference;
        }

        public void moveDownward(int downReference)
        {
            Console.WriteLine("Robot is moving down");
            y = y - downReference;
        }
        
        public void moveDiagonally(int horizantal,int vertical)
        {
            Console.WriteLine("Robot is moving in 2D space by 'x' and 'y' steps");
            x = x + horizantal;
            y = y + vertical;
        }

        private readonly Random random = new Random();

        public void randomStep()
        {

            Console.WriteLine("Robot is moving in 2D space with by random steps ");
            int horizantalRandom ,VerticalRandom;
            x = horizantalRandom= random.Next(-5,5) +x;
            y = VerticalRandom = random.Next(-5, 5)+y;
        }



        public void Display()
        {
            Console.WriteLine("Current position of the robot is "+ this.getXaxis()  +":" + this.getYaxis());

        }
    }
}
