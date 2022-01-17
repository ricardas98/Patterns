using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteClass1 class1 = new ConcreteClass1();
            ConcreteClass2 class2 = new ConcreteClass2();

            Console.WriteLine("Class1\n");
            class1.TemplateMethod();
            Console.WriteLine("\n\nClass2");
            class2.TemplateMethod();

        }
    }
}
