
/**
* @(#) ForestContext.cs
*/
using System.Collections.Generic;
namespace Flyweight
{
	public class ForestContext
	{
		private TreeFactory factory = new TreeFactory();
		private List<Tree> trees = new List<Tree>();
		
		public void PlantTree(string name, string color, int height)
		{
			TreeTypeFlyweight treeType = factory.GetTreeType(name, color);
			trees.Add(new Tree(treeType, height));
		}
		
		public void DrawTrees(  )
		{
            foreach (Tree tree in trees)
            {
				tree.Draw();
            }
		}

		public int GetTreeCount()
        {
			return trees.Count;
        }

		public int GetTypeCount()
        {
			return factory.GetTypesCount();
        }
		
	}
	
}
