using System.Collections;

namespace DesignPattern.Behavioral.Iterator.IIterator.IAIterator
{
    public abstract class AIteratorAggregate
    {
        // Returns an Iterator or another IteratorAggregate for the implementing
        // object.
        public abstract IEnumerator GetEnumerator();
    }
}
