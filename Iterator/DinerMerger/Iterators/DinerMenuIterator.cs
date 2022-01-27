using DinerMerger.Aggregates.Items;
using DinerMerger.Iterators.Base;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DinerMerger.Iterators
{
    public class DinerMenuIterator : IIterator
    {
        MenuItem[] _items;
        int _position = 0;

        public DinerMenuIterator(MenuItem[] list)
        {
            _items = list;
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
            if (nextPosition >= 0 && nextPosition < _items.Length)
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
