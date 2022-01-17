

/**
* @(#) Composite.cs
*/
using System.Collections.Generic;
namespace Composite
{
	public class Composite : Component
	{
		private List<Component> children;
		
		public Composite ()
        {
			children = new List<Component>();
        }
		public void Add(Component child)
		{
			children.Add(child);
		}
		
		public void Remove(Component child)
		{
			children.Remove(child);
		}

		public List<Component> GetChildren(  )
		{
			return children;
		}

        public void Execute()
        {
            foreach (Component child in children)
            {
				child.Execute();
            }
        }
    }
	
}
