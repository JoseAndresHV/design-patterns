using System;

namespace ObjectAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new();
            ITarget target = new Adapter(adaptee);
            target.Request();
        }
    }
}
