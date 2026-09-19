namespace DotNetDesignPatternsApp.Behavioral.Memento.Concretes;

// Memento: Originator'ýn (TextEditor) belirli bir andaki iç durumunu, bu durumu dýþarýya ifþa etmeden (encapsulation bozulmadan) saklayan salt-okunur anlýk görüntü (snapshot) nesnesi.
public class EditorMemento
{
    public string Content { get; }

    public EditorMemento(string content)
    {
        Content = content;
    }
}
