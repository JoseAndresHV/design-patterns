using StartBuzzWithInterfaces.Components.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartBuzzWithInterfaces.Components
{
    public class DarkRoast : IBeverage
    {
        private readonly string _description;
        private readonly double _cost;

        public DarkRoast()
        {
            _description = "Dark Roast";
            _cost = .99;
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
