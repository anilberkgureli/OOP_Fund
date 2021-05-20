using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Car//constructor
    {
        private int registrationNumber;
        private int year;
        private String licenseNumber;

        public int RegistrationNumber { get => registrationNumber; set => registrationNumber = value; }
        public int Year { get => year; set => year = value; }
        public string LicenseNumber { get => licenseNumber; set => licenseNumber = value; }

        public Car(int registrationNumber,int year,String licenseNumber)
        {
            this.registrationNumber = registrationNumber;
            this.year = year;
            this.licenseNumber = licenseNumber;

        }

        public void moveForward()
        {
            Console.WriteLine("We are moving forward");
        }
        public void moveBackward()
        {
            Console.WriteLine("We are moving backward");
        }
        public void stop()
        {
            Console.WriteLine("We stopped");
        }
        public void turnRight()
        {
            Console.WriteLine("We are turning right");
        }
        public void turnLeft()
        {
            Console.WriteLine("We are turning left");

       
        }
        
     
    }
}
