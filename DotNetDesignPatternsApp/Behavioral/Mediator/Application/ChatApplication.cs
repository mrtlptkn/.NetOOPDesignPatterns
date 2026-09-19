using DotNetDesignPatternsApp.Behavioral.Mediator.Concretes;

namespace DotNetDesignPatternsApp.Behavioral.Mediator.Application;

// Not: Mediator (Aracý) tasarým deseni, bir grup nesnenin birbirleriyle doðrudan haberleþmesi yerine
// bir aracý (mediator) nesne üzerinden iletiþim kurmasýný saðlar. Bu sayede nesneler arasýndaki
// many-to-many baðýmlýlýklar, mediator ile many-to-one iliþkisine indirgenir ve sistem daha
// gevþek baðlý (loosely coupled) hale gelir. Bu örnekte bir sohbet odasýndaki kullanýcýlar
// birbirlerine doðrudan deðil, ChatRoomMediator üzerinden mesaj gönderir.
public class ChatApplication
{
    public void SimulateChat()
    {
        var mediator = new ChatRoomMediator();

        var alice = new ChatUser("Alice", mediator);
        var bob = new ChatUser("Bob", mediator);
        var charlie = new ChatUser("Charlie", mediator);

        alice.Send("Herkese merhaba!");
        bob.Send("Selam Alice!");
        charlie.Send("Ben de buradayým.");
    }
}
