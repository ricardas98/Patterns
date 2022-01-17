/**
 * @(#) BusStation.cs
 */

namespace Visitor
{
	public class BusStation : Building
	{
		public override void Accept(Visitor visitor)
		{
			visitor.visitBusStation();
		}
	}
	
}
