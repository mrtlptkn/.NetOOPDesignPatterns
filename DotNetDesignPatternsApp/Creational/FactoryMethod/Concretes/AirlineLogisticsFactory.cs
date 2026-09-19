using DotNetDesignPatternsApp.Creational.FactoryMethod.Contracts;

namespace DotNetDesignPatternsApp.Creational.FactoryMethod.Concretes;

public class AirlineLogisticsFactory : LogisticsFactory
{
    public override ITransport CreateTransport() => new Airplane();
}
