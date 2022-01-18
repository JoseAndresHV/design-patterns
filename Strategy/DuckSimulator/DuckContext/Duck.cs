using DuckSimulator.FlyStrategies;
using DuckSimulator.QuackStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator.DuckContext
{
    public abstract class Duck
    {
        protected IFly FlyBehavior;
        protected IQuack QuackBehavior;

        public abstract void display();

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }
    }
}
