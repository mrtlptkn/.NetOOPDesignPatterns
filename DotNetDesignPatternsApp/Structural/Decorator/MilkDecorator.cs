namespace DotNetDesignPatternsApp.Structural.Decorator;

public class MilkDecorator : BeverageDecorator
{
    public MilkDecorator(IBeverage wrapper) : base(wrapper)
    {
    }

    public override decimal Cost => Wrapper.Cost * 1.1m;

    public override string Description => Wrapper.Description + " + with Milk";
}
