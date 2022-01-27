using DinerMerger.Aggregates.Items;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMerger.Iterators
{
    public class PancakeHouseMenuIterator : IEnumerator<MenuItem>
    {
        List<MenuItem> _items;
        int _position = 0;

        public PancakeHouseMenuIterator(List<MenuItem> items)
        {
            _items = items;
        }

        public MenuItem Current
        {
            get { return _items[_position]; }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            int nextPosition = _position + 1;
            if (nextPosition >= 0 && nextPosition < _items.Count)
            {
                _position++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _position = 0;
        }
    }
}
