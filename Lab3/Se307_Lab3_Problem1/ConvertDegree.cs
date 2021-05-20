using System;
using System.Collections.Generic;
using System.Text;

namespace Se307_lab3_Problem1
{
    class ConvertDegree
    {
        private double celcius;
        private double fahrenheit;
        private double kelvin;
        public double Celcius { get => celcius; set => celcius = value; }
        public double Fahrenheit { get => fahrenheit; set => fahrenheit = value; }
        public double Kelvin { get => kelvin; set => kelvin = value; }

        public ConvertDegree(double celcius, double fahrenheit, double kelvin) //constructor method of the class 
        {
            this.Celcius = celcius;
            this.Fahrenheit = fahrenheit;
            this.Kelvin = kelvin;
        }


        public double CalculateCelciusToFahrenheit()
        {
            Fahrenheit = (Celcius * 9) / 5 + 32;
            return Fahrenheit;
        }
        public double CalculateCelciusToKelvin()
        {
            Kelvin = Celcius + 273.15;
           
            return Kelvin;
        }
        public double CalculateFahrenheitToCelcius() // function which gives us the conversion to fahrenheit
        {
            Celcius = 5*(Fahrenheit-32)/9  ;
                   
            return Celcius;
        }
        public double CalculateFahrenheitToKelvin()
        {
            Kelvin = (Fahrenheit - 32) * 5 / 9 + 273.15;
            return Kelvin;
        }

        public double CalculateKelvinToCelsius(int kelv)
        {
            Celcius = (kelv - 273.15);
            return Celcius;
        }




    }
}
