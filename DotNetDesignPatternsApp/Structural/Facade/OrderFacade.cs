namespace DotNetDesignPatternsApp.Structural.Facade;

// Sipariş denilen şey aslında bir subsystem hiyerarşik yapısı.
// Sisteme bir sipariş düştüğünde
// InventoryService    -> Stock rezerve etmemiz lazım
// PaymentService      -> Ödeme kanalları
// ShipmentService     -> Kargo servisi
// NotificationService -> Sipariş ve diğer alt süreçler ile ilgili bildirimler

// Facade aslında bu tarz tüm subsystem'lerin birleştirildiği, koordine edildiği, tüm parçaların tek bir merkezden
// yönetildiği bir servis konumunda olduğunda kullanılır. Yani birden fazla subsystem var ve bunların birbirleriyle
// ilişkili olduğu durumlarda tek bir merkezden yönetmek istediğimizde kullanırız. Application class olarak karşımıza çıkar.
// OrderFacade = OrderingApplication
public class OrderFacade
{
    // SubSystems
    private readonly InventoryService _inventoryService;
    private readonly PaymentService _paymentService;
    private readonly ShipmentService _shipmentService;
    private readonly NotificationService _notificationService;

    public OrderFacade(
        InventoryService inventoryService,
        PaymentService paymentService,
        ShipmentService shipmentService,
        NotificationService notificationService)
    {
        _inventoryService = inventoryService;
        _paymentService = paymentService;
        _shipmentService = shipmentService;
        _notificationService = notificationService;
    }

    public void SubmitOrder()
    {
        bool stockExist = _inventoryService.CheckStock();

        if (stockExist)
            _inventoryService.ReserveStock(10);
        else
            throw new InvalidOperationException("Stock is not enough");

        _paymentService.Pay();
        _shipmentService.Start();
        _notificationService.SendNotification();
    }
}
