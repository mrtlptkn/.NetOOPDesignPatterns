using DotNetDesignPatternsApp.Creational.FactoryMethod.Contracts;

namespace DotNetDesignPatternsApp.Creational.FactoryMethod.Concretes;

public class RoadLogisticsFactory : LogisticsFactory
{
    public override ITransport CreateTransport() => new Truck();
}
