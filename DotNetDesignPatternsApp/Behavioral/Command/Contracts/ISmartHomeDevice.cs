namespace DotNetDesignPatternsApp.Behavioral.Command.Contracts;

// Herhangi bir aygıtın açma kapama özelliği vardır
public interface ISmartHomeDevice
{
    void On();
    void Off();
}
