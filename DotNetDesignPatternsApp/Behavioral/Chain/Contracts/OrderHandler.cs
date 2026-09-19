using DotNetDesignPatternsApp.Behavioral.Chain.Application;

namespace DotNetDesignPatternsApp.Behavioral.Chain.Contracts;

// Sipariş sürecinde yöneteceğimiz order request'i işleyecek olan sınıf.
// Fraud Detection, Stock Check ve Payment Check -> Bu handler üzerinden akışı kontrol eder.
// Not: Behavioral Pattern olduğu için ilgili sınıflara özel sınıflar üreterek sorumluluk yönetimi yapıyoruz.
// "Generic bir sınıf yapayım, tüm Handler süreçlerimde kullanayım" bakış açısı burası için yanlış.
public abstract class OrderHandler
{
    protected OrderHandler? Next;

    public OrderHandler SetNext(OrderHandler next)
    {
        Next = next;
        return next;
    }

    // Benim handle etmem gereken istek OrderRequest ama bu aşamada nasıl handle edeceğime dair bir fikrim yok.
    // Bu sebeple abstract method yaptık
    public abstract void Handle(OrderRequest order);

    // OrderHandler'dan kalıtım alan sınıflarda bir sonraki zincire geçip geçemediğimizi kontrol etmek için yaptık.
    // Next handler yoksa artık zincir bitmiştir.
    protected void PassToNext(OrderRequest order)
    {
        if (Next != null)
        {
            Next.Handle(order);
        }
        else
        {
            Console.WriteLine("Order Request steps are completed");
        }
    }
}
