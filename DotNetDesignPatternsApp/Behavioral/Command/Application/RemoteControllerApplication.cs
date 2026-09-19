using DotNetDesignPatternsApp.Behavioral.Command.Contracts;
using DotNetDesignPatternsApp.Behavioral.Command.Invokers;

namespace DotNetDesignPatternsApp.Behavioral.Command.Application;

// Şu an bu uygulama milyon farklı SmartHomeDevice tipindeki SmartDevice ile
// milyon farklı RemoteController tipindeki kumanda ile çalışabilir durumda.
// Çünkü RemoteControllerApplication sınıfında IRemoteController tipinde bir map oluşturduk ve
// bu map'e istediğimiz kadar RemoteController ekleyebiliriz.
public class RemoteControllerApplication
{
    private readonly Dictionary<string, IRemoteController> _remoteControllerMap = new();

    public RemoteControllerApplication()
    {
        _remoteControllerMap["MultiTouch"] = new MultiTouchRemoteController();
        _remoteControllerMap["OneTouch"] = new OneTouchRemoteController();
        // yeni bir özellik ekleyince sadece buraya ilgili sınıfı ekle yeterli.
    }

    public void Open(RemoteControlRequest request)
    {
        if (_remoteControllerMap.TryGetValue(request.RemoteControlType, out var controller))
        {
            controller.Open();
        }
    }

    public void Close(RemoteControlRequest request)
    {
        if (_remoteControllerMap.TryGetValue(request.RemoteControlType, out var controller))
        {
            controller.Close();
        }
    }
}
