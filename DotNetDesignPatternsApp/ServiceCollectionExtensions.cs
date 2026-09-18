using DotNetDesignPatternsApp.Behavioral.Chain;
using DotNetDesignPatternsApp.Behavioral.Command.Application;
using DotNetDesignPatternsApp.Behavioral.Command.Invokers;
using DotNetDesignPatternsApp.Behavioral.Observer;
using DotNetDesignPatternsApp.Behavioral.State;
using DotNetDesignPatternsApp.Behavioral.Strategy;
using DotNetDesignPatternsApp.Creational.Builder;
using DotNetDesignPatternsApp.Structural.Adapter.Application;
using DotNetDesignPatternsApp.Structural.Adapter.Infra.Core;
using DotNetDesignPatternsApp.Structural.Adapter.Infra.Vendors;
using DotNetDesignPatternsApp.Structural.Bridge.Application;
using DotNetDesignPatternsApp.Structural.Bridge.Invokers;
using DotNetDesignPatternsApp.Structural.Bridge.Recievers;
using DotNetDesignPatternsApp.Structural.Decorator;
using DotNetDesignPatternsApp.Structural.Facade;
using DotNetDesignPatternsApp.Structural.Proxy;

namespace DotNetDesignPatternsApp;

// Spring Boot'ta @Component / @Service / @Scope ile otomatik yapılan bean kayıtlarının .NET karşılığı.
// Varsayılan Spring scope'u singleton olduğu için burada da AddSingleton kullanıldı.
// Spring'deki @Primary -> aynı interface'in birden fazla implementasyonunda "istenen" olanı,
// .NET'te interface'i doğrudan istenen implementasyona yönlendirerek sağlıyoruz.
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDesignPatternServices(this IServiceCollection services)
    {
        AddCreational(services);
        AddStructural(services);
        AddBehavioral(services);
        return services;
    }

    private static void AddCreational(IServiceCollection services)
    {
        // @Scope("prototype") -> her çözümlemede yeni instance
        services.AddTransient<PizzaApplication>();
    }

    private static void AddStructural(IServiceCollection services)
    {
        // Adapter
        services.AddSingleton<ABankPaymentService>();
        services.AddSingleton<BBankPaymentService>();
        services.AddSingleton<BankPaymentServiceAdapter>();
        services.AddSingleton<IPaymentProcessor>(sp => sp.GetRequiredService<BankPaymentServiceAdapter>());
        services.AddSingleton<BankPaymentApplication>();

        // Bridge
        services.AddSingleton<BridgeSmartFridge>();
        services.AddSingleton<BridgeSmartTv>();
        services.AddSingleton<IBridgeSmartHomeDevice>(sp => sp.GetRequiredService<BridgeSmartTv>()); // @Primary
        services.AddSingleton<BridgeOneTouchRemoteController>();
        services.AddSingleton<BridgeMultiTouchRemoteController>();
        services.AddSingleton<IBridgeRemoteController>(sp => sp.GetRequiredService<BridgeMultiTouchRemoteController>()); // @Primary
        services.AddSingleton<BridgeRemoteControllerApplication>();
        services.AddSingleton<BridgeRemoteControllerAllDeviceApplication>();

        // Decorator
        services.AddSingleton<BeverageApplication>();

        // Facade
        services.AddSingleton<ProductRepository>();
        services.AddSingleton<InventoryService>();
        services.AddSingleton<PaymentService>();
        services.AddSingleton<ShipmentService>();
        services.AddSingleton<NotificationService>();
        services.AddSingleton<OrderFacade>();

        // Proxy
        services.AddSingleton<RealDocumentService>();
        services.AddSingleton<CachingDocumentService>();
        services.AddSingleton<IDocumentService>(sp => sp.GetRequiredService<RealDocumentService>()); // @Primary
        services.AddSingleton<DocumentsRequestApplication>();
    }

    private static void AddBehavioral(IServiceCollection services)
    {
        // Chain of Responsibility
        services.AddSingleton<FraudCheckHander>();
        services.AddSingleton<StockCheckHandler>();
        services.AddSingleton<PaymentCheckHandler>();
        services.AddSingleton<OrderBadApplicationService>();
        services.AddSingleton<OrderBestApplicationService>();

        // Command
        services.AddSingleton<IRemoteController, MultiTouchRemoteController>();
        services.AddSingleton<IRemoteController, OneTouchRemoteController>();
        services.AddSingleton<RemoteControllerApplication>();

        // Observer (StockMarket singleton olmalı: subscriber listesini paylaşır)
        services.AddSingleton<SendEmailStockMarketPriceChangedHandler>();
        services.AddSingleton<SendSmsStockMarketPriceChangedHandler>();
        services.AddSingleton<StockMarket>();
        services.AddSingleton<StockMarketApplication>();

        // State (TrafficLight singleton: durum istekler arasında korunur, Red ile başlar)
        services.AddSingleton<TrafficLight>();
        services.AddSingleton<TrafficLightApplication>();

        // Strategy
        services.AddSingleton<CommissionApplication>();
    }
}
