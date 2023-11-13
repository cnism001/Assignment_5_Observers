using System;

namespace Assignment_5_Observers
{
    public interface IObserver
    {
        // The Update method that all observers must implement.
        // This method will be called when WeatherData updates its measurements.
        void Update(WeatherDataObject data);
    }
    public class CurrentConditionsDisplay : IObserver
    {
        // The method Update is defined here to handle the notification from the WeatherData
        public void Update(WeatherDataObject data)
        {
            
            // Since its a proof-of-concept, it simply prints the current conditions, each on new line.
            System.Console.WriteLine($"Current Conditions:\n Temperature: {data.Temperature}°C\n " +
                $"Humidity: {data.Humidity}%\n Pressure: {data.Pressure} hPa");
        }
    }
    public class WeatherStatsDisplay : IObserver
    {
        private float maxTemp = float.MinValue;
        private float minTemp = float.MaxValue;
        private float tempSum = 0.0f;
        private int numReadings = 0;

        // Update method  for weather statistics
        public void Update(WeatherDataObject data)
        {
            // Update temperature statistics using the data provided
            if (data.Temperature > maxTemp) { maxTemp = data.Temperature; }
            if (data.Temperature < minTemp) { minTemp = data.Temperature; }
            tempSum += data.Temperature;
            numReadings++;

            // Display the updated statistics
            DisplayStats();
        }

        private void DisplayStats()
        {
            // Calculate the average temperature
            //if number of readings is 0, the avgTemp is set as 0
            float avgTemp = numReadings > 0 ? tempSum / numReadings : 0;
            //Round avgTemp to 1 decimal point as float
            avgTemp = (float)Math.Round(avgTemp, 1);
            System.Console.WriteLine($"Weather Statistics:\n Avg Temperature: {avgTemp}°C\n Max Temperature: {maxTemp}°C\n Min Temperature: {minTemp}°C");
        }
    }
    public class ForecastDisplay : IObserver
    {
        private string lastForecast = "";

        // Update method implementation for the forecast display
        public void Update(WeatherDataObject data)
        {
            // Update the forecast using the data provided
            lastForecast = data.WeatherPrediction;

            // Display the updated forecast
            DisplayForecast();
        }

        private void DisplayForecast()
        {
            System.Console.WriteLine($"Weather Forecast: {lastForecast}");
        }
    }
    public class WindSpeedDisplay : IObserver
    {
        private float windSpeed;
        // Update method implementation for wind speed display
        public void Update(WeatherDataObject data)
        {
            // Wind speed is a new test property in WeatherDataObject
            windSpeed = data.WindSpeed;
            DisplayWindSpeed();
        }

        private void DisplayWindSpeed()
        {
            System.Console.WriteLine($"Wind Speed: {windSpeed} km/h");
        }
    }
}