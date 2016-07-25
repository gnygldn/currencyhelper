using System.IO;
using System.Xml;
using System.Xml.Serialization;
using gnygldn.CurrencyCalculator;

namespace gnygldn.currencycalculator
{
    public class XmlHandler
    {
        public GetExchangeRatesResponse ConvertedList;

        public XmlHandler(string infoList)
        {
            this.ConvertedList = TranslateIntoXmlList(infoList);
        }

        public GetExchangeRatesResponse TranslateIntoXmlList(string infoList)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(GetExchangeRatesResponse));
            return (GetExchangeRatesResponse)serializer.Deserialize(new StringReader(infoList));

        }
    }
}
