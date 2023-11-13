namespace Assignment_5_Observers
{
    public interface IObserver
    {
        // The Update method that all observers must implement.
        // This method will be called when WeatherData updates its measurements.
        void Update(float temperature, float humidity, float pressure, string weatherPrediction);
    }
    public class CurrentConditionsDisplay : IObserver
    {
        // The method Update is defined here to handle the notification from the WeatherData
        public void Update(float temperature, float humidity, float pressure, string weatherPrediction)
        {
            
            // Since its a proof-of-concept, it simply prints the current conditions, each on new line.
            System.Console.WriteLine($"Current Conditions:\n Temperature: {temperature}°C\n " +
                $"Humidity: {humidity}%\n Pressure: {pressure} hPa\n Weather Prediction: {weatherPrediction}");
        }
    }
}