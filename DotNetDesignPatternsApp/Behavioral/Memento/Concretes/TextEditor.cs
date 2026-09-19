namespace DotNetDesignPatternsApp.Behavioral.Memento.Concretes;

// Originator: durumu saklanacak/geri yüklenecek olan asýl nesne.
// Kendi durumunu bir EditorMemento içine kaydedebilir ve verilen bir Memento'dan durumunu geri yükleyebilir.
public class TextEditor
{
    public string Content { get; private set; } = string.Empty;

    public void Write(string text)
    {
        Content += text;
    }

    public EditorMemento Save()
    {
        return new EditorMemento(Content);
    }

    public void Restore(EditorMemento memento)
    {
        Content = memento.Content;
    }
}
