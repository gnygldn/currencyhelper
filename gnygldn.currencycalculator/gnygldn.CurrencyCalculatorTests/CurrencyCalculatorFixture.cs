using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using gnygldn.CurrencyCalculator;
using NUnit.Framework;
using FluentAssertions;

namespace gnygldn.CurrencyCalculatorTests
{
    [TestFixture]
    public class CurrencyCalculatorFixture
    {
        [Test]
        public void TranslateJsonFixer()
        {
            var response = new ExchangeRateProvider( infoList ,"JSON");
            response.TranslateIntoJsnList(infoList);
            response.Should().Be("asd");
        }
        [Test]
        public void TranslateXmlFixer()
        {
            var response = new ExchangeRateProvider(infoList, "XML");
            response.TranslateIntoXmlList(infoList);
            response.Should().Be("asd");
        }
        [Test]
        public void RateFinderFixer()
        {
            var response = new ExchangeRateProvider(infoList,type);
            response.FindRate("USD", "TRY", convertedList);
            response.Should().Be(2.98);
        }
    }
}
