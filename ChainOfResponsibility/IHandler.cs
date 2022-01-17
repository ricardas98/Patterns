

/**
* @(#) IHandler.cs
*/
using System.Collections.Generic;
namespace ChainOfResponsibility
{
	public interface IHandler
	{
		void HandleRequest(List<int> arr);
		void SetNext(IHandler handler);
	}
	
}
