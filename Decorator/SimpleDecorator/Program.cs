using SimpleDecorator.Components;
using SimpleDecorator.Decorators;
using System;

namespace SimpleDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            var component = new ConcreteComponent();
            client.ClientCode(component);

            var decoratorA = new ConcreteDecoratorA(component);
            var decoratorB = new ConcreteDecoratorB(decoratorA);
            client.ClientCode(decoratorB);
        }
    }
}
