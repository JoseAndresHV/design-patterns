using StarBuzz.Components.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz.Decorators.Abstractions
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage Beverage;
        public abstract override string Description { get; }
    }
}
