using DotNetDesignPatternsApp.Behavioral.Command.Commands;
using DotNetDesignPatternsApp.Behavioral.Command.Contracts;

namespace DotNetDesignPatternsApp.Behavioral.Command.Concretes;

public class SmartDeviceOnCommand : ISmartDeviceCommand
{
    private readonly ISmartHomeDevice _smartHomeDevice;

    public SmartDeviceOnCommand(ISmartHomeDevice smartHomeDevice)
    {
        _smartHomeDevice = smartHomeDevice;
    }

    public void Execute()
    {
        Console.WriteLine("Device is turned ON.");
        _smartHomeDevice.On();
    }
}
