using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator.QuackStrategies
{
    public class Squeak : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Squeak Squeak...");
        }
    }
}
