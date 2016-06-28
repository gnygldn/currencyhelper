namespace gnygldn.CurrencyCalculator
{
    public class Calculator
    {
       // public double _rate;
        private ExchangeRateProvider exchangeRateProvider;

        public Calculator(ExchangeRateProvider exchangeRateProvider)
        {
            this.exchangeRateProvider = exchangeRateProvider;
        }

        public double Calculate(string current, string next, double amount)
        {
            double _rate = exchangeRateProvider.FindRate(current, next, exchangeRateProvider.ConvertedList);
            return _rate*amount;
        }
    }
}