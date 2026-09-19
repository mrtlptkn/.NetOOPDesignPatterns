using DotNetDesignPatternsApp.Behavioral.Mediator.Contracts;

namespace DotNetDesignPatternsApp.Behavioral.Mediator.Concretes;

// Somut Mediator: kayýtlý kullanýcýlar arasýndaki mesajlaþma trafiðini merkezi olarak yönetir.
// Bir kullanýcý mesaj gönderdiðinde, mediator bu mesajý gönderen hariç diðer tüm kullanýcýlara iletir.
public class ChatRoomMediator : IChatMediator
{
    private readonly List<ChatUser> _users = new();

    public void AddUser(ChatUser user)
    {
        _users.Add(user);
    }

    public void SendMessage(string message, ChatUser sender)
    {
        foreach (var user in _users.Where(u => u != sender))
        {
            user.Receive(message, sender.Name);
        }
    }
}
