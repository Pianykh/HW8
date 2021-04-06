using System;

/*
5.Реализовать функции изменения для ссылочных типов внутри значимых типов.
*/

namespace Ex5
{
    internal class Program
    {
        private static void Main()
        {
            var car = new Car {IsStarted = false, Color = "red", Passenger = new Passenger()};

            Console.WriteLine($"{car.IsStarted}, {car.Color}, {car.Passenger.Name}");
            ChangePassengerName(ref car, "Jimmie Johnson");
            Console.WriteLine($"{car.IsStarted}, {car.Color}, {car.Passenger.Name}");
        }

        static void ChangePassengerName(ref Car car, string newName)
        {
            car.Passenger.Name = newName;
        }
    }

    struct Car
    {
        public bool IsStarted;
        public string Color;
        public Passenger Passenger;
    }

    class Passenger
    {
        public string Name = "Mario Andretti";
    }
}
