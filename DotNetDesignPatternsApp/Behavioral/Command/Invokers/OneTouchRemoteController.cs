using DotNetDesignPatternsApp.Behavioral.Command.Commands;
using DotNetDesignPatternsApp.Behavioral.Command.Concretes;
using DotNetDesignPatternsApp.Behavioral.Command.Contracts;
using DotNetDesignPatternsApp.Behavioral.Command.Recievers;

namespace DotNetDesignPatternsApp.Behavioral.Command.Invokers;

public class OneTouchRemoteController : IRemoteController
{
    public void Open()
    {
        Console.WriteLine("3sn bekleme süresi var");
        Console.WriteLine("OneTouch Remote");
        // TV kumandasından open bastığımızda -> SmartTv çalıştırmak istiyoruz
        var command = new SmartDeviceOnCommand(new SmartTv());
        command.Execute(); // smart Tv açmayı tetikledim
    }

    public void Close()
    {
        Console.WriteLine("5sn bekleme süresi var");
        Console.WriteLine("OneTouch Remote");

        // TV kumandasından close bastığımızda -> SmartTv kapatmak istiyoruz
        var command = new SmartDeviceOffCommand(new SmartTv());
        command.Execute(); // smart Tv kapatmayı tetikledim
    }
}
