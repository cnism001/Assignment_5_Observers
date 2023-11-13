using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_Observers
{
    public class WeatherDataObject
    {
        // Properties for various weather measurement variables
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }
        public string WeatherPrediction { get; set; }
        public float WindSpeed { get; set; }

        // Additional properties can be added here without affecting the observers
    }
    public class WeatherData
    {
        // A list of registered observers
        private List<IObserver> observers;
        private WeatherDataObject weatherData;

        public WeatherData()
        {
            // Initializing the list of observers when WeatherData is instantiated
            observers = new List<IObserver>();
        }
        // Method to register an observer
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        // Method to remove an observer
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        // Method to notify all registered observers of a change in tracked variables
        public void NotifyObservers()
        {
            // Loop through all registered observers and call their Update method
            foreach (var observer in observers)
            {
                observer.Update(weatherData);
            }
        }
        // Method to set the measurements and notify observers
        public void SetMeasurements(float temperature, float humidity, float pressure, string weatherPrediction, float windSpeed)
        {
            // Set the current weather measurements
            weatherData.Temperature = temperature;
            weatherData.Humidity = humidity;
            weatherData.Pressure = pressure;
            weatherData.WeatherPrediction = weatherPrediction;
            weatherData.WindSpeed = windSpeed;
            NotifyObservers();
        }
    }
}
