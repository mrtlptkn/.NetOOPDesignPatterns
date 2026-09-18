namespace DotNetDesignPatternsApp.Structural.Decorator;

// Decore edilecek yeni özellikler ile fiyatı değişecek olan
// ürünün abstract'ı
public interface IBeverage
{
    decimal Cost { get; }
    string Description { get; }
}
