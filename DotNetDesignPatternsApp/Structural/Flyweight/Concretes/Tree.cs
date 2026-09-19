using DotNetDesignPatternsApp.Structural.Flyweight.Contracts;

namespace DotNetDesignPatternsApp.Structural.Flyweight.Concretes;

// Extrinsic (paylaþýlmayan) durumu tutan nesne: konum bilgisi kendine özgüdür,
// ancak görsel özellikleri (isim, renk, doku) paylaþýlan TreeType referansý üzerinden eriþilir.
public class Tree
{
    public int X { get; }
    public int Y { get; }
    private readonly ITreeType _type;

    public Tree(int x, int y, ITreeType type)
    {
        X = x;
        Y = y;
        _type = type;
    }

    public void Draw()
    {
        _type.Draw(X, Y);
    }
}
