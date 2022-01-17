/**
 * @(#) LockedState.cs
 */
using System;
namespace State
{
	public class LockedState : State
	{
		PhoneContext context;

        public LockedState(PhoneContext context)
        {
            this.context = context;
        }

        public void PressKeyboardButtons()
        {
            Console.WriteLine("Unlocked");
            context.ChangeState(new UnlockedState(context));
        }

        public void PressPowerButton()
        {
            Console.WriteLine("Power off");
            context.ChangeState(new OffState(context));
        }

        public void PressVolumeButtons()
        {
            Console.WriteLine("Does nothing");
        }
    }
	
}
