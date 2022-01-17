/**
 * @(#) Car.cs
 */
using System;
namespace Memento
{
	public class Car : Originitator
	{
		private int power;

		private string color;

		public Car(int power, string color)
        {
			this.power = power;
			this.color = color;
        }
		public void SetStats(int power, string color)
        {
			this.power = power;
			this.color = color;
        }

		public void GetStats()
        {
			Console.WriteLine(String.Format("Power: {0} | Color: {1}", power, color));
        }

		public Memento SaveMemento()
        {
			return new CarMemento(this, power, color);
        }
		public void SetState(int power, string color)
        {
			this.power = power;
			this.color = color;
        }
    }
	
}
