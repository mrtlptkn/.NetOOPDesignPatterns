namespace DotNetDesignPatternsApp.Creational.FactoryMethod;

public class SeaLogisticsFactory : LogisticsFactory
{
    public override ITransport CreateTransport() => new Ship();
}
