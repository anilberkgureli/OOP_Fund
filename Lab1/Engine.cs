using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Engine
    {
        private double capacity;
        private String fuelType;
        private int horsePower;
        private int numberOfCylinders;


        public void ignite()
        {
            Console.WriteLine("Engine has been ignited");
        }
        public Engine(double capacity,String fuelType,int horsePower,int numberOfCylinders)//constructor
        {
            this.capacity = capacity;
            this.fuelType = fuelType;
            this.horsePower = horsePower;
            this.numberOfCylinders = numberOfCylinders;
        }
    }
}
