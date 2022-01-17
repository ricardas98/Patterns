/**
 * @(#) UnlockedState.cs
 */
using System;
namespace State
{
	public class UnlockedState : State
	{
		PhoneContext context;

        public UnlockedState(PhoneContext context)
        {
            this.context = context;
        }
        public void PressKeyboardButtons()
        {
            Console.WriteLine("Types something");
        }

        public void PressPowerButton()
        {
            Console.WriteLine("Power off");
            context.ChangeState(new OffState(context));
        }

        public void PressVolumeButtons()
        {
            Console.WriteLine("Tunes audio volume");
        }
    }
	
}
