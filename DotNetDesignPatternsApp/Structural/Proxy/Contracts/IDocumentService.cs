using DotNetDesignPatternsApp.Structural.Proxy.Concretes;

namespace DotNetDesignPatternsApp.Structural.Proxy.Contracts;

public interface IDocumentService
{
    List<Document> GetDocuments(string bucketName);
}
