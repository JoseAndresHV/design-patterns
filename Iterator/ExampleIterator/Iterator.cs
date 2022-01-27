using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIterator
{
    public class Iterator : IAbstractIterator
    {
        Collection _collection;
        int _current = 0;
        int _step = 1;

        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }

        public Iterator(Collection collection)
        {
            _collection = collection;
        }

        public bool IsDone
        {
            get { return _current >= _collection.Count; }
        }

        public Item CurrentItem
        {
            get { return _collection[_current]; }
        }

        public Item Fist()
        {
            _current = 0;
            return _collection[_current];
        }

        public Item Next()
        {
            _current += _step;
            if (IsDone)
                return null;

            return _collection[_current];
        }
    }
}
