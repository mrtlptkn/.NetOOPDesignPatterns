using DotNetDesignPatternsApp.Behavioral.Visitor.Contracts;

namespace DotNetDesignPatternsApp.Behavioral.Visitor.Concretes;

// Element: Visitor kabul edebilen (Accept) tüm somut elemanlarýn uyduðu ortak arayüz.
// Double dispatch mekanizmasýnýn ilk adýmý: her element kendi tipini bilir ve visitor.Visit(this) çaðýrýr.
public interface IShoppingItem
{
    void Accept(IShoppingCartVisitor visitor);
}
