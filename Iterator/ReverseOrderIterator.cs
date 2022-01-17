

/**
* @(#) ReverseOrderIterator.cs
*/
using System.Collections.Generic;
namespace Iterator
{
	public class ReverseOrderIterator : Iterator
	{
        private ListAggregate aggregate;

        private List<string> cache;
        private int currentPosition;

        public ReverseOrderIterator(ListAggregate aggregate)
        {
            this.aggregate = aggregate;
            cache = aggregate.GetWords();
            currentPosition = cache.Count-1;
        }

        public override string GetNext()
        {
            if (!IsDone())
            {
                return cache[currentPosition--];
            }
            return "";
        }

        public override bool IsDone()
        {
            if (currentPosition < 0) return true;
            return false;
        }
    }
	
}
