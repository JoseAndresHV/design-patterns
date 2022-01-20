using StarBuzz.Components.Abstractions;
using StarBuzz.Decorators.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz.Decorators
{
    public class SteamedMilk : CondimentDecorator
    {
        private double _cost = .10;
        public override string Description => Beverage.Description + ", Steamed Milk";

        public SteamedMilk(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override double Cost()
        {
            return _cost + Beverage.Cost();
        }
    }
}
