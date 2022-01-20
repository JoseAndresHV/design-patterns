using StartBuzzWithInterfaces.Components.Abstractions;
using StartBuzzWithInterfaces.Decorators.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartBuzzWithInterfaces.Decorators
{
    public class SteamedMilk : CondimentDecorator
    {
        public SteamedMilk(IBeverage beverage) 
        {
            _beverage = beverage;
            _description = ", Steamed Milk";
            _cost = .10;
        }
    }
}
