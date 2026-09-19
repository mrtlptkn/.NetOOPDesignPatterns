using DotNetDesignPatternsApp.Behavioral.Visitor.Concretes;

namespace DotNetDesignPatternsApp.Behavioral.Visitor.Contracts;

// Visitor: her somut eleman (Book, Electronic) için ayrý bir Visit metodu tanýmlayan arayüz.
// Yeni bir iþlem (örn. indirim hesaplama) eklemek istediðimizde, eleman sýnýflarýna dokunmadan
// bu arayüzü implemente eden yeni bir Visitor sýnýfý yazmak yeterlidir.
public interface IShoppingCartVisitor
{
    void Visit(Book book);

    void Visit(Electronic electronic);
}
