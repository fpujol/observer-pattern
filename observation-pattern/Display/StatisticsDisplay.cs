using observation_pattern.interfaces;

namespace observation_pattern.Display
{
    internal class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private WeatherData weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Statistic: " + temperature + " F degress and " + humidity + "% humidity");
        }

        public void Update()
        {
            this.temperature = weatherData.GetTemperature();
            this.humidity = weatherData.GetHumidity();
            Display();
        }
    }
}
