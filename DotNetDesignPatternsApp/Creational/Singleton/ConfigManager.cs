namespace DotNetDesignPatternsApp.Creational.Singleton;

// Uygulama içerisindeki konfigürasyonları yönettiğim bir sınıf olsun
public sealed class ConfigManager
{
    // Not: Java'daki "Holder" yönteminin .NET karşılığı Lazy<T>'dir.
    // İlk erişimde (GetInstance çağrıldığında) oluşturulur, thread-safe'tir
    // (varsayılan mod: LazyThreadSafetyMode.ExecutionAndPublication).
    // Bu yöntemde instance alırken parametrik bir yapı kuramayız.
    // Uygulama genelinde tek bir instance sağlar.
    private static readonly Lazy<ConfigManager> Holder = new(() => new ConfigManager());

    public string AppName { get; }
    public string Version { get; }
    public string Environment { get; }

    // dışarıdan newlemeyi kapatmak için private constructor kullandık
    private ConfigManager()
    {
        AppName = "creational-patterns";
        Version = "1.0.0";
        // Spring'deki "spring.profiles.active" karşılığı
        Environment = System.Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "default";
    }

    // instance erişimi sağlar
    public static ConfigManager GetInstance() => Holder.Value;
}
