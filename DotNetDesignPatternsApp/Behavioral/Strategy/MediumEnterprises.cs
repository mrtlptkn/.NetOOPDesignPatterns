namespace DotNetDesignPatternsApp.Behavioral.Strategy;

public class MediumEnterprises : ICommissionStrategy
{
    public decimal Apply(decimal amount, string currency)
    {
        Console.WriteLine("Applying commission for medium enterprises in " + amount + " " + currency);
        return amount * 0.07m; // 7% commission for medium enterprises
    }
}
