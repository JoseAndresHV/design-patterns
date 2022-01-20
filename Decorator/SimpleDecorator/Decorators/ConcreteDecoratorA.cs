using SimpleDecorator.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDecorator.Decorators
{
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component component) : base(component)
        {
        }

        public override string Operation()
        {
            return $"ConcreteDecoratorA({ base.Operation() })";
        }
    }
}
