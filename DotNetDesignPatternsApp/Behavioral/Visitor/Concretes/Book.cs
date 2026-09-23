using DotNetDesignPatternsApp.Behavioral.Visitor.Contracts;

namespace DotNetDesignPatternsApp.Behavioral.Visitor.Concretes;

public class Book : IShoppingItem
{
  public string Title { get; private set; }
  public decimal Price { get; }

  public Book(string title, decimal price)
  {
    Title = title;
    Price = price;
  }

  public void SetTitle(string title)
  {
    this.Title = title;
  }

  public void Accept(IShoppingCartVisitor visitor)
  {
    visitor.Visit(this);
  }
}
