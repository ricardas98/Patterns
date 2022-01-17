


/**
* @(#) ZeroHandler.cs
*/
using System.Collections.Generic;
using System;
namespace ChainOfResponsibility
{
    public class ZeroHandler : IHandler
    {
        IHandler next;

        public void HandleRequest(List<int> arr)
        {
            foreach (var item in arr)
            {
                if(item == 0)
                {
                    Console.WriteLine("There can't be any zeros in the array");
                    return;
                }
            }
            Console.WriteLine("The array passed the validation");
        }

        public void SetNext(IHandler handler)
        {
            next = handler;
        }
    }

}
