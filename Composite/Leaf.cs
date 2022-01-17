


/**
* @(#) Leaf.cs
*/
using System;
namespace Composite
{
    public class Leaf : Component
    {
        string name;
        public Leaf(string name)
        {
            this.name = name;
        }

        public void Execute()
        {
            Console.WriteLine(name);
        }
    }

}
