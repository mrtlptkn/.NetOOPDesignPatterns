namespace DotNetDesignPatternsApp.Structural.Adapter.Concretes;

public class BBankPaymentService
{
    public void MakePayment(decimal amount, string currency)
    {
        // BBank'ın ödeme işlemi gerçekleştirme mantığı
        Console.WriteLine("BBank ile " + amount + " " + currency + " ödendi.");
    }
}
