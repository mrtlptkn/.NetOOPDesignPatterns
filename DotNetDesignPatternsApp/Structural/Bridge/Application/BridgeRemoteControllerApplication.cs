using DotNetDesignPatternsApp.Structural.Bridge.Invokers;

namespace DotNetDesignPatternsApp.Structural.Bridge.Application;

// Şu an bu uygulama milyon farklı SmartHomeDevice tipindeki SmartDevice ile
// milyon farklı RemoteController tipindeki kumanda ile çalışabilir durumda.
// Çünkü sınıfta IBridgeRemoteController tipinde bir map oluşturduk ve bu map'e istediğimiz kadar RemoteController ekleyebiliriz.
public class BridgeRemoteControllerApplication
{
    private readonly Dictionary<string, IBridgeRemoteController> _remoteControllerMap = new();
    // Eğer request'e göre hangi sınıfın çalışacağına (smartFridge mi yoksa smartTv mi) device olarak karar vermek istersem
    // -> BridgeRemoteControllerAllDeviceApplication'a bak.

    public BridgeRemoteControllerApplication(
        BridgeMultiTouchRemoteController multiTouchRemoteController,
        BridgeOneTouchRemoteController oneTouchRemoteController)
    {
        _remoteControllerMap["MultiTouch"] = multiTouchRemoteController;
        _remoteControllerMap["OneTouch"] = oneTouchRemoteController;
        // yeni bir özellik ekleyince sadece buraya ilgili sınıfı ekle yeterli.
    }

    public void Open(BridgeRemoteControlRequest request)
    {
        if (_remoteControllerMap.TryGetValue(request.RemoteControlType, out var controller))
        {
            controller.Open();
        }
    }

    public void Close(BridgeRemoteControlRequest request)
    {
        if (_remoteControllerMap.TryGetValue(request.RemoteControlType, out var controller))
        {
            controller.Close();
        }
    }
}
