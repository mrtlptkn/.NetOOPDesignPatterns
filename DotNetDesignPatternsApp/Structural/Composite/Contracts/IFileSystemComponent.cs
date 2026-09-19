namespace DotNetDesignPatternsApp.Structural.Composite.Contracts;

// Composite deseninde hem yaprak (leaf, örn. FileItem) hem de bileþik (composite, örn. Folder)
// elemanlarýn uyduðu ortak arayüz. Ýstemci kod, tekil ya da bileþik olduðuna bakmaksýzýn
// bu arayüz üzerinden ayný þekilde çalýþabilir.
public interface IFileSystemComponent
{
    string Name { get; }

    void Display(int depth = 0);

    long GetSize();
}
