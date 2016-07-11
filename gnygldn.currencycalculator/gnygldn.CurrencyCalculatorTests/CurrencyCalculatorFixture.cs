using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using gnygldn.CurrencyCalculator;
using NUnit.Framework;
using FluentAssertions;
using gnygldn.currencycalculator;

namespace gnygldn.CurrencyCalculatorTests
{
    [TestFixture]
    public class CurrencyCalculatorFixture
    {
        private string infoList;
        private ExchangeInfoList convertedList;
        private ExchangeRateProvider tryExchangeRateProvider;
        [Test]
        public void TranslateJsonFixer()
        {
            var response = new JsonHandler(infoList);
            response.TranslateIntoJsnList(infoList);
            response.ConvertedList.Should().Be("asd");
        }
        [Test]
        public void TranslateXmlFixer()
        {
            var response = new XmlHandler(infoList);
            response.TranslateIntoXmlList(infoList);
            response.ConvertedList.Should().Be("asd");
        }
        [Test]
        public void RateFinderFixer()
        {
            var response = new ExchangeRateProvider(convertedList);
            var response2 = response.FindRate("USD", "TRY", 3);
            response2.Should().Be(2.98);
        }

        [Test]
        public void MultiplyFixer()
        {
            var response = new Calculator(tryExchangeRateProvider );
            var response2 = response.Multiply(3, 5);
            response2.Should().Be(15);
        }
    }
}
