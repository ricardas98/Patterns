


/**
* @(#) OddNumberHandler.cs
*/
using System.Collections.Generic;
using System;
namespace ChainOfResponsibility
{
    public class OddNumberHandler : IHandler
    {
        IHandler next;
        public void HandleRequest(List<int> arr)
        {
            foreach (var item in arr)
            {
                if(item % 2 == 1)
                {
                    Console.WriteLine("There can't be any odd numbers in the array");
                    return;
                }
            }
            next.HandleRequest(arr);
        }

        public void SetNext(IHandler handler)
        {
            next = handler;
        }
    }

}
