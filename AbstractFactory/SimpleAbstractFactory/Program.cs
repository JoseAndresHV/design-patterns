using SimpleAbstractFactory.Clients;
using SimpleAbstractFactory.Factories;
using System;

namespace SimpleAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client(new ConcreteFactory1());
            client1.Run();

            Client client2 = new Client(new ConcreteFactory2());
            client2.Run();
        }
    }
}
