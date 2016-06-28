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


        public ExchangeRateProvider(string infoList, string type)
        {
            // TODO: Complete member initialization
            if (type == "JSON")
                ConvertedList = TranslateIntoJsnList(infoList);
            if (type == "XML")
                ConvertedList = TranslateIntoXmlList(infoList);
        }

        public ExchangeInfoList TranslateIntoJsnList(string infoList)
        {
            return (ExchangeInfoList)JsonConvert.DeserializeObject(infoList, typeof(ExchangeInfoList));
        }

        public ExchangeInfoList TranslateIntoXmlList(string infoList)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ExchangeInfoList));
            return (ExchangeInfoList)serializer.Deserialize(new XmlTextReader(infoList));

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