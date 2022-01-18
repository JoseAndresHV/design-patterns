using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Subject;

namespace WeatherStation.Observers
{
    public class TempStadisticsDisplay : IObserver, IDisplay
    {
        private double _maxTemp = -100;
        private double _tempSum = 0;
        private double _minTemp = 100;
        private int _readingsCount = 0;
        private WeatherData _weatherData;

        public TempStadisticsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.Attach(this);
        }

        public void Display()
        {
            Console.WriteLine("->Temperature Stadistics Display\n" +
                $"Max Temp: {_maxTemp}C degrees\n" +
                $"Min Temp: {_minTemp}C degrees\n" +
                $"Avg Temp: {_tempSum / _readingsCount}C degrees\n");
        }

        public void Update(double temp, double humidity, double pressure)
        {
            if (temp > _maxTemp)
                _maxTemp = temp;

            if (temp < _minTemp)
                _minTemp = temp;

            _tempSum += temp;
            _readingsCount++;

            Display();
        }
    }
}
