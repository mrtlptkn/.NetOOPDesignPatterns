namespace DotNetDesignPatternsApp.Structural.Adapter.Contracts;

// Sistemimiz 3rd bir ödeme servisi ile çalışıyor.
// Bu sebeple bu değişebilir, farklı ödeme servisleri kullanabiliriz diye
// uygulama içindeki kullanım yapısını bozmamak için bir interface açıyoruz.
// Bu interface üzerinden 3rd servislere bağlanacağız.
public interface IPaymentAdapter
{
    void Pay(decimal amount, string currency);
}
