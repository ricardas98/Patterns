

/**
* @(#) NonTerminalExpression.cs
*/
using System.Collections.Generic;
namespace Interpreter
{
	public class NonTerminalExpression : AbstractExpression
	{
		List<AbstractExpression> expressions;

        public NonTerminalExpression() {
            expressions = new List<AbstractExpression>();
        }
		public NonTerminalExpression(List<AbstractExpression> expressions)
        {
			this.expressions = expressions;
        }
        public void AddExpression(AbstractExpression expression)
        {
            expressions.Add(expression);
        }

        public override string Interpret(string context)
        {

            foreach (AbstractExpression expression in expressions)
            {
                if (!expression.Interpret(context).Equals(context))
                {
                    return "#$&*@";
                }
            }
            return context;
        }
    }
	
}
