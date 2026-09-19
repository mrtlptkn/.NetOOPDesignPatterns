using DotNetDesignPatternsApp.Structural.Decorator.Contracts;

namespace DotNetDesignPatternsApp.Structural.Decorator.Concretes;

public class Tea : IBeverage
{
    public string Description { get; set; } = "Çay";
    public decimal Cost { get; set; } = 10.0m;
}
