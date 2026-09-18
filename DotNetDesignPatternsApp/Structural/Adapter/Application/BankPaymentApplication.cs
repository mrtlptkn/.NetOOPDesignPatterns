using DotNetDesignPatternsApp.Structural.Adapter.Infra.Core;

namespace DotNetDesignPatternsApp.Structural.Adapter.Application;

public class BankPaymentApplication
{
    // Bu olursa kodu refactor etmemiz gerekir. Bunu yapmayalım
    // private ABankPaymentService _aBankPaymentService = new ABankPaymentService();

    // Doğrusu tüm servisler haberleşirken adapter üzerinden haberleşecek.
    private readonly BankPaymentServiceAdapter _adapter;

    public BankPaymentApplication(BankPaymentServiceAdapter adapter)
    {
        _adapter = adapter;
    }

    public void Handle(PaymentRequest request)
    {
        Console.WriteLine("BankPaymentApplication: Odeme talebi alindi: " + request.Amount + " " + request.Currency);
        _adapter.Pay(request.Amount, request.Currency);
        Console.WriteLine("BankPaymentApplication: Odeme islemi tamamlandi.");
    }
}
