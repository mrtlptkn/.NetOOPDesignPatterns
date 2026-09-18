namespace DotNetDesignPatternsApp.Structural.Adapter.Infra.Core;

// Sistemimiz 3rd bir ödeme servisi ile çalışıyor.
// Bu sebeple bu değişebilir, farklı ödeme servisleri kullanabiliriz diye
// uygulama içindeki kullanım yapısını bozmamak için bir interface açıyoruz.
// Bu interface üzerinden 3rd servislere bağlanacağız.
public interface IPaymentProcessor
{
    void Pay(decimal amount, string currency);
}
