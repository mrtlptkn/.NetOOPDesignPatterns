using DotNetDesignPatternsApp.Structural.Decorator.Contracts;

namespace DotNetDesignPatternsApp.Structural.Decorator.Concretes;

public class CreamDecorator : BeverageDecorator
{
    public CreamDecorator(IBeverage wrapper) : base(wrapper)
    {
    }

    public override decimal Cost => Wrapper.Cost * 1.2m; // yüzde 20 ekledik

    public override string Description => Wrapper.Description + " + with Cream";
}
