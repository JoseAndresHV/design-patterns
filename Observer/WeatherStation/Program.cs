using System;
using WeatherStation.Observers;
using WeatherStation.Subject;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            var currentDisplay = new CurrentConditionDisplay(weatherData);
            var stadisticsDisplay = new TempStadisticsDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30);
            weatherData.SetMeasurements(81, 60, 31);
            weatherData.SetMeasurements(85, 61, 36);
            weatherData.SetMeasurements(70, 63, 38);
            weatherData.SetMeasurements(50, 60, 32);
        }
    }
}
