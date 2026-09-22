namespace DotNetDesignPatternsApp.Samples
{
  public class GiftCardPaymentMethod : IPaymentMethod
  {
    public void pay()
    {
      Console.WriteLine("Payment made using Gift Card.");
    }
  }
}
