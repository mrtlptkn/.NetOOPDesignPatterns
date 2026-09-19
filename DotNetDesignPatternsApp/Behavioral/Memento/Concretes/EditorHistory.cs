namespace DotNetDesignPatternsApp.Behavioral.Memento.Concretes;

// Caretaker: Memento'larý saklamaktan sorumludur ama Memento'nun içeriðine (Content) dokunmaz/bilmez.
// Sadece geçmiþ durumlarý bir yýðýn (stack) üzerinde tutup geri alma (undo) iþlemini yönetir.
public class EditorHistory
{
    private readonly Stack<EditorMemento> _history = new();

    public void Push(EditorMemento memento)
    {
        _history.Push(memento);
    }

    public EditorMemento? Pop()
    {
        return _history.Count > 0 ? _history.Pop() : null;
    }
}
