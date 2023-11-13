using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_Observers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the WeatherData object, Subject for observer pattern
            WeatherData weatherData = new WeatherData();

            // Create observer instances
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay();
            WeatherStatsDisplay weatherStatsDisplay = new WeatherStatsDisplay();
            ForecastDisplay forecastDisplay = new ForecastDisplay();
            //new displays would be added here

            // Register observers with the WeatherData object
            weatherData.RegisterObserver(currentConditionsDisplay);
            weatherData.RegisterObserver(weatherStatsDisplay);
            weatherData.RegisterObserver(forecastDisplay);

            // Test measurements, in full programm here you would fetch the data from Weather-o-Rama
            weatherData.SetMeasurements(15.3f, 35.0f, 1010.0f, "Clear sky and Sunny");
            weatherData.SetMeasurements(18.1f, 90.0f, 1012.0f, "Intermittent rain");
            weatherData.SetMeasurements(22.0f, 70.0f, 1013.0f, "Cloudy with low chance of rain");

        }
    }
}
