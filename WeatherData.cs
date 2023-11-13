using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_Observers
{
    public class WeatherData
    {
        // A list of registered observers
        private List<IObserver> observers;

       
        private float temperature;
        private float humidity;
        private float pressure;
        private string weatherPrediction;
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
                observer.Update(temperature, humidity, pressure, weatherPrediction);
            }
        }
        // Method to set the measurements and notify observers
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            // Set the current weather measurements
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

           NotifyObservers();
        }
    }
}
