using DotNetDesignPatternsApp.Structural.Flyweight.Concretes;

namespace DotNetDesignPatternsApp.Structural.Flyweight.Application;

// Not: Flyweight tasarým deseni, çok sayýda benzer nesne oluþturulmasý gereken durumlarda
// bellek kullanýmýný azaltmak için nesnelerin paylaþýlabilir (intrinsic) durumunu ortak bir havuzda tutar.
// Nesnenin paylaþýlamayan (extrinsic) durumu ise dýþarýdan, ilgili nesneye parametre olarak verilir.
// Bu örnekte bir ormandaki binlerce aðacýn TreeType (tür, renk, doku) bilgisi paylaþýlýrken,
// her aðacýn konumu (X, Y) kendine özgü kalýr.
public class ForestApplication
{
    private readonly TreeFactory _treeFactory;
    private readonly List<Tree> _trees = new();

    public ForestApplication(TreeFactory treeFactory)
    {
        _treeFactory = treeFactory;
    }

    public void PlantForest()
    {
        var treeData = new (int X, int Y, string Name, string Color, string Texture)[]
        {
            (10, 20, "Oak", "Green", "Rough"),
            (30, 40, "Oak", "Green", "Rough"),
            (50, 60, "Pine", "DarkGreen", "Smooth"),
            (70, 80, "Oak", "Green", "Rough"),
            (90, 100, "Pine", "DarkGreen", "Smooth")
        };

        foreach (var data in treeData)
        {
            var type = _treeFactory.GetTreeType(data.Name, data.Color, data.Texture);
            _trees.Add(new Tree(data.X, data.Y, type));
        }

        foreach (var tree in _trees)
        {
            tree.Draw();
        }

        Console.WriteLine($"Toplam aðaç: {_trees.Count}, Paylaþýlan TreeType sayýsý: {_treeFactory.TreeTypeCount}");
    }
}
