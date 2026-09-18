namespace DotNetDesignPatternsApp.Structural.Facade;

public class ProductRepository
{
    // Java'daki package-private erişimin karşılığı: internal
    internal Product FindById(long id)
    {
        var p = new Product();
        p.Stock = 100;
        p.Name = "Ürün " + id;
        return p;
    }
}
