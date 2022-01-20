using StartBuzzWithInterfaces.Components.Abstractions;
using StartBuzzWithInterfaces.Decorators.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartBuzzWithInterfaces.Decorators
{
    public class Whip : CondimentDecorator
    {
        public Whip(IBeverage beverage)
        {
            _beverage = beverage;
            _description = ", Whip";
            _cost = .10;
        }
    }
}
