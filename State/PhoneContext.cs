/**
 * @(#) PhoneContext.cs
 */

namespace State
{
	public class PhoneContext
	{
		private State state;
		
		public void ChangeState(State state)
		{
			this.state = state;	
		}
		
		public void PressKeyboardButtons(  )
		{
			state.PressKeyboardButtons();
		}
		
		public void PressPowerButton(  )
		{
			state.PressPowerButton();
		}
		
		public void PressVolumeButtons(  )
		{
			state.PressVolumeButtons();
		}
		
	}
	
}
