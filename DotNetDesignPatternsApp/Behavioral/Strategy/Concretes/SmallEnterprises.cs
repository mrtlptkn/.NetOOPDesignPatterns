using DotNetDesignPatternsApp.Behavioral.Strategy.Contracts;

namespace DotNetDesignPatternsApp.Behavioral.Strategy.Concretes;

public class SmallEnterprises : ICommissionStrategy
{
    public decimal Apply(decimal amount, string currency)
    {
        Console.WriteLine("Applying commission for small enterprises in " + amount + " " + currency);
        return amount * 0.02m; // 2% commission for small enterprises
    }
}
