namespace DotNetDesignPatternsApp.Structural.Bridge.Recievers;

// DI kaydında IBridgeSmartHomeDevice için varsayılan (Spring'deki @Primary) implementasyon budur.
public class BridgeSmartTv : IBridgeSmartHomeDevice
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
