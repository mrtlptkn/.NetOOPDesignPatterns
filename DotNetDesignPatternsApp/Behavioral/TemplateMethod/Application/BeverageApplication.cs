using DotNetDesignPatternsApp.Behavioral.TemplateMethod.Concretes;

namespace DotNetDesignPatternsApp.Behavioral.TemplateMethod.Application;

// Not: Template Method (Þablon Metot) tasarým deseni, bir algoritmanýn iskeletini bir üst sýnýfta
// (BeverageTemplate) sabitler; algoritmanýn bazý adýmlarýný ise alt sýnýflara (Coffee, Tea) býrakýr.
// Böylece algoritmanýn genel yapýsý deðiþmeden, alt sýnýflar sadece kendine özgü adýmlarý özelleþtirir.
public class BeverageApplication
{
    public void PrepareBeverages()
    {
        Console.WriteLine("--- Kahve hazýrlanýyor ---");
        var coffee = new Coffee();
        coffee.MakeBeverage();

        Console.WriteLine("--- Çay hazýrlanýyor ---");
        var tea = new Tea();
        tea.MakeBeverage();
    }
}
