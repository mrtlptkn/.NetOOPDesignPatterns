using DotNetDesignPatternsApp.Structural.Adapter.Contracts;

namespace DotNetDesignPatternsApp.Structural.Adapter.Concretes;

// Tüm kendi uygulama referansımızda ise ThirdPartyPaymentServiceAdapter adapter'ını kullanıyoruz.
// Böylece herhangi bir değişiklikte uygulamada kırılmalar olmuyor.

// Adapter Pattern Dependency Inversion prensibine uyum sağlayamaz, sebebi ise ThirdPartyPaymentService bizim değil,
// herhangi bir interface ile implemente edemeyiz.

// Anti Corruption -> Bozulma Önleyici bir katman sağlamak.
// Uygulamalar arası yazılmış bir package (NuGet paketi) da olabilir. Örn: DomainName.Payment.Core
// Not: vendors tanımları DomainName.Payment.Core içinde yazılacak, uygulamadan bağımsız güncellenecek ki,
// birden fazla aynı altyapıyı tüketen uygulama bu paketten yararlansın.
public class ABankPaymentAdapter : IPaymentAdapter
{
    // Wrap'leyeceğimiz servis ne ?
    private readonly ABankPaymentService _thirdPartyPaymentService;

    public ABankPaymentAdapter(ABankPaymentService thirdPartyPaymentService)
    {
        _thirdPartyPaymentService = thirdPartyPaymentService;
    }

    public void Pay(decimal amount, string currency)
    {
        // Üçüncü taraf ödeme servisine uygun şekilde ödeme işlemi gerçekleştirilir.
        Console.WriteLine("ThirdPartyPaymentService ile ödeme yapıldı: " + amount + " " + currency);
        _thirdPartyPaymentService.MakePayment(amount, currency);
    }
}
