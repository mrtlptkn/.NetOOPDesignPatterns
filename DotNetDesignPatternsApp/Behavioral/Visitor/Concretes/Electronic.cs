using DotNetDesignPatternsApp.Behavioral.Visitor.Contracts;

namespace DotNetDesignPatternsApp.Behavioral.Visitor.Concretes;

public class Electronic : IShoppingItem
{
    public string Name { get; set; }
    public decimal Price { get; }
    public int WarrantyYears { get; }

    public Electronic(string name, decimal price, int warrantyYears)
    {
        Name = name;
        Price = price;
        WarrantyYears = warrantyYears;
    }

    public void Accept(IShoppingCartVisitor visitor)
    {
        visitor.Visit(this);
    }
}
