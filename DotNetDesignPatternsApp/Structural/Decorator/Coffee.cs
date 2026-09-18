namespace DotNetDesignPatternsApp.Structural.Decorator;

public class Coffee : IBeverage
{
    public decimal Cost { get; set; }
    public string Description { get; set; } = "Sade Kahve";
}
