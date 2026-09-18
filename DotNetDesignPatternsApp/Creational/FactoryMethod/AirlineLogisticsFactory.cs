namespace DotNetDesignPatternsApp.Creational.FactoryMethod;

public class AirlineLogisticsFactory : LogisticsFactory
{
    public override ITransport CreateTransport() => new Airplane();
}
