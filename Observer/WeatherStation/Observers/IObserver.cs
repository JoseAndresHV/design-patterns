using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.Observers
{
    public interface IObserver
    {
        public void Update(double temperature, double humidity, double pressure);
    }
}
