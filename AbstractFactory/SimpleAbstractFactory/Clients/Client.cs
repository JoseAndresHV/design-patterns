using SimpleAbstractFactory.Factories.Abstractions;
using SimpleAbstractFactory.Products.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAbstractFactory.Clients
{
    public class Client
    {
        private IAbstractProductA _abstractProductA;
        private IAbstractProductB _abstractProductB;

        public Client(IAbstractFactory factory)
        {
            _abstractProductA = factory.CreateProductA();
            _abstractProductB = factory.CreateProductB();
        }

        public void Run()
        {
            Console.WriteLine(_abstractProductB.AnotherOperationB(_abstractProductA));
        }
    }
}
