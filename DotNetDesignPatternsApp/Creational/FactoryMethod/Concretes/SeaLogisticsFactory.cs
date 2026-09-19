using DotNetDesignPatternsApp.Creational.FactoryMethod.Contracts;

namespace DotNetDesignPatternsApp.Creational.FactoryMethod.Concretes;

public class SeaLogisticsFactory : LogisticsFactory
{
    public override ITransport CreateTransport() => new Ship();
}
