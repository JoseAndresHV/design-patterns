using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartBuzzWithInterfaces.Components.Abstractions
{
    public interface IBeverage
    {
        public double Cost();
        public string GetDescription();
    }
}
