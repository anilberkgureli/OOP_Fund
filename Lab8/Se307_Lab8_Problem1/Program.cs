using System;

namespace Se307_Lab8_Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(3,5);
            Console.WriteLine("Area of rectangle: " +rect.area());

            Circle circle = new Circle(3,3.14);
            Console.WriteLine("Area of circle is: "+circle.area());


            circle.movement(5);
            rect.movement(3);

            if(rect.area() > circle.area())
            {
                rect.comparison("Rectangle");
            }
            else if (circle.area()> rect.area())
            {
                circle.comparison("Circle");
            }
        }
    }
}
