using DotNetDesignPatternsApp.Structural.Bridge.Invokers;
using DotNetDesignPatternsApp.Structural.Bridge.Recievers;

namespace DotNetDesignPatternsApp.Structural.Bridge.Application;

public class BridgeRemoteControllerAllDeviceApplication
{
    // Request based sıfırlanır -> Method request bazlı
    private readonly Dictionary<string, IBridgeRemoteController> _remoteControllerMap = new();
    // request based constructor sıfırlanır
    private readonly Dictionary<string, IBridgeSmartHomeDevice> _devices = new();

    public BridgeRemoteControllerAllDeviceApplication()
    {
        // Sistemdeki tüm device'lar sisteme tanımlanır
        _devices["smartFridge"] = new BridgeSmartFridge();
        _devices["smartTv"] = new BridgeSmartTv();
    }

    public void Open(BridgeRemoteControlRequest request)
    {
        if (!_devices.ContainsKey(request.DeviceName))
            throw new InvalidOperationException("Bu cihaz bulunamadi: " + request.DeviceName);

        // İstek atılan device, devices listesinden remote controller ile haberleşmek için bulunur
        IBridgeSmartHomeDevice device = _devices[request.DeviceName];

        // Sistemdeki tüm remote controller burada tanımlanır.
        IBridgeRemoteController controller1 = new BridgeOneTouchRemoteController(device);
        IBridgeRemoteController controller2 = new BridgeMultiTouchRemoteController(device);

        _remoteControllerMap["OneTouch"] = controller1;
        _remoteControllerMap["MultiTouch"] = controller2;

        if (_remoteControllerMap.ContainsKey(request.RemoteControlType))
        {
            IBridgeRemoteController controller = _remoteControllerMap[request.RemoteControlType];
            controller.Open();
        }
    }

    public void Close(BridgeRemoteControlRequest request)
    {
        if (!_devices.ContainsKey(request.DeviceName))
            throw new InvalidOperationException("Bu cihaz bulunamadi: " + request.DeviceName);

        // İstek atılan device, devices listesinden remote controller ile haberleşmek için bulunur
        IBridgeSmartHomeDevice device = _devices[request.DeviceName];

        // Sistemdeki tüm remote controller burada tanımlanır.
        IBridgeRemoteController controller1 = new BridgeOneTouchRemoteController(device);
        IBridgeRemoteController controller2 = new BridgeMultiTouchRemoteController(device);

        _remoteControllerMap["OneTouch"] = controller1;
        _remoteControllerMap["MultiTouch"] = controller2;

        if (_remoteControllerMap.ContainsKey(request.RemoteControlType))
        {
            IBridgeRemoteController controller = _remoteControllerMap[request.RemoteControlType];
            controller.Close();
        }
    }
}
