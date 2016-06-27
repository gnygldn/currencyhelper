using System.Xml;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace gnygldn.CurrencyCalculator
{
    public class ExchangeRateProvider
    {
        public ExchangeInfoList MyList;


        public ExchangeRateProvider(string infoList,string type)
        {
            // TODO: Complete member initialization
            if (type == "JSON")
            TranslateIntoJsnList(infoList);
            if(type == "XML")
            TranslateIntoXmlList(infoList);
        }

        public void TranslateIntoJsnList(string infoList)
        {
            MyList = (ExchangeInfoList)JsonConvert.DeserializeObject(infoList, typeof(ExchangeInfoList));
        }

        public void TranslateIntoXmlList(string infoList)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ExchangeInfoList));
            MyList = (ExchangeInfoList)serializer.Deserialize(new XmlTextReader(infoList));
             
        }

        public double FindRate(string current, string next)
        {
            foreach (var pairs in MyList.CurrencyPairs)
            {
                if (pairs.BaseCurrency == current && pairs.CounterCurrency == next)
                {
                    return pairs.Rate;
                }
            }
            return 0;
        }
    }
}