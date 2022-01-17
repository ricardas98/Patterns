/**
 * @(#) Airliner.cs
 */

namespace Mediator
{
    public class Airliner : Aircraft
    {
        public override void land()
        {
            base.mediator.Notify(this, "land");
        }

        public override void takeOff()
        {
            base.mediator.Notify(this, "takeOff");
        }

        public void SetMediator(Mediator mediator)
        {
            base.Set(mediator);
        }
    }

}
