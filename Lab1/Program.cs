using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(35, 2015, "EB9521");
            Engine eng = new Engine(1.6, "diesel", 125, 4);
            Body carBody = new Body(4, "sunroof");
            Tire tire = new Tire(215, 32.6f);
            Brake hitBrake = new Brake("ABS type Brake");
            Wheel hotWheel = new Wheel(64.1);
            Suspension susp = new Suspension(0.25f);
            ManuelTranmission manual = new ManuelTranmission();
            AutomaticTransmission auto = new AutomaticTransmission();
            AutomatedManualTransmission automanu = new AutomatedManualTransmission();

            
            Console.WriteLine("Body Aspects: " + carBody.NumberOfDoors + " " + carBody.NumberOfDoors);
            Console.WriteLine("Tire Variables: " + tire.Width + " " + tire.AirPressure );
            Console.WriteLine("Brake Variables: " + " " + hitBrake.Type);
            Console.WriteLine("Wheel Aspects: " + " " + hotWheel.Diameter);
            Console.WriteLine("Suspension Variables " + " " + susp.SpringRate);
            Console.WriteLine("Manual Transition");
            Console.WriteLine("Car Properties: " + car.Year + " " + car.RegistrationNumber + " " + car.LicenseNumber);

            eng.ignite();
            manual.shiftUp();
            car.moveForward();
            hitBrake.apply();
            car.stop();
            manual.reverse();
            car.moveBackward();
            car.stop();

        }
    }
}
