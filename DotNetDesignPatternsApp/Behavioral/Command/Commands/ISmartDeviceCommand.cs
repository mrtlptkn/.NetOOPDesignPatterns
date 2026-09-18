namespace DotNetDesignPatternsApp.Behavioral.Command.Commands;

// Genel bir interface yapılabilir. Özel bir parametrik değer göndermeyecek ise her command
// sınıfı bunu kullanabilir
public interface ISmartDeviceCommand
{
    void Execute(); // komutu çalıştırır
}
