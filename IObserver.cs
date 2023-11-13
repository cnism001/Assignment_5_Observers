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
                $"Humidity: {data.Humidity}%\n Pressure: {data.Pressure} hPa\n Weather Prediction: {data.WeatherPrediction}");
        }
    }
}