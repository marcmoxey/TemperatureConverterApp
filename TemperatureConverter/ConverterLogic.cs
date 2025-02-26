using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    public static class ConverterLogic
    {
        // Conversion of Temperature Between Celsius and Kelvin
        public static double ConvertCelsiusToKelvin(double tempInCelsius)
        {
            double kelvin = tempInCelsius + 273.15;
           
            Console.WriteLine($"{Math.Round(tempInCelsius,1)}F is {Math.Round(kelvin, 1)}K");
            return kelvin;
        }


        public static double ConvertKelvinToCelsius(double tempInKelvin)
        {
            double celsius = tempInKelvin - 273.15;
          
            Console.WriteLine($"{Math.Round(tempInKelvin,1)}K is {Math.Round(celsius, 1)}C");
            return celsius;
        }


        // Conversion of Temperature Between Fahrenheit and Celsius
        public static double ConvertFahrenheitToCelsius(double tempInFahrenheit)
        {

            double celsius = (tempInFahrenheit - 32) * (5 / 9);
        
            Console.WriteLine($"{Math.Round(tempInFahrenheit, 1)}F is {Math.Round(celsius, 1)}C");

            return celsius;
        }


        public static double ConvertCelsiusToFahrenheit(double tempInCelsius)
        {
            double fahrenheit = (tempInCelsius * (9 / 5)) + 32;
            
            Console.WriteLine($"{Math.Round(tempInCelsius, 1)}C is {Math.Round(fahrenheit, 1)}C");
            return fahrenheit;
        }


        //Conversion of Temperature Between Fahrenheit and Kelvin
        public static double ConvertFahrenheitToKelvin(double tempInFahrenheit)
        {
            double kelvin = (tempInFahrenheit - 32) * (5 / 9) + 273.15;
        
            Console.WriteLine($"{Math.Round(tempInFahrenheit, 1)}F is {Math.Round(kelvin, 1)}F");
            return kelvin;
        }


        public static double ConvertKelvinToFahrenheit(double tempInKelvin)
        {
            double fahrenheit = (tempInKelvin - 273.15) * (9/5) + 32;
            
            Console.WriteLine($"{Math.Round(tempInKelvin, 1)}K is {Math.Round(fahrenheit, 1)}F");
            return fahrenheit;
        }
    }
}
