using DotNetDesignPatternsApp.Structural.Facade.Domain;

namespace DotNetDesignPatternsApp.Structural.Facade.SubSytems;

public class ProductRepository
{
    // package-private erişimi internal
    internal Product FindById(long id)
    {
        var p = new Product();
        p.Stock = 100;
        p.Name = "Ürün " + id;
        return p;
    }
}
