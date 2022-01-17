

/**
* @(#) SumHandler.cs
*/
using System.Collections.Generic;
using System;
namespace ChainOfResponsibility
{
    public class SumHandler : IHandler
    {
        IHandler next;
        public void HandleRequest(List<int> arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            if(sum > 10)
            {
                Console.WriteLine("The sum can't be bigger than 10");
                return;
            }
            else
            {
                next.HandleRequest(arr);
            }
            
        }

        public void SetNext(IHandler handler)
        {
            next = handler;
        }
    }

}
