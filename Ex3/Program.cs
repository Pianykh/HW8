using System;

/*
3.Реализовать функции изменения значимых и ссылочных типов данных.
*/

namespace Ex3
{
    internal class Program
    {
        private static void Main()
        {
            var k = "string";  

            Console.WriteLine(k);
            ChangeVariable(ref k,"changedString");
            Console.WriteLine(k);

            var obj = new object();
            var obj2 = new object();

            Console.WriteLine(obj.GetHashCode());
            ChangeVariable(ref obj, obj2);
            Console.WriteLine(obj.GetHashCode());
        }

        static void ChangeVariable<T>(ref T variableName, T newValue)
        {
            variableName = newValue;
        }
    }
}
