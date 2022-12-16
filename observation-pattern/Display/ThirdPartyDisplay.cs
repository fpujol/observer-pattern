using observation_pattern.interfaces;

namespace observation_pattern.Display
{
    public class ThirdPartyDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private WeatherData weatherData;

        public ThirdPartyDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Third Party: " + temperature + " F degress and " + humidity + "% humidity");
        }

        public void Update()
        {
            this.temperature = weatherData.GetTemperature();
            this.humidity = weatherData.GetHumidity();
            Display();
        }
    }
}
