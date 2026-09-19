namespace DotNetDesignPatternsApp.Structural.Flyweight.Contracts;

// Flyweight: birden fazla nesne arasýnda paylaþýlan, deðiþmeyen (intrinsic) durumu tutan arayüz.
// Bu arayüzü implemente eden sýnýflar, TreeFactory tarafýndan önbelleðe alýnarak tekrar kullanýlýr.
public interface ITreeType
{
    string Name { get; }
    string Color { get; }
    string Texture { get; }

    void Draw(int x, int y);
}
