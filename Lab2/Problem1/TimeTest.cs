using System;

namespace lab2_Se320
{
    class TimeTest //This is a test class for testing class Time
    {
        static void Main(string[] args)
        {
            Time time = new Time(15,28,32); // I am creating object "time" in here...

            Console.WriteLine("Capabilites of class time is displaying below...");
            time.displayTime();  //this will demonstrates class time's capabilites it will give the values of time which I added consturctor 

            Console.WriteLine("-------------------------------------------"); 

            Console.WriteLine("Current date and time: "+ DateTime.Now);// And it will demonstrate curent date and time 


        }
    }
}
