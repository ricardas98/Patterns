
/**
* @(#) TerminalExpression.cs
*/
using System;
namespace Interpreter
{
	public class TerminalExpression : AbstractExpression
	{
		private string data;
		public TerminalExpression(string data)
        {
			this.data = data.ToUpper();
        }

		public override string Interpret(string context)
        {
			if (data.Contains(context.ToUpper())) 
			{
				return "#$&*@";
			}
			return context;
        }
	}
	
}
