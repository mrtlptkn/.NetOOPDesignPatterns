using DotNetDesignPatternsApp.Structural.Decorator.Contracts;

namespace DotNetDesignPatternsApp.Structural.Decorator.Concretes;

public class Coffee : IBeverage
{
    public decimal Cost { get; set; }
    public string Description { get; set; } = "Sade Kahve";
}
