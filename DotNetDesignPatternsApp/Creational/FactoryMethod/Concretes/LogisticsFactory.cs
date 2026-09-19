using DotNetDesignPatternsApp.Creational.FactoryMethod.Contracts;

namespace DotNetDesignPatternsApp.Creational.FactoryMethod.Concretes;

// Logistics sınıfı Transport sınıfına direk bağlı değil. DIP prensibine de uygun hareket ettik.
public abstract class LogisticsFactory
{
    public abstract ITransport CreateTransport();

    // PlanDelivery doğru Transport'un instance yönetiminin yapıldığını ekranda görmek için tanımlanmış bir method.
    public void PlanDelivery()
    {
        ITransport transport = CreateTransport();
        transport.Deliver();
    }
}
