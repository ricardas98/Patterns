/**
 * @(#) Aircraft.cs
 */

namespace Mediator
{
	public abstract class Aircraft
	{
		protected Mediator mediator;
		
		public Aircraft(Mediator mediator = null)
        {
			this.mediator = mediator;
        }
		public abstract void takeOff(  );
		
		public abstract void land(  );

		public void Set(Mediator mediator)
        {
			this.mediator = mediator;
        }
		
	}
	
}
