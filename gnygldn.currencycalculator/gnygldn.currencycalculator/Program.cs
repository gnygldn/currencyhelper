﻿//infolist stands for the list which have basecurrency,countercurrency and rate

namespace gnygldn.CurrencyCalculator
{
    class Program
    {
        private static string infoList;
        private static string currentCurrency;
        private static string nextCurrency;
        private static double amount;
        private static double result;

        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(new ExchangeRateProvider(infoList));
            result = calculator.Calculate(currentCurrency, nextCurrency, amount);
        }
    }
}