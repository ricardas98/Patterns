

/**
* @(#) OrderIterator.cs
*/
using System.Collections.Generic;
namespace Iterator
{
	public class OrderIterator : Iterator
	{
		private ListAggregate aggregate;

		private List<string> cache;
		private int currentPosition;

		public OrderIterator(ListAggregate aggregate)
        {
			this.aggregate = aggregate;
			cache = aggregate.GetWords();
			currentPosition = 0;
        }

        public override string GetNext()
        {
            if (!IsDone())
            {
                return cache[currentPosition++];
            }
            return "";
        }

        public override bool IsDone()
        {
            if (currentPosition > cache.Count - 1) return true;
            return false;
        }
    }
	
}
