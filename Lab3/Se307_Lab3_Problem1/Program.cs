using System;

namespace Se307_lab3_Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertDegree convert = new ConvertDegree(30, 86, 500);
            Console.WriteLine("30 C: " + convert.CalculateCelciusToFahrenheit()+ " F");
            Console.WriteLine("30 C: " + convert.CalculateCelciusToKelvin() + " K");
            Console.WriteLine("86 F: "+ convert.CalculateFahrenheitToCelcius()+" C");
            Console.WriteLine("86 F: " + convert.CalculateFahrenheitToKelvin() + " K");
            Console.WriteLine("500 K: " + convert.CalculateKelvinToCelsius(500) + " C");

        }
    }
}
