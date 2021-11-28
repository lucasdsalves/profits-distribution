namespace ProfitsDistribution.Domain.Tools
{
    public static class CurrencyTools
    {
        public static string DoubleToStringCurrency(this double value)
        {
            return value.ToString("C");
        }
    }
}
