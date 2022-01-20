using StartBuzzWithInterfaces.Components.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartBuzzWithInterfaces.Decorators.Abstraction
{
    public abstract class CondimentDecorator : IBeverage
    {
        protected IBeverage _beverage;
        protected string _description;
        protected double _cost;
        public double Cost()
        {
            return _beverage.Cost() + _cost;
        }

        public string GetDescription()
        {
            return _beverage.GetDescription() + _description;
        }
    }
}
