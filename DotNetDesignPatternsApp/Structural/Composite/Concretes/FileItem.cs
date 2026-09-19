using DotNetDesignPatternsApp.Structural.Composite.Contracts;

namespace DotNetDesignPatternsApp.Structural.Composite.Concretes;

// Leaf: alt elemaný olmayan somut nesne. Composite aðacýnýn en alt (yaprak) düðümünü temsil eder;
// kendi içinde baþka bir IFileSystemComponent barýndýrmaz.
public class FileItem : IFileSystemComponent
{
    public string Name { get; }
    private readonly long _size;

    public FileItem(string name, long size)
    {
        Name = name;
        _size = size;
    }

    public void Display(int depth = 0)
    {
        Console.WriteLine(new string('-', depth) + Name + $" ({_size} bytes)");
    }

    public long GetSize() => _size;
}
