using DotNetDesignPatternsApp.Behavioral.Command.Commands;
using DotNetDesignPatternsApp.Behavioral.Command.Contracts;

namespace DotNetDesignPatternsApp.Behavioral.Command.Concretes;

// Bu Komutlar Device tipinde tanımlı bir sınıf ile alakalıdır.
public class SmartDeviceOffCommand : ISmartDeviceCommand
{
    private readonly ISmartHomeDevice _smartDevice;

    public SmartDeviceOffCommand(ISmartHomeDevice smartDevice)
    {
        _smartDevice = smartDevice;
    }

    public void Execute()
    {
        Console.WriteLine("Device is turned off.");
        _smartDevice.Off();
    }
}
