using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptualTemplate
{
    public class ConcreteClass1 : AbstractClass
    {
        protected override void RequiredOperation1()
        {
            Console.WriteLine($"RequiredOperation1: { GetType().Name } implementation");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine($"RequiredOperation2: { GetType().Name } implementation");
        }

        protected override void Hook1()
        {
            Console.WriteLine($"Hook1: { GetType().Name } override");
        }
    }
}
