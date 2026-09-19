using DotNetDesignPatternsApp.Structural.Flyweight.Contracts;

namespace DotNetDesignPatternsApp.Structural.Flyweight.Concretes;

// Flyweight Factory: ayný intrinsic durumdaki TreeType nesnelerini önbelleðe alýr ve tekrar kullanýr.
// Ayný (isim, renk, doku) kombinasyonuna sahip bir TreeType daha önce oluþturulmuþsa,
// yeni bir nesne yaratmak yerine mevcut olan döndürülür; böylece bellek tasarrufu saðlanýr.
public class TreeFactory
{
    private readonly Dictionary<string, ITreeType> _treeTypes = new();

    public ITreeType GetTreeType(string name, string color, string texture)
    {
        var key = $"{name}_{color}_{texture}";

        if (!_treeTypes.TryGetValue(key, out var treeType))
        {
            treeType = new TreeType(name, color, texture);
            _treeTypes[key] = treeType;
            Console.WriteLine($"Yeni TreeType oluþturuldu: {key}");
        }

        return treeType;
    }

    public int TreeTypeCount => _treeTypes.Count;
}
