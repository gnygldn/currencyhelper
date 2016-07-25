//infolist stands for the list which have basecurrency,countercurrency and rate

using System;
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
            WebClient client = new WebClient();
            client.Headers.Add("Accept", "application/json");
            var infoList =
                client.DownloadString(
                    "http://api.dev.paximum.com/v1/currency/GetExchangeRates?basecurrency=USD&access_token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwczovL2F1dGgucGF4aW11bS5jb20iLCJhdWQiOiJodHRwczovL2FwaS5wYXhpbXVtLmNvbSIsIm5iZiI6MTQ2ODMxMDQ5MiwiZXhwIjoxNDcyNjg4MDAwLCJzdWIiOiI0MzZiYWYwNy01ZTRmLTQyMDEtYjBlNS01Njk3NzUyZGI3NmUiLCJyb2xlIjoicGF4OmRldmVsb3BlciJ9.jnHkmkXThdVZAwzr38lgqi3ZnnXEM3fpY-XeZsQyfnw");

            //XmlHandler xmlList = new XmlHandler(infoList);

            JsonHandler jsonList = new JsonHandler(infoList);

            Calculator calculator = new Calculator(new ExchangeRateProvider(jsonList.ConvertedList));
            result = calculator.Calculate("USD", "TRY", 100, 0);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
