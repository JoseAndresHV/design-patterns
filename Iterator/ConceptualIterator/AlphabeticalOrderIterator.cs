using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptualIterator
{
    public class AlphabeticalOrderIterator : Iterator
    {
        private WordsCollection _collection;
        private int _position = -1;
        private bool _reverse = false;

        public AlphabeticalOrderIterator(WordsCollection collection, bool reverse)
        {
            _collection = collection;
            _reverse = reverse;

            _position = reverse ? _collection.GetItems().Count : -1;
        }


        public override object Current()
        {
            return _collection.GetItems()[_position];
        }

        public override int Key()
        {
            return _position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = _position + (_reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < _collection.GetItems().Count)
            {
                _position = updatedPosition;
                return true;
            }

            return false;
        }

        public override void Reset()
        {
            _position = _reverse ? _collection.GetItems().Count - 1 : -1; 
        }
    }
}
