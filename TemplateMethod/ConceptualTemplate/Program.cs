using System;

namespace ConceptualTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Client.ClientCode(new ConcreteClass1());

            Console.WriteLine(new string('-', 50));

            Client.ClientCode(new ConcreteClass2());
        }
    }
}
