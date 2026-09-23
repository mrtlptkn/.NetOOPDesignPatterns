using DotNetDesignPatternsApp.Structural.Bridge.Invokers;
using DotNetDesignPatternsApp.Structural.Bridge.Recievers;

namespace DotNetDesignPatternsApp.Structural.Bridge.Application;

public class BridgeRemoteControllerAllDeviceApplication
{
    // Request based sıfırlanır -> Method request bazlı
    private readonly Dictionary<string, IRemote> _remoteControllerMap = new();
    // request based constructor sıfırlanır
    private readonly Dictionary<string, IDevice> _devices = new();

    public BridgeRemoteControllerAllDeviceApplication()
    {
        // Sistemdeki tüm device'lar sisteme tanımlanır
        _devices["smartFridge"] = new SmartFridge();
        _devices["smartTv"] = new SmartTv();
    }

    public void Open(RemoteRequest request)
    {
        if (!_devices.ContainsKey(request.DeviceName))
            throw new InvalidOperationException("Bu cihaz bulunamadi: " + request.DeviceName);

        // İstek atılan device, devices listesinden remote controller ile haberleşmek için bulunur
        IDevice device = _devices[request.DeviceName];

        // Sistemdeki tüm remote controller burada tanımlanır.
        IRemote controller1 = new BridgeOneTouchRemoteController(device);
        IRemote controller2 = new BridgeMultiTouchRemoteController(device);

        _remoteControllerMap["OneTouch"] = controller1;
        _remoteControllerMap["MultiTouch"] = controller2;

        if (_remoteControllerMap.ContainsKey(request.RemoteControlType))
        {
            IRemote controller = _remoteControllerMap[request.RemoteControlType];
            controller.Open();
        }
    }

    public void Close(RemoteRequest request)
    {
        if (!_devices.ContainsKey(request.DeviceName))
            throw new InvalidOperationException("Bu cihaz bulunamadi: " + request.DeviceName);

        // İstek atılan device, devices listesinden remote controller ile haberleşmek için bulunur
        IDevice device = _devices[request.DeviceName];

        // Sistemdeki tüm remote controller burada tanımlanır.
        IRemote controller1 = new BridgeOneTouchRemoteController(device);
        IRemote controller2 = new BridgeMultiTouchRemoteController(device);

        _remoteControllerMap["OneTouch"] = controller1;
        _remoteControllerMap["MultiTouch"] = controller2;

        if (_remoteControllerMap.ContainsKey(request.RemoteControlType))
        {
            IRemote controller = _remoteControllerMap[request.RemoteControlType];
            controller.Close();
        }
    }
}
