using DotNetDesignPatternsApp.Structural.Flyweight.Contracts;

namespace DotNetDesignPatternsApp.Structural.Flyweight.Concretes;

// Paylaþýlan (intrinsic) durumu tutan somut Flyweight. Ayný özelliklere sahip bütün aðaçlar arasýnda
// tek bir örnek olarak paylaþýlýr; bu sayede ayný türden binlerce aðaç için ayrý ayrý nesne oluþturulmaz.
public class TreeType : ITreeType
{
    public string Name { get; }
    public string Color { get; }
    public string Texture { get; }

    public TreeType(string name, string color, string texture)
    {
        Name = name;
        Color = color;
        Texture = texture;
    }

    public void Draw(int x, int y)
    {
        Console.WriteLine($"Tree [{Name}, {Color}, {Texture}] drawn at ({x}, {y})");
    }
}
