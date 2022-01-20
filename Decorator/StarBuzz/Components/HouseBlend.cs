using StarBuzz.Components.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz.Components
{
    public class HouseBlend : Beverage
    {
        private double _cost = .89;

        public HouseBlend()
        {
            Description = "House Blend";
        }

        public override double Cost()
        {
            return _cost;
        }
    }
}
