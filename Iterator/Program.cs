using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ListAggregate aggregate = new ListAggregate();
            aggregate.AddWord("1");
            aggregate.AddWord("2");
            aggregate.AddWord("3");
            aggregate.AddWord("4");
            aggregate.AddWord("5");

            var iterator = aggregate.CreateIterator();
            var reverseIterator = aggregate.CreateReverseIterator();

            Console.WriteLine("Order iterator");
            while (!iterator.IsDone())
            {
                var word = iterator.GetNext();
                Console.WriteLine(word);
            }

            Console.WriteLine("\nReverse order iterator");
            while (!reverseIterator.IsDone())
            {
                var word = reverseIterator.GetNext();
                Console.WriteLine(word);
            }

        }
    }
}
