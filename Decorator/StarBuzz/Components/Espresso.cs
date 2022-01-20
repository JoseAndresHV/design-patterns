using StarBuzz.Components.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz.Components
{
    public class Espresso : Beverage
    {
        private double _cost = 1.99;

        public Espresso()
        {
            Description = "Espresso";
        }

        public override double Cost()
        {
            return _cost;
        }
    }
}
