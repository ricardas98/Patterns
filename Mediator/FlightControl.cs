/**
 * @(#) FlightControl.cs
 */
using System;
namespace Mediator
{
    public class FlightControl : Mediator
    {
        Aircraft airliner, helicopter, jet;
        public FlightControl(Aircraft airliner, Aircraft helicopter, Aircraft jet)
        {
            this.airliner = airliner;
            this.helicopter = helicopter;
            this.jet = jet;
        }
        public void Notify(Aircraft sender, string e)
        {
            if(sender.Equals(airliner))
            {
                if (e.Equals("land"))
                {
                    Console.WriteLine("Looking if air strip is empty");
                    Console.WriteLine("Good to land");
                }else if (e.Equals("takeOff"))
                {
                    Console.WriteLine("Looking if air strip is empty");
                    Console.WriteLine("Good to take off");
                }
            }else if (sender.Equals(helicopter))
            {
                if (e.Equals("land"))
                {
                    Console.WriteLine("Good to land");
                }
                else if (e.Equals("takeOff"))
                {
                    Console.WriteLine("Good to take off");
                }
            }else if (sender.Equals(jet))
            {
                if (e.Equals("land"))
                {
                    Console.WriteLine("Clearing the air strip");
                    Console.WriteLine("Good to land");
                }
                else if (e.Equals("takeOff"))
                {
                    Console.WriteLine("Clearing the air strip");
                    Console.WriteLine("Good to take off");
                }
            }
        }
    }

}
