using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

/*
4.Реализовать функции изменения значимых и ссылочных типов данных для составных типов.
*/

namespace Ex4
{
    internal class Program
    {
        private static void Main()
        {
            var carAsStruct = new CarAsStruct{IsStarted = false, Color = "red"};

            Console.WriteLine($"{carAsStruct.IsStarted}, {carAsStruct.Color}");
            ChangeCarStructParameters(ref carAsStruct, true, "purple");
            Console.WriteLine($"{carAsStruct.IsStarted}, {carAsStruct.Color}");

            var carAsObject = new CarAsObject();

            Console.WriteLine($"{carAsObject.IsStarted}, {carAsObject.Color}");
            ChangeCarObjectParameters(carAsObject, true, "purple");
            Console.WriteLine($"{carAsObject.IsStarted}, {carAsObject.Color}");
        }

        static void ChangeCarStructParameters(ref CarAsStruct carAsStruct, bool isStarted, string color)
        {
            carAsStruct.IsStarted = isStarted;
            carAsStruct.Color = color;
        }

        static void ChangeCarObjectParameters(CarAsObject carAsObject, bool isStarted, string color)
        {
            carAsObject.IsStarted = isStarted;
            carAsObject.Color = color;
        }
    }

    struct CarAsStruct
    {
        public bool IsStarted;
        public string Color;
    }

    class CarAsObject
    {
        public bool IsStarted = false;
        public string Color = "red";
    }
    
    


}
