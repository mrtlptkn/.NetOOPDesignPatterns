using DotNetDesignPatternsApp.Behavioral.Visitor.Contracts;

namespace DotNetDesignPatternsApp.Behavioral.Visitor.Concretes
{
  public class TitleFormatVisitor : IShoppingCartVisitor
  {
    public void Visit(Book book)
    {
      if(book.Title is not null)
      {
        book.SetTitle(book.Title.Trim().Replace("ş", "s"));
      }
    }

    public void Visit(Electronic electronic)
    {
      electronic.Name =  electronic.Name.Trim().Replace("ş", "s");
    }
  }
}
