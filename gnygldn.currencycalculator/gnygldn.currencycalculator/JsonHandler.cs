using gnygldn.CurrencyCalculator;
using Newtonsoft.Json;

namespace gnygldn.currencycalculator
{
    public class JsonHandler
    {
        public GetExchangeRatesResponse ConvertedList;

        public JsonHandler(string infoList)
        {
            ConvertedList = TranslateIntoJsnList(infoList);
        }

        public GetExchangeRatesResponse TranslateIntoJsnList(string infoList)
        {
            return (GetExchangeRatesResponse)JsonConvert.DeserializeObject(infoList, typeof(GetExchangeRatesResponse));
        }
    }
}
