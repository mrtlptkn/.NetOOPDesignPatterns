using DotNetDesignPatternsApp.Structural.Composite.Contracts;

namespace DotNetDesignPatternsApp.Structural.Composite.Concretes;

// Composite: alt elemanlarý (dosya ya da klasör) barýndýrabilen bileþik nesne.
// System.IO.Directory ile isim çakýþmasýný önlemek için sýnýf adý Folder olarak seçildi.
// GetSize çaðrýsý, aðacý özyinelemeli (recursive) olarak dolaþarak tüm alt elemanlarýn boyutunu toplar.
public class Folder : IFileSystemComponent
{
    public string Name { get; }
    private readonly List<IFileSystemComponent> _children = new();

    public Folder(string name)
    {
        Name = name;
    }

    public void Add(IFileSystemComponent component)
    {
        _children.Add(component);
    }

    public void Remove(IFileSystemComponent component)
    {
        _children.Remove(component);
    }

    public void Display(int depth = 0)
    {
        Console.WriteLine(new string('-', depth) + Name + "/");

        foreach (var child in _children)
        {
            child.Display(depth + 2);
        }
    }

    public long GetSize()
    {
        return _children.Sum(c => c.GetSize());
    }
}
