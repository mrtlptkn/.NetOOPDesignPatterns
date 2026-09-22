using DotNetDesignPatternsApp.Behavioral.Chain.Application;
using DotNetDesignPatternsApp.Behavioral.Chain.Concretes;
using DotNetDesignPatternsApp.Behavioral.Command.Application;
using DotNetDesignPatternsApp.Behavioral.Command.Contracts;
using DotNetDesignPatternsApp.Behavioral.Command.Invokers;
using DotNetDesignPatternsApp.Behavioral.Mediator.Application;
using DotNetDesignPatternsApp.Behavioral.Mediator.Concretes;
using DotNetDesignPatternsApp.Behavioral.Mediator.Contracts;
using DotNetDesignPatternsApp.Behavioral.Memento.Application;
using DotNetDesignPatternsApp.Behavioral.Observer.Application;
using DotNetDesignPatternsApp.Behavioral.Observer.Concretes;
using DotNetDesignPatternsApp.Behavioral.State.Application;
using DotNetDesignPatternsApp.Behavioral.State.Concretes;
using DotNetDesignPatternsApp.Behavioral.Strategy.Application;
using DotNetDesignPatternsApp.Behavioral.TemplateMethod.Application;
using DotNetDesignPatternsApp.Behavioral.Visitor.Application;
using DotNetDesignPatternsApp.Creational.Builder.Application;
using DotNetDesignPatternsApp.Structural.Adapter.Application;
using DotNetDesignPatternsApp.Structural.Adapter.Concretes;
using DotNetDesignPatternsApp.Structural.Adapter.Contracts;
using DotNetDesignPatternsApp.Structural.Bridge.Application;
using DotNetDesignPatternsApp.Structural.Bridge.Invokers;
using DotNetDesignPatternsApp.Structural.Bridge.Recievers;
using DotNetDesignPatternsApp.Structural.Composite.Application;
using DotNetDesignPatternsApp.Structural.Decorator.Application;
using DotNetDesignPatternsApp.Structural.Facade.Application;
using DotNetDesignPatternsApp.Structural.Flyweight.Application;
using DotNetDesignPatternsApp.Structural.Flyweight.Concretes;
using DotNetDesignPatternsApp.Structural.Facade.SubSytems;
using DotNetDesignPatternsApp.Structural.Proxy.Application;
using DotNetDesignPatternsApp.Structural.Proxy.Concretes;
using DotNetDesignPatternsApp.Structural.Proxy.Contracts;

namespace DotNetDesignPatternsApp;

// Service lifetime kararları (.NET DI):
// - Singleton: uygulama ömrü boyunca tek örnek. Stateles servisler veya paylaşılan, thread-safe
//   kaynaklar için uygundur. Mutable state içeren singleton'lar concurrency sorununa yol açabilir.
// - Scoped: bir HTTP isteği süresince tek örnek. DbContext gibi per-request state tutan bileşenler için önerilir.
// - Transient: her çözümlemede yeni örnek. Kısa ömürlü veya state tutmayan uygulama servisleri için güvenlidir.
// Aşağıda .NET'e uygun olarak riskli/stateful servisleri transient yapıp, fabrikalar ve paylaşılan
// cache'leri singleton bıraktık. Ayrıca kritik singleton'lar için thread-safety ve kullanım notları eklendi.
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
        // Stateless uygulama servisi; singleton olması performans açısından uygundur.
        services.AddSingleton<DotNetDesignPatternsApp.Structural.Decorator.Application.BeverageApplication>();

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

        // Flyweight
        // TreeFactory paylaşılan intrinsic durumu önbellekler -> singleton doğru seçim.
        services.AddSingleton<TreeFactory>();
        // istek/çalıştırma başına izolasyon için transient yapmak daha güvenlidir.
        services.AddTransient<ForestApplication>();

        // Composite
        // FileSystemApplication uygulama sırasında local nesneler oluşturuyor; transient tercih edildi.
        services.AddTransient<FileSystemApplication>();
    }

    private static void AddBehavioral(IServiceCollection services)
    {
        // Chain of Responsibility
        services.AddTransient<FraudCheckHander>();
        services.AddTransient<StockCheckHandler>();
        services.AddTransient<PaymentCheckHandler>();
        services.AddScoped<OrderBestApplicationTwoStep>();
        services.AddScoped<OrderBadApplicationService>();
        services.AddScoped<OrderBestApplicationService>();

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

        // Memento
        // TextEditorApplication simülasyon sırasında lokal undo/history tutuyor; per-execution izolasyon için transient tercih edildi.
        services.AddTransient<TextEditorApplication>();

        // Template Method
        // Template Method uygulamaları genelde lokal akışlara sahip; transient ile istekler arası durum sızıntısı önlenir.
        services.AddTransient<DotNetDesignPatternsApp.Behavioral.TemplateMethod.Application.BeverageApplication>();

        // Visitor
        // ShoppingCartApplication sadece hesaplama yapar ve local koleksiyon kullanır; transient daha güvenlidir.
        services.AddTransient<ShoppingCartApplication>();

        // Mediator
        // ChatRoomMediator merkezi bir aracı (singleton) olarak kayıtlı; ChatApplication ihtiyaç duyarsa DI ile alabilir.
        services.AddSingleton<IChatMediator, ChatRoomMediator>();
        services.AddSingleton<ChatApplication>();

        // Strategy
        services.AddSingleton<CommissionApplication>();
    }
}
