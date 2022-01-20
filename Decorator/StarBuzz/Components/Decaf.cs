using StarBuzz.Components.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz.Components
{
    public class Decaf : Beverage
    {
        private double _cost = 1.05;

        public Decaf()
        {
            Description = "Decaf";
        }

        public override double Cost()
        {
            return _cost;
        }
    }
}
