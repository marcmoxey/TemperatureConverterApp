


/*
 * 
 * Build a program that converts temperatures between Celsius, Fahrenheit, and Kelvin. Use
 * breakpoints to debug the conversion logic.
 * 
 * Steps:
 * Write functions to convert between the three temperature scales.
 * Set breakpoints to inspect the input and output values of each conversion function.
 * Debug edge cases, such as extremely high or low temperatures.
 * 
 */

using TemperatureConverter;

double temp;

do
{
	Console.Write("Enter a tempature: ");
	string userTemp = Console.ReadLine();
	if (!double.TryParse(userTemp, out temp))
	{
		Console.WriteLine("Please enter a valid temp");
	}
    else
    {
        ConverterLogic.ConvertCelsiusToKelvin(temp);
        ConverterLogic.ConvertKelvinToCelsius(temp);
        ConverterLogic.ConvertFahrenheitToCelsius(temp);
        ConverterLogic.ConvertCelsiusToFahrenheit(temp);
        ConverterLogic.ConvertFahrenheitToKelvin(temp);
        ConverterLogic.ConvertKelvinToFahrenheit(temp);
    }

    

} while (temp != null); 



