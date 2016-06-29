using System;
using System.CodeDom;
using System.Xml;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace gnygldn.CurrencyCalculator
{
    public class ExchangeRateProvider
    {
        public ExchangeInfoList ConvertedList;


        public ExchangeRateProvider(ExchangeInfoList exchangeInfoList)
        {
            this.ConvertedList = exchangeInfoList;
        }

        

        public double FindRate(string current, string next, ExchangeInfoList list)
        {
            foreach (var pair in list.CurrencyPairs)
            {
                if (pair.BaseCurrency == current && pair.CounterCurrency == next)
                {
                    return pair.Rate;
                }
            }
            throw new SystemException("no such pair was found, please check your inputs or information soource");
        }
    }
}