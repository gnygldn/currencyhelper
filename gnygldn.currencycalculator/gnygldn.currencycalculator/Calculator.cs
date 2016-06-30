namespace gnygldn.CurrencyCalculator
{
    public class Calculator
    {
        private ExchangeRateProvider exchangeRateProvider;

        public Calculator(ExchangeRateProvider exchangeRateProvider)
        {
            this.exchangeRateProvider = exchangeRateProvider;
        }

        public double Calculate(string current, string next, double amount)
        {
            return Multiply(amount,exchangeRateProvider.FindRate(current, next, exchangeRateProvider.ConvertedList));
        }

        public double Multiply(double amount,double rate)
        {
            return rate * amount;
        }

    }
}