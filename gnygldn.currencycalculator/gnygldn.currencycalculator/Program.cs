//infolist stands for the list which have basecurrency,countercurrency and rate

using System.Net;
using gnygldn.currencycalculator;

namespace gnygldn.CurrencyCalculator
{
    class Program
    {
        private static string infoList;
        private static string currentCurrency;
        private static string nextCurrency;
        private static double amount;
        private static double result;
        private static double rateIncreaser;

        static void Main(string[] args)
        {
            JsonHandler jsonList = new JsonHandler(infoList);
            Calculator calculator = new Calculator(new ExchangeRateProvider(jsonList.ConvertedList));
            result = calculator.Calculate(currentCurrency, nextCurrency, amount,rateIncreaser);
        }
    }
}