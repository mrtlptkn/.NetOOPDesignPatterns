using DotNetDesignPatternsApp.Behavioral.Command.Commands;
using DotNetDesignPatternsApp.Behavioral.Command.Recievers;

namespace DotNetDesignPatternsApp.Behavioral.Command.Invokers;

// Televizyon kumandası
public class MultiTouchRemoteController : IRemoteController
{
    public void Open()
    {
        // TV kumandasından open bastığımızda -> SmartTv çalıştırmak istiyoruz
        var command = new SmartDeviceOnCommand(new SmartTv());
        command.Execute(); // smart Tv açmayı tetikledim
        Console.WriteLine("MultiTouch Remote");
    }

    public void Close()
    {
        // TV kumandasından close bastığımda SmartTv kapatmak istiyorum.
        var command = new SmartDeviceOffCommand(new SmartTv());
        command.Execute(); // smart Tv kapatmayı tetikledim
        Console.WriteLine("MultiTouch Remote");
    }
}
