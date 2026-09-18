namespace DotNetDesignPatternsApp.Creational.FactoryMethod;

public class RoadLogisticsFactory : LogisticsFactory
{
    public override ITransport CreateTransport() => new Truck();
}
