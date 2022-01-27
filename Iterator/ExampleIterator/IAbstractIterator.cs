using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIterator
{
    public interface IAbstractIterator
    {
        Item Fist();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }
    }
}
