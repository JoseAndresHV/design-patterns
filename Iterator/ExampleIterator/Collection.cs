using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIterator
{
    public class Collection : IAbstractCollection
    {
        private List<Item> _items = new();
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public Item this[int index]
        {
            get { return _items[index];  }
            set { _items.Add(value);  } 
        }
    }
}
