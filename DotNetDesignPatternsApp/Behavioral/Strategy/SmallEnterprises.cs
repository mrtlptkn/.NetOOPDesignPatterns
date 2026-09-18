namespace DotNetDesignPatternsApp.Behavioral.Strategy;

public class SmallEnterprises : ICommissionStrategy
{
    public decimal Apply(decimal amount, string currency)
    {
        Console.WriteLine("Applying commission for small enterprises in " + amount + " " + currency);
        return amount * 0.02m; // 2% commission for small enterprises
    }
}
