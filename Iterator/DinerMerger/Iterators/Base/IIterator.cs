using DinerMerger.Aggregates.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMerger.Iterators.Base
{
    public interface IIterator : IEnumerator<MenuItem>
    {
    }
}
