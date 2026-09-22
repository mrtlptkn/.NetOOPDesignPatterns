namespace DotNetDesignPatternsApp.Samples
{
  public class CashPaymentMethod : IPaymentMethod
  {
    public void pay()
    {
      Console.WriteLine("Payment made with cash.");
    }
  }
}
