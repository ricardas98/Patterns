using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(10, "black");
            car.GetStats();

            Caretaker careTaker = new Caretaker(car);
           
            car.SetStats(20, "white");
            careTaker.MakeBackup();
            car.GetStats();

            car.SetStats(30, "green");
            careTaker.MakeBackup();
            car.GetStats();

            car.SetStats(40, "blue");
            car.GetStats();

            careTaker.Undo();
            car.GetStats();

            careTaker.Undo();
            car.GetStats();

            careTaker.Undo();
            car.GetStats();
        }
    }
}
