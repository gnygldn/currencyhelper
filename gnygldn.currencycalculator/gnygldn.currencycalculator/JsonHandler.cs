using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
