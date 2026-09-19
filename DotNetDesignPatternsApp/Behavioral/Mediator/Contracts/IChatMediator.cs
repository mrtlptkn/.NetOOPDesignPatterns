using DotNetDesignPatternsApp.Behavioral.Mediator.Concretes;

namespace DotNetDesignPatternsApp.Behavioral.Mediator.Contracts;

// Mediator: Colleague (katýlýmcý) nesnelerin birbirleriyle doðrudan haberleþmek yerine
// üzerinden iletiþim kurduðu aracý arayüzü. Böylece nesneler birbirini bilmek zorunda kalmaz,
// baðýmlýlýklar (coupling) azalýr.
public interface IChatMediator
{
    void SendMessage(string message, ChatUser sender);

    void AddUser(ChatUser user);
}
