using Animals.Clients;
using Animals.Factories;
using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var africa = new AnimalWorld(new AfricaFactory());
            africa.RunFoodChain();

            var america = new AnimalWorld(new AmericaFactory());
            america.RunFoodChain();
        }
    }
}
