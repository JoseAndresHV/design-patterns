using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Observers;

namespace WeatherStation.Subject
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;
        private double _temperature;
        private double _humidity;
        private double _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            if (_observers.Contains(observer))
                _observers.Remove(observer);
        }

        public void Notify()
        {
            _observers.ForEach(o => o.Update(_temperature, _humidity, _pressure));
        }

        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            Notify();
        }
    }
}
