namespace DotNetDesignPatternsApp.Structural.Proxy;

// DI kaydında IDocumentService için varsayılan (Spring'deki @Primary) implementasyon budur.
public class RealDocumentService : IDocumentService
{
    public List<Document> GetDocuments(string bucketName)
    {
        // Get Document by Bucket -> Büyük bir size
        // Document Db çeker
        // İkisini mapler

        return new List<Document>
        {
            new("a.txt", "~docs/hr"),
            new("b.df", "~docs/finance")
        };
    }
}
