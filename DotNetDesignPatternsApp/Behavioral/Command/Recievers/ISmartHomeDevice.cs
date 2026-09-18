namespace DotNetDesignPatternsApp.Behavioral.Command.Recievers;

// Herhangi bir aygıtın açma kapama özelliği vardır
public interface ISmartHomeDevice
{
    void On();
    void Off();
}
