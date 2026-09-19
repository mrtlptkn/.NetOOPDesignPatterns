using DotNetDesignPatternsApp.Behavioral.Command.Contracts;

namespace DotNetDesignPatternsApp.Behavioral.Command.Recievers;

public class SmartFridge : ISmartHomeDevice
{
    public void On()
    {
        Console.WriteLine("Smart Fridge is now ON. Cooling started.");
    }

    public void Off()
    {
        Console.WriteLine("Smart Fridge is now OFF. Cooling stopped.");
    }
}
