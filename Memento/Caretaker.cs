
/**
* @(#) Caretaker.cs
*/
using System.Collections.Generic;
namespace Memento
{
	public class Caretaker
	{
		private List<Memento> history;
		private Car originator;

		public Caretaker(Car originator)
        {
			history = new List<Memento>();
			this.originator = originator;
        }
		
		public void Undo(  )
		{
			if(history.Count == 0)
            {
				return;
            }

			var memento = history[history.Count - 1];
			history.Remove(memento);

			memento.Restore();
		}

		public void MakeBackup()
        {
			history.Add(originator.SaveMemento());
        }
		
	}
	
}
