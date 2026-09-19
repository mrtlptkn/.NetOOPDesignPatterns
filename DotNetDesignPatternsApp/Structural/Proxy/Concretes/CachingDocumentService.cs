using DotNetDesignPatternsApp.Structural.Proxy.Contracts;

namespace DotNetDesignPatternsApp.Structural.Proxy.Concretes;

// Proxy Service
public class CachingDocumentService : IDocumentService
{
    // Kodda herhangi bir imza değişimi yapmadan, sadece ilgili sınıfı CachingDocumentService proxy servisi ile
    // sarmalayarak ekstra bir kontrol özelliği kazandırmış olduk: Caching

    private readonly RealDocumentService _realDocumentService;

    // Simüle etmek için static yaptık, uygun bir kullanım değil.
    // Thread safe singleton pattern ile yapmak lazım.
    private static readonly List<Document> Documents = new();

    public CachingDocumentService(RealDocumentService realDocumentService)
    {
        _realDocumentService = realDocumentService;
    }

    public List<Document> GetDocuments(string bucketName)
    {
        Console.WriteLine("CachingDocumentService: Belgeler cache'de aranıyor...");

        if (Documents.Count == 0)
        {
            Console.WriteLine("Cache boş, gerçek servisten belgeler alınıyor...");
            Documents.AddRange(_realDocumentService.GetDocuments(bucketName));
        }
        else
        {
            Console.WriteLine("Cache'den belgeler alınıyor...");
        }

        return Documents;
    }
}
