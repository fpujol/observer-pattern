using observation_pattern.interfaces;

namespace observation_pattern.Display
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Forecast: " + temperature + " F degress and " + humidity + "% humidity");
        }

        public void Update()
        {
            this.temperature = weatherData.GetTemperature();
            this.humidity = weatherData.GetHumidity();
            Display();
        }
    }
}
