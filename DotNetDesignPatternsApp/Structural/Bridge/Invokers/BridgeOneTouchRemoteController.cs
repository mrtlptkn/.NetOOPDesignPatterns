using DotNetDesignPatternsApp.Structural.Bridge.Recievers;

namespace DotNetDesignPatternsApp.Structural.Bridge.Invokers;

public class BridgeOneTouchRemoteController : IBridgeRemoteController
{
    private readonly IBridgeSmartHomeDevice _device;

    public BridgeOneTouchRemoteController(IBridgeSmartHomeDevice smartHomeDevice)
    {
        _device = smartHomeDevice;
    }

    public void Open()
    {
        Console.WriteLine("One Touch Remote: Cihaz aciliyor...");
        _device.On();
    }

    public void Close()
    {
        Console.WriteLine("One Touch Remote: Cihaz kapatiliyor...");
        _device.Off();
    }
}
