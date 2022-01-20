using SimpleFactoryMethod.Creators;
using SimpleFactoryMethod.Creators.Abstractions;
using SimpleFactoryMethod.Products.Abstractions;
using System;

namespace SimpleFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creatorA = new ConcreteCreatorA();
            Creator creatorB = new ConcreteCreatorB();

            IProduct productA = creatorA.FactoryMethod();
            Console.WriteLine(productA.Operation());
            IProduct productB = creatorB.FactoryMethod();
            Console.WriteLine(productB.Operation());
        }
    }
}
