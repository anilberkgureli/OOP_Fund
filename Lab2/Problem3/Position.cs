using System;
using System.Collections.Generic;
using System.Text;

namespace Se_320_Lab2_Problem3
{
    class Position
    {
       private int x;
       private int y;

        public Position() // Constructor method for initilizing a point at the origin (0,0)
        {
            int a = 0;
            int b = 0;
        }

       

        public Position(int x,int y) {
            this.x = x;
            this.y = y;
        }

        public int X { get => x; set => x = value; } // Set and get methods for each instance variable
        public int Y { get => y; set => y = value; }

        private int xIncr;
        public int moveXBy(int xIncrease =3,int currentX=0) { // This is for taking data from user for how much shall we increase x coordinates

         
            return  currentX = xIncrease + x;
            

        }
        int yIncr;
        public int moveYBy(int yIncrease = 4,int currentY=0)
        {
          
            return currentY= yIncrease+y;
            
            
        }

        // To find distance of our point to origin we need to use pisagor x^2+y^2=distance^2
        public double calculateDistanceToOrigin(double distance=0.0) //So distance to origin is sqrt(x+y)
        {
            return distance = Math.Sqrt(moveXBy()+moveYBy());
        }

        public void showDistanceToOrigin()
        {
            Console.WriteLine("Distance of our current point to the origin is");
            Console.WriteLine(calculateDistanceToOrigin());
        }
        public void displayLocation()
        {
            Console.WriteLine("This is the current position of our point in the beginning...");
            Console.WriteLine(x+":"+ y);

            Console.WriteLine("x value of our coordinate is increasing 3");
            
            Console.WriteLine("New x value is: "+moveXBy());

            Console.WriteLine("y value of our coordinate is increasing 4");
            Console.WriteLine("New y value is: "+moveYBy());

            Console.WriteLine("Our updated current coordinate is: "+moveXBy()+ ":" +moveYBy());



        }

    }

    
}
