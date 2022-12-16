using observation_pattern.interfaces;
using System.Runtime.ConstrainedExecution;

namespace observation_pattern.Display
{
    public class HeatIndexDisplay : IObserver, IDisplayElement
    {
        private float temperature=1;
        private float humidity;
        private float heatIndex;
        private WeatherData weatherData;
        private float c1 = -42.379f;
        private float c2 = -2.04901523f;
        private float c3 = -10.14333127f;
        private float c4 = -0.22475541f;
        private float c5 = -6.83783f * (float)Math.Pow(10, -3);
        private float c6 = -5.481717f * (float)Math.Pow(10, -2);
        private float c7 = -1.22874f * (float) Math.Pow(10, -3);
        private float c8 = 8.5282f * (float)Math.Pow(10, -4);
        private float c9 = -1.99f * (float) Math.Pow(10, -6);

        public HeatIndexDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;

            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Heat Index: " + heatIndex);
        }

        public void Update()
        {
            temperature = weatherData.GetTemperature();
            humidity = weatherData.GetHumidity();
            heatIndex = CalculateHeatIndex(temperature, humidity);
            Display();
        }

        private float CalculateHeatIndex(float temperature, float humidity)
        {
            return c1 + (c2 * temperature) + (c3 * humidity) +  (c4 * temperature * humidity + c5) * (float)Math.Pow(temperature,2) + c6 * (float)Math.Pow(humidity,2) + c7 * (float)Math.Pow(temperature,2) * humidity + (c8 * temperature * (float)Math.Pow(humidity,2)) + (c9 * (float)Math.Pow(temperature,2)) * (float)Math.Pow(humidity,2);
        }

    }
}
