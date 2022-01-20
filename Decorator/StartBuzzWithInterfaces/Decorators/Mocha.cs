using StartBuzzWithInterfaces.Components.Abstractions;
using StartBuzzWithInterfaces.Decorators.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartBuzzWithInterfaces.Decorators
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(IBeverage beverage)
        {
            _beverage = beverage;
            _description = ", Mocha";
            _cost = .20;
        }
    }
}
