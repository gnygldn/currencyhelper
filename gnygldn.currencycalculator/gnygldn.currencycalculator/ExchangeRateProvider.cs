using Newtonsoft.Json;

namespace gnygldn.CurrencyCalculator
{
    public class ExchangeRateProvider
    {
        public JsonList MyList;

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
            MyList = (JsonList)JsonConvert.DeserializeObject(infoList, typeof(JsonList));
        }

        public void TranslateIntoXmlList(string infoList)
        {
            
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