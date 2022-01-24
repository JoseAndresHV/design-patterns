using DuckTestDrive.Adaptee;
using DuckTestDrive.Adapter;
using DuckTestDrive.Target;
using System;

namespace DuckTestDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            IDuck duck = new MallardDuck();

            ITurkey turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("->Duck");
            TestDuck(duck);

            Console.WriteLine("->Adapted Turkey");
            TestDuck(turkeyAdapter);
        }

        public static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
