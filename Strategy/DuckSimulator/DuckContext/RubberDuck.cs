using DuckSimulator.FlyStrategies;
using DuckSimulator.QuackStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator.DuckContext
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Squeak();
        }

        public override void display()
        {
            Console.WriteLine("I'm a Rubber Duck");
        }
    }
}
