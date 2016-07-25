using System;

namespace gnygldn.CurrencyCalculator
{
    public class ExchangeRateProvider
    {
        readonly GetExchangeRatesResponse ConvertedList;


        public ExchangeRateProvider(GetExchangeRatesResponse getExchangeRatesResponse)
        {
            this.ConvertedList = getExchangeRatesResponse;
        }



        public double FindRate(string current, string next, double rateIncreaser)
        {
            foreach (var pair in ConvertedList.CurrencyPairs)
            {
                if (pair.BaseCurrency == current && pair.CounterCurrency == next)
                {
                    return (100 + rateIncreaser) / 100 * (pair.Rate);
                }
            }
            throw new SystemException("no such pair was found, please check your inputs or information soource");
        }
    }
}