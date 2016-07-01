namespace gnygldn.CurrencyCalculator
{
    public class Calculator
    {
        private ExchangeRateProvider exchangeRateProvider;

        public Calculator(ExchangeRateProvider exchangeRateProvider)
        {
            this.exchangeRateProvider = exchangeRateProvider;
        }

        public double Calculate(string current, string next, double amount,double rateIncreaser)
        {
            return Multiply(amount,exchangeRateProvider.FindRate(current, next,rateIncreaser));
        }

        public double Multiply(double amount,double rate)
        {
            return rate * amount;
        }

    }
}