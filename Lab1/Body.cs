using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Body
    {
        private int numberOfDoors;
        private String roofType;

        public int NumberOfDoors { get => numberOfDoors; set => numberOfDoors = value; }
        public string RoofType { get => roofType; set => roofType = value; }

        public Body(int numberOfDoors,String roofType)//constructor
        {
            this.numberOfDoors = numberOfDoors;
            this.roofType = roofType;
        }
    }
   
}
