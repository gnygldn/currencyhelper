using gnygldn.CurrencyCalculator;
using Newtonsoft.Json;

namespace gnygldn.currencycalculator
{
    public class JsonHandler
    {
        public ExchangeInfoList ConvertedList;

        public JsonHandler(string infoList)
        {
            ConvertedList = TranslateIntoJsnList(infoList);
        }

        public ExchangeInfoList TranslateIntoJsnList(string infoList)
        {
            return (ExchangeInfoList)JsonConvert.DeserializeObject(infoList, typeof(ExchangeInfoList));
        }
    }
}
