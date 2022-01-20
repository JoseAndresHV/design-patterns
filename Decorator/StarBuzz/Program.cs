using StarBuzz.Components;
using StarBuzz.Components.Abstractions;
using StarBuzz.Decorators;
using System;

namespace StarBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage);

            Beverage beverage1 = new DarkRoast();
            beverage1 = new Mocha(beverage1);
            beverage1 = new Mocha(beverage1);
            beverage1 = new Whip(beverage1);
            Console.WriteLine(beverage1);

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Soy(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2);
        }
    }
}
