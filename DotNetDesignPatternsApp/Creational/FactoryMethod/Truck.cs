namespace DotNetDesignPatternsApp.Creational.FactoryMethod;

public class Truck : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Karayoluyla teslimat gerçekleştirildi (Truck)");
    }
}
