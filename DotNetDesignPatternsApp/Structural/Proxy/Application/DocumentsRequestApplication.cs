using DotNetDesignPatternsApp.Structural.Proxy.Concretes;

namespace DotNetDesignPatternsApp.Structural.Proxy.Application;

public class DocumentsRequestApplication
{
    private readonly RealDocumentService _documentService;
    // ekstradan proxy sınıfını da buraya ekliyoruz

    public DocumentsRequestApplication(RealDocumentService documentService)
    {
        _documentService = documentService;
    }

    public void Handle(DocumentRequest request)
    {
        Console.WriteLine("Belge talebi alindi: " + request.BucketName);
        // List<Document> docs = _documentService.GetDocuments(request.BucketName);

        // real service proxy servisine gönderilerek ara işleme tabi tutuluyor.
        // CachingDocumentService Proxy Sınıfı
        var cachingDocumentService = new CachingDocumentService(_documentService);
        List<Document> docs = cachingDocumentService.GetDocuments(request.BucketName);

        Console.WriteLine("Belge talebi tamamlandi: " + request.BucketName + ", Belgeler: [" + string.Join(", ", docs) + "]");
    }
}
