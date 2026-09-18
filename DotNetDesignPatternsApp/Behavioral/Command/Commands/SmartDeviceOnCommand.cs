using DotNetDesignPatternsApp.Behavioral.Command.Recievers;

namespace DotNetDesignPatternsApp.Behavioral.Command.Commands;

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
