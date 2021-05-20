using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Se307_Problem4
{
    class Car
    {
        public string model;
        private double year;
        private int speed;
        private int distance;

        public void Go(int newDistance)
        {
            distance += newDistance;
        }
        public int accelerate(int newSpeed) 
        {
          return speed = newSpeed; // return must be written before speed = newSpeed in here
        }

        public void stop() //speed can not be 0.1 because it is an integer value
        {
            speed = 0;
        }

        public string getInfo()
        {
            return "Car Info: " + year + " " +model +". Distance "+distance+ " km. and travelling at " + speed +"kmph"; // there must be "+" instead of "," before kmph in here
        }
        
        /*GETTERS & SETTERS */
        public String getModel()
        {
            return model;
        }

        public void setModel (String model)
        {
            this.model = model;
        }

        public double getYear() //that was public int getYear() it must be double
        {
            return year;
        }

        public void setYear(int year)
        {
            this.year = year;
        }
        
        public int getSpeed()
        {
            return speed;
        }

        public int getDistance()
        {
            return distance;
        }

        public void setDistance(int distance)
        {
            this.distance = distance;
        }




    }
}
