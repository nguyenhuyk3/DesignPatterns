using DesignPattern.Behavioral.Iterator.IIterator.IAIterator;
using DesignPattern.Behavioral.Iterator.IIterator.IConcreteIterator;
using System.Collections;
using System.Collections.Generic;

namespace DesignPattern.Behavioral.Iterator.IConcreteCollection
{
    public class WordsCollection : AIteratorAggregate
    {
        List<string> _collection = new List<string>();

        bool _direction = false;

        public void ReverseDirection()
        {
            _direction = !_direction;
        }

        public List<string> getItems()
        {
            return _collection;
        }

        public void AddItem(string item)
        {
            this._collection.Add(item);
        }

        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _direction);
        }
    }
}
