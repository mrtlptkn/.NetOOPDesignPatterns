using DotNetDesignPatternsApp.Behavioral.Mediator.Contracts;

namespace DotNetDesignPatternsApp.Behavioral.Mediator.Concretes;

// Colleague: Mediator üzerinden diðer kullanýcýlarla haberleþen katýlýmcý sýnýf.
// ChatUser, diðer ChatUser nesnelerini doðrudan bilmez; sadece mediator'a mesaj gönderir.
public class ChatUser
{
    public string Name { get; }
    private readonly IChatMediator _mediator;

    public ChatUser(string name, IChatMediator mediator)
    {
        Name = name;
        _mediator = mediator;
        _mediator.AddUser(this);
    }

    public void Send(string message)
    {
        Console.WriteLine($"{Name} gönderiyor: {message}");
        _mediator.SendMessage(message, this);
    }

    public void Receive(string message, string senderName)
    {
        Console.WriteLine($"{Name} aldý ({senderName}): {message}");
    }
}
