
/**
* @(#) TreeFactory.cs
*/
using System.Collections.Generic;
namespace Flyweight
{
	public class TreeFactory
	{
		private List<TreeTypeFlyweight> treeTypes = new List<TreeTypeFlyweight>();
		
		public TreeTypeFlyweight GetTreeType(string name, string color)
		{
            foreach (TreeTypeFlyweight type in treeTypes)
            {
				if(type.GetName().Equals(name) && type.GetColor().Equals(color))
                {
					return type;
                }
			}
			treeTypes.Add(new TreeTypeFlyweight(name, color));
			return treeTypes[treeTypes.Count - 1];
		}

		public int GetTypesCount()
        {
			return treeTypes.Count;
        }
		
	}
	
}
