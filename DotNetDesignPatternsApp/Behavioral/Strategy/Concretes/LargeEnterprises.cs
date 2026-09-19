using DotNetDesignPatternsApp.Behavioral.Strategy.Contracts;

namespace DotNetDesignPatternsApp.Behavioral.Strategy.Concretes;

public class LargeEnterprises : ICommissionStrategy
{
    public decimal Apply(decimal amount, string currency)
    {
        Console.WriteLine("Applying commission for large enterprises in " + amount + " " + currency);
        return amount * 0.15m; // 15% commission for large enterprises
    }
}
