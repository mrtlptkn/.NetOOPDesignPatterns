namespace DotNetDesignPatternsApp.Structural.Proxy;

public interface IDocumentService
{
    List<Document> GetDocuments(string bucketName);
}
