using System;

namespace WeatherCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Weather Calculator 2");

            int temperature;
            int windSpeed;
            double windChill;
            

            // Get the temperature from the user
            Console.WriteLine("Enter the temperature");
            string input = Console.ReadLine();

            

            temperature = int.Parse(input);
            bool isInt = int.TryParse(input,out temperature);
            if (temperature > 50)
            { Console.WriteLine("Enter Relative Humidity");
                input = Console.ReadLine();
               int relativehumidity = int.Parse(input);
               
                double HeatIndex = .5 * (temperature + 61.0 + ((temperature - 68.0) * 1.2) + (relativehumidity * .094));
                Console.WriteLine("The Heat Index is" + HeatIndex);
            }
            else

            { 
            // Get the windspeed from the user
            Console.WriteLine("Enter the wind speed");

            input = Console.ReadLine();

            windSpeed = int.Parse(input);

            // Calculate the wind chill

            windChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);

            Console.WriteLine("The wind chill is " + windChill);
            }
        }
    }
}
