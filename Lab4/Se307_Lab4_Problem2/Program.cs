using System;

namespace Se307_Lab4_Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot(0,0);

            robot.Display(); // First we will see the initial point of our robot           
            robot.moveLeft(3); //Then it will move 3 units left
            robot.Display(); //Then we will see current location of the robot
            robot.moveUpward(8); //Then robot will move 8 units forward
            robot.Display(); //Then we will see current location
            robot.moveRight(7); //Then robot will move 7 units left 
            robot.Display(); //Then we'll see current location
            robot.moveDownward(5); //Then robot will move 5 units backward
            robot.Display(); // Then we'll see current location 
            robot.moveDiagonally(2, 6); //Then robot will mmove on 2D space by X and Y steps(it means diagonally)
            robot.Display(); // Then we'll see the current location
            robot.randomStep(); //Then robot will move on 2D space by randon steps with interval(-5,5)
            robot.Display(); // eventually we will see the last position of the robot.

        }
    }
}
