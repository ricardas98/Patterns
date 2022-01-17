/**
 * @(#) OffState.cs
 */
using System;
namespace State
{
	public class OffState : State
	{
		PhoneContext context;

        public OffState(PhoneContext context)
        {
            this.context = context;
        }

        public void PressKeyboardButtons()
        {
            Console.WriteLine("Does nothing");
        }

        public void PressPowerButton()
        {
            Console.WriteLine("Power on");
            context.ChangeState(new LockedState(context));
        }

        public void PressVolumeButtons()
        {
            Console.WriteLine("Does nothing");
        }
    }
	
}
