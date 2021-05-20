using System;

namespace Se_320_Lab2_Problem3
{
    class PositionTest
    {
        static void Main(string[] args)
        {
            Position position = new Position(3,5);
          
                        
            position.moveXBy();
            position.moveYBy();
            position.calculateDistanceToOrigin();
            position.displayLocation();
            position.showDistanceToOrigin();


        }
    }
}
