using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator.FlyStrategies
{
    public class FlyNoWay : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Impossible to fly...");
        }
    }
}
