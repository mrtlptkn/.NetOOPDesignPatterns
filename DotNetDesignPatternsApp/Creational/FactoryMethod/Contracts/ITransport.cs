namespace DotNetDesignPatternsApp.Creational.FactoryMethod.Contracts;

// Ship, Truck, Airplane
// Transport tipinde sınıflar üretebilmek için
// bunları üreten bir logistic fabrikasına ihtiyacımız var.
// Logistic fabrikasının tek bir görevi var. Transport tipinde nesneler üretmek.
// Taşımacılık Vasıtası üretim fabrikasıyız.

// Creational patternlerin ortak amacı, bir nesne üretimini yönetmek. new ile nesne yönetimini developer'ın
// if else komutları ile duruma göre yönetmesi yerine bunu akıllı başka sınıflar (factory) üzerinden yapabilmek.


// Burada bir davranış olduğu için Factory Pattern ile Strategy Pattern birlikte kullanılmıştır. 
public interface ITransport
{
    void Deliver(); // taşıma işlemi
}
