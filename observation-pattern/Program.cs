using observation_pattern.Display;

namespace observation_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay stadisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasuraments(80, 65, 30.4f);
            weatherData.SetMeasuraments(82, 70, 29.2f);
            weatherData.SetMeasuraments(78, 90, 29.2f);

            Console.ReadLine();
            //Console.WriteLine("Hello, World!");
        }
    }
}