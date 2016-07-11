using System.Xml;
using System.Xml.Serialization;
using gnygldn.CurrencyCalculator;

namespace gnygldn.currencycalculator
{
    public class XmlHandler
    {
        public ExchangeInfoList ConvertedList;

        public XmlHandler(string infoList)
        {
            this.ConvertedList = TranslateIntoXmlList(infoList);
        }

        public ExchangeInfoList TranslateIntoXmlList(string infoList)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ExchangeInfoList));
            return (ExchangeInfoList)serializer.Deserialize(new XmlTextReader(infoList));

        }
    }
}
