using SimpleDecorator.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDecorator.Decorators
{
    public abstract class Decorator : Component
    {
        protected Component _component;

        public Decorator(Component component)
        {
            _component = component;
        }

        public override string Operation()
        {
            return _component.Operation();
        }
    }
}
