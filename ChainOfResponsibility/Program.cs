using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            arr.Add(2);
            arr.Add(2);
            arr.Add(4);

            OddNumberHandler handler1 = new OddNumberHandler();
            SumHandler handler2 = new SumHandler();
            ZeroHandler handler3 = new ZeroHandler();

            handler1.SetNext(handler2);
            handler2.SetNext(handler3);

            handler1.HandleRequest(arr);
        }
    }
}
