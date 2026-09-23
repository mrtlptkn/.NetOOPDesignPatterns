namespace DotNetDesignPatternsApp.Structural.Bridge.Recievers;

// Implementation
public class SmartFridge : IDevice
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
