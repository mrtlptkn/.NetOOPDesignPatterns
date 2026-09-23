using DotNetDesignPatternsApp.Structural.Adapter.Contracts;

namespace DotNetDesignPatternsApp.Structural.Adapter.Concretes
{
  public class BBankPaymentAdapter : IPaymentAdapter
  {
    // Wrap'leyeceğimiz servis ne ?
    private readonly BBankPaymentService _thirdPartyPaymentService;

    public BBankPaymentAdapter(BBankPaymentService thirdPartyPaymentService)
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
}
