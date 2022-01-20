using StartBuzzWithInterfaces.Components;
using StartBuzzWithInterfaces.Components.Abstractions;
using StartBuzzWithInterfaces.Decorators;
using System;

namespace StartBuzzWithInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IBeverage beverage = new Espresso();
            Console.WriteLine("{0}: ${1}", beverage.GetDescription(), beverage.Cost());

            IBeverage beverage1 = new DarkRoast();
            beverage1 = new Mocha(beverage1);
            beverage1 = new Mocha(beverage1);
            beverage1 = new Whip(beverage1);
            Console.WriteLine("{0}: ${1}", beverage1.GetDescription(), beverage1.Cost());

            IBeverage beverage2 = new HouseBlend();
            beverage2 = new Soy(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine("{0}: ${1}", beverage2.GetDescription(), beverage2.Cost());
        }
    }
}
