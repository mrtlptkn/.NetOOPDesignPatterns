namespace DotNetDesignPatternsApp.Structural.Adapter.Infra.Vendors;

// Senaryo gereği bu bir application içindeki service.
// Supplier (3rd party) servisi temsil ediyor.

// Amaç ThirdPartyPaymentService'i direkt kullanmadan kendi IPaymentProcessor interface'i üzerinden bu işlemi yürütmek.
// ThirdPartyPaymentService referansının uygulamanın bir çok yerine dağılmasını istemiyoruz.
// AWS Storage, Azure Storage, Google Cloud Storage, Firebase FireStore, Supabase Store
public class ABankPaymentService
{
    public PaymentStatus MakePayment(decimal total, string current)
    {
        Console.WriteLine("ThirdPartyPaymentService: " + total + " " + current + " odeme islemi gerceklestiriliyor...");
        return PaymentStatus.OK;
    }
}
