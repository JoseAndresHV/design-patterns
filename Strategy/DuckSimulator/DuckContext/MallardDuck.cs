using DuckSimulator.FlyStrategies;
using DuckSimulator.QuackStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator.DuckContext
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new Quack();
        }

        public override void display()
        {
            Console.WriteLine("I'm a Mallard Duck");
        }
    }
}
