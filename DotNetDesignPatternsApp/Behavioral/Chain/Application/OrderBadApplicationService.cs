namespace DotNetDesignPatternsApp.Behavioral.Chain.Application;

public class OrderBadApplicationService
{
    // FraudService Dependency
    // InventoryService Dependency
    // PaymentService Dependency
    // Log Dependency
    // Order Repository for save order status
    // Sıralı işlem olduğunu anlamak için Process methodu içerisindeki if else yapısına bakmak gerekecekti.

    public void Process(OrderRequest request)
    {
        if (request.IsFraud) // Fraud Service Check
        {
            throw new NotSupportedException("Fraud order can not be processed");
        }
        else
        {
            if (request.IsStockAvailable) // Inventory Service Check
            {
                if (request.IsPaymentVerified) // Payment Service Check
                {
                    Console.WriteLine("Order processed successfully");
                }
                else
                {
                    Console.WriteLine("Payment failed. Order cannot be processed.");
                }
            }
            else
            {
                Console.WriteLine("Stock not available. Order cannot be processed.");
            }
        }
    }
}
