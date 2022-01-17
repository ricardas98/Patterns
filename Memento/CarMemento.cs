/**
 * @(#) CarMemento.cs
 */

namespace Memento
{
	public class CarMemento : Memento
	{
		Car originator;

		int power;

		string color;

		public CarMemento(Car car, int power, string color)
		{
			this.originator = car;
			this.power = power;
			this.color = color;
		}

        public void Restore()
        {
			originator.SetState(power, color);
        }
    }
	
}
