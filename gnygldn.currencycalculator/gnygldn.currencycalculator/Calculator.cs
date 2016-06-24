namespace gnygldn.CurrencyCalculator
{
    public class Calculator
    {
        private double _rate;
        private ExchangeRateProvider exchangeRateProvider;

        public Calculator(ExchangeRateProvider exchangeRateProvider)
        {
            this.exchangeRateProvider = exchangeRateProvider;
        }

        public double Calculate(string current, string next, double amount)
        {
            _rate = exchangeRateProvider.FindRate(current, next);
            return _rate*amount;
        }
    }
}