using observation_pattern.interfaces;

namespace observation_pattern
{
    public class WeatherData : ISubject
    {

        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;
        
        public WeatherData()
        {
            observers = new List<IObserver>();
        }
        
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
         
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }
        
        public void MeasuramentsChanged() { 
            NotifyObservers(); 
        }

        public void SetMeasuraments(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasuramentsChanged();
        }

        public float GetTemperature() => temperature;

        public float GetHumidity() => humidity; 

    }
}
