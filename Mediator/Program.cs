using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Airliner airliner = new Airliner();
            Helicopter helicopter = new Helicopter();
            Jet jet = new Jet();

            FlightControl control = new FlightControl(airliner, helicopter, jet);

            airliner.SetMediator(control);
            helicopter.SetMediator(control);
            jet.SetMediator(control);

            airliner.takeOff();
            airliner.land();

            helicopter.takeOff();
            helicopter.land();

            jet.takeOff();
            jet.land();
        }
    }
}
