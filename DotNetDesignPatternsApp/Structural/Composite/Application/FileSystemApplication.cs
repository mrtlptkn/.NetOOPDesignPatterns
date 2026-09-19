using DotNetDesignPatternsApp.Structural.Composite.Concretes;

namespace DotNetDesignPatternsApp.Structural.Composite.Application;

// Not: Composite (Bileþik) tasarým deseni, tekil (leaf) nesneler ile bunlardan oluþan bileþik (composite)
// nesnelerin ayný arayüz üzerinden, ayrým gözetmeksizin tekdüze (uniform) bir þekilde kullanýlmasýný saðlar.
// Bu örnekte bir dosya sistemi modellenir: FileItem tekil bir dosyayý, Folder ise içinde baþka dosya ve
// klasörler barýndýrabilen bileþik yapýyý temsil eder. Ýkisi de IFileSystemComponent üzerinden kullanýlýr.
public class FileSystemApplication
{
    public void BuildAndDisplay()
    {
        var root = new Folder("root");

        var documents = new Folder("documents");
        documents.Add(new FileItem("cv.pdf", 1024));
        documents.Add(new FileItem("notes.txt", 512));

        var images = new Folder("images");
        images.Add(new FileItem("photo.png", 2048));

        root.Add(documents);
        root.Add(images);
        root.Add(new FileItem("readme.md", 256));

        root.Display();

        Console.WriteLine($"Toplam boyut: {root.GetSize()} bytes");
    }
}
