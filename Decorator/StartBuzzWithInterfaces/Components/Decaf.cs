using StartBuzzWithInterfaces.Components.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartBuzzWithInterfaces.Components
{
    public class Decaf : IBeverage
    {
        private readonly string _description;
        private readonly double _cost;

        public Decaf()
        {
            _description = "Decaf";
            _cost = 1.05;
        }

        public double Cost()
        {
            return _cost;
        }

        public string GetDescription()
        {
            return _description;
        }
    }
}
