using StarBuzz.Components.Abstractions;
using StarBuzz.Decorators.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz.Decorators
{
    public class Soy : CondimentDecorator
    {
        private double _cost = .15;
        public override string Description => Beverage.Description + ", Soy";

        public Soy(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override double Cost()
        {
            return _cost + Beverage.Cost();
        }
    }
}
