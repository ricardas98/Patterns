using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            //["test", "hello you", "cheap shit", "crap", "shi cra"]
            words.Add("test");
            words.Add("hello you");
            words.Add("shit");
            words.Add("cheap shit");
            words.Add("crap");
            words.Add("shi cra");


            AbstractExpression shit = new TerminalExpression("shit");
            AbstractExpression crap = new TerminalExpression("crap");
            AbstractExpression bitch = new TerminalExpression("bitch");

            
            NonTerminalExpression shitWords = new NonTerminalExpression();
            shitWords.AddExpression(shit);
            shitWords.AddExpression(crap);
            
            NonTerminalExpression curseWords = new NonTerminalExpression();
            curseWords.AddExpression(shitWords);
            curseWords.AddExpression(bitch);

            foreach (string word in words)
            {
                Console.WriteLine(curseWords.Interpret(word));
            }
        }
    }
}
