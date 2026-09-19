using DotNetDesignPatternsApp.Structural.Decorator.Concretes;
using DotNetDesignPatternsApp.Structural.Decorator.Contracts;

namespace DotNetDesignPatternsApp.Structural.Decorator.Application;

// Not: Structural Design Pattern (Yapısal Tasarım Desenleri), mevcut kodun yapısını mümkün olduğunca değiştirmeden
// sınıflara yeni davranışlar eklemeyi, farklı türdeki sınıfların birlikte çalışmasını sağlamayı ve dış sistemleri
// kendi uygulamamıza uyarlamayı amaçlayan tasarım desenleridir. Bu desenler, nesneler ve sınıflar arasındaki
// ilişkileri düzenleyerek sistemin daha esnek, genişletilebilir ve yönetilebilir olmasını sağlar.
public class BeverageApplication
{
    public void SubmitBeverage()
    {
        var coffee = new Coffee();
        coffee.Cost = 200.0m;

        Console.WriteLine(coffee.Description + " - Cost: " + coffee.Cost);
        var creamDecorator = new CreamDecorator(coffee);
        Console.WriteLine(creamDecorator.Description + " - Cost: " + creamDecorator.Cost);

        // wrapper creamDecorator olduğunda
        // Milk wraps Cream wraps Coffee
        IBeverage coffeeWithMilkAndCream = new MilkDecorator(creamDecorator);
        Console.WriteLine(coffeeWithMilkAndCream.Description + " - Cost: " + coffeeWithMilkAndCream.Cost);

        var tea = new Tea(); // 10 liradan aşağı satılamaz
        tea.Cost = 50.0m;
        Console.WriteLine(tea.Description + " - Cost: " + tea.Cost);

        IBeverage teaWithMilk = new MilkDecorator(tea);
        Console.WriteLine(teaWithMilk.Description + " - Cost: " + teaWithMilk.Cost);
    }
}
