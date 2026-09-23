using DotNetDesignPatternsApp.Structural.Bridge.Recievers;

namespace DotNetDesignPatternsApp.Structural.Bridge.Invokers;

// Dependency Inversion prensibine uyar.
// Aynı zamanda OCP'ye de uyar. Bir operasyonu abstraction üzerinden farklı sınıflara dağıtma prensibi.
// Kodda değişim yok, gelişim çok.
// DI kaydında IBridgeRemoteController için varsayılan (Spring'deki @Primary) implementasyon budur.
public class BridgeMultiTouchRemoteController : IRemote
{
    // Bridge
    // Herhangi bir remoteController'ün herhangi bir smart device ile köprü kurmasını abstraction üzerinden yapar.
    private readonly IDevice _smartHomeDevice;

    public BridgeMultiTouchRemoteController(IDevice smartDevice)
    {
        _smartHomeDevice = smartDevice;
    }

    public void Open()
    {
        Console.WriteLine("Multi Touch Remote Controller: Cihaz aciliyor...");
        _smartHomeDevice.On();
    }

    public void Close()
    {
        Console.WriteLine("Multi Touch Remote Controller: Cihaz kapatiliyor...");
        _smartHomeDevice.Off();
    }
}
