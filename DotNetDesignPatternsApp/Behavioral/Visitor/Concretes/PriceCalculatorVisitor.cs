using DotNetDesignPatternsApp.Behavioral.Visitor.Contracts;

namespace DotNetDesignPatternsApp.Behavioral.Visitor.Concretes;

// Somut Visitor: sepetteki toplam fiyatý hesaplayan iþlemi, eleman sýnýflarýna dokunmadan burada tanýmlar.
public class PriceCalculatorVisitor : IShoppingCartVisitor
{
    public decimal Total { get; private set; }

    public void Visit(Book book)
    {
        Total += book.Price;
        Console.WriteLine($"Kitap: {book.Title} - {book.Price:0.00}");
    }

    public void Visit(Electronic electronic)
    {
        Total += electronic.Price;
        Console.WriteLine($"Elektronik: {electronic.Name} ({electronic.WarrantyYears} yýl garanti) - {electronic.Price:0.00}");
    }
}
