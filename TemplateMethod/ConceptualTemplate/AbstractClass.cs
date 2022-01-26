using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptualTemplate
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            BaseOperation1();
            RequiredOperation1();
            Hook1();
            BaseOperation2();
            RequiredOperation2();
            Hook2();
        }

        protected void BaseOperation1()
        {
            Console.WriteLine($"BaseOperation1: { GetType().Name } implementation");
        }

        protected void BaseOperation2()
        {
            Console.WriteLine($"BaseOperation2: { GetType().Name } implementation");
        }

        protected abstract void RequiredOperation1();
        protected abstract void RequiredOperation2();

        protected virtual void Hook1()
        {
        }

        protected virtual void Hook2()
        {
        }
    }
}
