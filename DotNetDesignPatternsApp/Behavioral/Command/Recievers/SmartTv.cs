namespace DotNetDesignPatternsApp.Behavioral.Command.Recievers;

public class SmartTv : ISmartHomeDevice
{
    public void On()
    {
        Console.WriteLine("Smart TV is turned ON");
    }

    public void Off()
    {
        Console.WriteLine("Smart TV is turned OFF");
    }
}
