using System;

namespace ConceptualFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            Client.ClientCode(new Facade(new Subsystem1(), new Subsystem2()));
        }
    }
}
