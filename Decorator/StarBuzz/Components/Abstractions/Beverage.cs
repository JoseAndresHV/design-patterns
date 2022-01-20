using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz.Components.Abstractions
{
    public abstract class Beverage
    {
        public virtual string Description { get; protected set; } = "Unknown description";

        public abstract double Cost();

        public override string ToString()
        {
            return $"{ Description }: ${Cost()}";
        }
    }
}
