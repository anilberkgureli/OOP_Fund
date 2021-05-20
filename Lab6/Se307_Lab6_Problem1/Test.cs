using System;
using System.Collections;

namespace Se307_Lab6_Problem1
{
    class Test
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(3,5);
            Console.WriteLine("Area of the rectangle is: "+rectangle.area());
            Console.WriteLine("Circumference of the rectangle is: "+rectangle.circumference());

            Square square = new Square(5);
            Console.WriteLine("Area of the square is: "+square.area());
            Console.WriteLine("Circumference of the square is: "+square.circumference());

            RightTriangle rightTriangle = new RightTriangle(3,5,7);
            Console.WriteLine("Area of right triangle is: "+ rightTriangle.area());
            Console.WriteLine("Circumference of right triangle is: "+rightTriangle.circumference());

            ScaleneTriangle scalene = new ScaleneTriangle(5,6,7);
            Console.WriteLine("Area of scalene triangle is: " +scalene.area());

            
        }
    }
}
