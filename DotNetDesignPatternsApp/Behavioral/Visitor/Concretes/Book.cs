using DotNetDesignPatternsApp.Behavioral.Visitor.Contracts;

namespace DotNetDesignPatternsApp.Behavioral.Visitor.Concretes;

public class Book : IShoppingItem
{
    public string Title { get; }
    public decimal Price { get; }

    public Book(string title, decimal price)
    {
        Title = title;
        Price = price;
    }

    public void Accept(IShoppingCartVisitor visitor)
    {
        visitor.Visit(this);
    }
}
