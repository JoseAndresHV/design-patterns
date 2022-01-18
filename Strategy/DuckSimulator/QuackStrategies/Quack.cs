using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator.QuackStrategies
{
    public class Quack : IQuack
    {
        void IQuack.Quack()
        {
            Console.WriteLine("Quack Quack...");
        }
    }
}
