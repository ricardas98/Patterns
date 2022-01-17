using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Leaf general = new Leaf("general");
            Leaf soldier1 = new Leaf("soldier1");
            Leaf soldier11 = new Leaf("soldier11");
            Leaf soldier111 = new Leaf("soldier111");
            Leaf soldier2 = new Leaf("soldier2");
            Leaf soldier22 = new Leaf("soldier22");

            Composite platoon1 = new Composite();
            Composite platoon2 = new Composite();

            Composite army = new Composite();

            platoon1.Add(soldier1);
            platoon1.Add(soldier11);
            platoon1.Add(soldier111);

            platoon2.Add(soldier2);
            platoon2.Add(soldier22);

            army.Add(general);
            army.Add(platoon1);
            army.Add(platoon2);

            army.Execute();


        }
    }
}
