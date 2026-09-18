namespace DotNetDesignPatternsApp.Structural.Decorator;

// Base Beverage içerisinde ekstra hiçbir malzeme olmayan en saf hali ile içeriği kullanmak için
// kullandığımız abstract sınıf.
// Oluşturulacak farklı versiyondaki içecekler bu class'tan kalıtım alacak.
public abstract class BeverageDecorator : IBeverage
{
    protected readonly IBeverage Wrapper;

    protected BeverageDecorator(IBeverage wrapper)
    {
        Wrapper = wrapper;
    }

    public abstract decimal Cost { get; }
    public abstract string Description { get; }
}
