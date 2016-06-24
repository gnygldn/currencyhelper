using Newtonsoft.Json;

namespace gnygldn.CurrencyCalculator
{
    public class ExchangeRateProvider
    {
        readonly string _infoList;
        public JsnList MyList;

        public ExchangeRateProvider(string infoList)
        {
            // TODO: Complete member initialization
            _infoList = infoList;
        }

        public void TranslateIntoJsnList()
        {
            MyList = (JsnList)JsonConvert.DeserializeObject(_infoList, typeof(JsnList));
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