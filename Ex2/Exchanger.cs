// unset

using System;
using System.Collections.Generic;

namespace Ex2
{
    public static class Exchanger
    {
        private static readonly Dictionary<string, double> _rates = new Dictionary<string, double>();

        static Exchanger()
        {
            _rates.Add("EURToUSD", 1.1875);
            _rates.Add("USDToEUR", 0.8419);
            _rates.Add("EURToGBP", 0.8588);
            _rates.Add("GBPToEUR", 1.1639);
            _rates.Add("USDToGBP", 0.7233);
            _rates.Add("GBPToUSD", 1.3823);
            _rates.Add("UAHToUSD", 0.0363);
            _rates.Add("USDToUAH", 27.8111);
            _rates.Add("UAHToEUR", 0.0301);
            _rates.Add("EURToUAH", 33.0213);
            _rates.Add("PLNToGBP", 0.1934);
            _rates.Add("GBPToPLN", 5.3519);
            _rates.Add("PLNToUSD", 0.2614);
            _rates.Add("USDToPln", 3.8742);
            _rates.Add("PLNToEUR", 0.2231);
            _rates.Add("EURToPLN", 4.5924);
            _rates.Add("PLNToUAH", 7.1921);
            _rates.Add("UAHToPLN", 0.1421);
            _rates.Add("UAHToGBP", 0.0261);
            _rates.Add("GBPToUAH", 38.4412);
            _rates.Add("CHFToGBP", 0.7800);
            _rates.Add("GBPToCHF", 1.2900);
            _rates.Add("UAHToCHF", 0.0340);
            _rates.Add("CHFToUAH", 29.8300);
            _rates.Add("EURToCHF", 1.1000);
            _rates.Add("CHFToEUR", 9.9000);
            _rates.Add("PLNToCHF", 0.2489);
            _rates.Add("CHFToPLN", 4.1611);
            _rates.Add("USDToCHF", 0.9331);
            _rates.Add("CHFToUSD", 1.0769);
        }
        public static void Exchange(string firstCode, string secondCode, double money)
        {
            Console.WriteLine(
                _rates.TryGetValue(firstCode.ToUpper() + "To" + secondCode.ToUpper(), out var exchangedMoney)
                    ? $"{money} {firstCode} is {exchangedMoney} {secondCode}"
                    : "Can not exchange the same currencies");
        }
    }
}