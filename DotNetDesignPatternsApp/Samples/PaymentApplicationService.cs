namespace DotNetDesignPatternsApp.Samples
{


  // Strategy Pattern Net Core üzerinden implementasyonu.
  public class PaymentApplicationService
  {

    private readonly IServiceProvider serviceProvider;

    public PaymentApplicationService(IServiceProvider serviceProvider)
    {
      this.serviceProvider = serviceProvider;
    }

    public void ProcessPayment(string paymentType)
    {
      var paymentProcessor = serviceProvider.GetRequiredKeyedService<IPaymentMethod>(paymentType);

      if (paymentProcessor == null)
      {
        throw new InvalidOperationException($"No payment processor found for type '{paymentType}'.");
      }
      paymentProcessor.pay();
    }

  }
}
