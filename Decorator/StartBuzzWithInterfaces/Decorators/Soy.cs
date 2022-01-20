using StartBuzzWithInterfaces.Components.Abstractions;
using StartBuzzWithInterfaces.Decorators.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartBuzzWithInterfaces.Decorators
{
    public class Soy : CondimentDecorator
    {
        public Soy(IBeverage beverage)
        {
            _beverage = beverage;
            _description = ", Soy";
            _cost = .15;
        }
    }
}
