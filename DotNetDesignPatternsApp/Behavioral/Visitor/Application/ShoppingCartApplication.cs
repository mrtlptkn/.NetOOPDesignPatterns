using DotNetDesignPatternsApp.Behavioral.Visitor.Concretes;

namespace DotNetDesignPatternsApp.Behavioral.Visitor.Application;

// Not: Visitor (Ziyaretçi) tasarým deseni, bir nesne grubu (elements) üzerinde yeni iþlemler
// tanýmlamamýza, bu nesnelerin sýnýflarýný deðiþtirmeden izin verir. Ýþlem mantýðý Visitor içinde,
// eleman sýnýflarýnýn dýþýnda tutulur; böylece yeni bir iþlem eklemek istediðimizde sadece yeni bir
// Visitor yazmak yeterli olur (Open/Closed prensibi).
public class ShoppingCartApplication
{
    public void CalculateTotal()
    {
        var items = new List<Concretes.IShoppingItem>
        {
            new Book("Design Patterns", 150.0m),
            new Electronic("Kulaklýk", 300.0m, 2),
            new Book("Clean Code", 200.0m)
        };

        var visitor = new PriceCalculatorVisitor();

        foreach (var item in items)
        {
            item.Accept(visitor);
        }

        Console.WriteLine($"Toplam tutar: {visitor.Total:0.00}");
    }
}
