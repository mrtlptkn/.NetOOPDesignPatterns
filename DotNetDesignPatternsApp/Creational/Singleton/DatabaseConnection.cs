namespace DotNetDesignPatternsApp.Creational.Singleton;

// Not: .NET framework örneği -> TimeProvider.System, Random.Shared (framework içindeki singleton instance örnekleri)
public class DatabaseConnection
{
    // Bu nesneyi kilitleyeceğiz. volatile: CPU cacheleme ve instruction reordering sorunlarını önler.
    // Thread safe çalışmamızı sağlar.
    private static volatile DatabaseConnection? _instance;

    // Kilitleyeceğimiz nesne (Java'daki DatabaseConnection.class kilidinin karşılığı)
    private static readonly object SyncRoot = new();

    public string Url { get; }
    public int MaxPoolSize { get; }

    public void Connect()
    {
        Console.WriteLine("Connecting to database at " + Url + " with max pool size " + MaxPoolSize);
    }

    private DatabaseConnection(string url, int maxPoolSize)
    {
        // private constructor
        Url = url;
        MaxPoolSize = maxPoolSize;
    }

    // Manuel bir yöntem: kendimiz kilit mekanizması ile yönetim yapıyoruz (double-checked locking)
    public static DatabaseConnection GetInstance(string url, int maxPoolSize)
    {
        if (_instance == null) // ilk kontrol (lock öncesi)
        {
            lock (SyncRoot) // kilitleme
            {
                if (_instance == null) // ikinci kontrol (lock sonrası)
                {
                    _instance = new DatabaseConnection(url, maxPoolSize);
                }
            }
        }

        return _instance;
    }
}
