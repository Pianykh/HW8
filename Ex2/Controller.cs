// unset

using System;


namespace Ex2
{
    public static class Controller
    {
        public static void ShowMenu()
        {
            string firstCode;
            string secondCode;
            double money;

            Console.WriteLine("Money Exchanger. Available currency:");
            Console.WriteLine("USD\nEUR\nUAH\nPLN\nCHF\nGBP\n");
            Console.WriteLine("Please, enter currency you want to sell");
            
            while (true)
            {
                firstCode = Console.ReadLine();
                if (CodeChecker(firstCode))
                    break;
                Console.WriteLine("Need to enter one of available currency. Try again:");
            }
            
            Console.WriteLine($"Please, enter amount of {firstCode.ToUpper()}");
            
            while (true)
            {
                var moneyString = Console.ReadLine();
                if (double.TryParse(moneyString, out money))
                    break;
                Console.WriteLine($"Need to enter amount of {firstCode.ToUpper()} you want to sell. Try again:");
            }

            Console.WriteLine("Please, enter currency you want to buy");

            while (true)
            {
                secondCode = Console.ReadLine();
                if (CodeChecker(secondCode))
                    break;
                Console.WriteLine("Need to enter one of available currency. Try again:");
            }
            Exchanger.Exchange(firstCode, secondCode, money);
        }

        private static bool CodeChecker(string code)
        {
            if (code != null)
                return code == "UAH" || code == "EUR" || code == "USD" || code == "PLN" || code == "GBP" || code == "CHF";
            return false;

        }
    }
    
}