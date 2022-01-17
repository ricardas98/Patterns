

using System.Collections.Generic;
/**
* @(#) ListAggregate.cs
*/
namespace Iterator
{
    public class ListAggregate : Aggregate
    {
        private List<string> words;
        public ListAggregate()
        {
            words = new List<string>();
        }

        public void AddWord(string word)
        {
            words.Add(word);
        }
        public List<string> GetWords()
        {
            return words;
        }

        public override OrderIterator CreateIterator()
        {
            return new OrderIterator(this);
        }

        public override ReverseOrderIterator CreateReverseIterator()
        {
            return new ReverseOrderIterator(this);
        }
    }

}
