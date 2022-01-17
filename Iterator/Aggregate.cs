/**
 * @(#) Aggregate.cs
 */

namespace Iterator
{
	public abstract class Aggregate
	{
		public abstract OrderIterator CreateIterator(  );
		public abstract ReverseOrderIterator CreateReverseIterator();

	}
	
}
