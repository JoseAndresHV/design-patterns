using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Subject;

namespace WeatherStation.Observers
{
    class CurrentConditionDisplay : IObserver, IDisplay
    {
        private double _temperature;
        private double _humidity;
        private WeatherData _weatherData;

        public CurrentConditionDisplay(WeatherData wheaterData)
        {
            _weatherData = wheaterData;
            _weatherData.Attach(this);
        }

        public void Display()
        {
            Console.WriteLine("->Current Display\n" +
                $"Temperature: {_temperature}C degrees\n" +
                $"Humidity: {_humidity}%\n");
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            Display();
        }
    }
}
