using StarBuzz.Components.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz.Components
{
    public class DarkRoast : Beverage
    {
        private double _cost = .99;

        public DarkRoast()
        {
            Description = "Dark Roast";
        }

        public override double Cost()
        {
            return _cost;
        }
    }
}
