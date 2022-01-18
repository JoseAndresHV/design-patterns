using DuckSimulator.DuckContext;
using System;

namespace DuckSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.display();
            mallard.PerformFly();
            mallard.PerformQuack();

            Duck rubber = new RubberDuck();
            rubber.display();
            rubber.PerformFly();
            rubber.PerformQuack();
        }
    }
}
