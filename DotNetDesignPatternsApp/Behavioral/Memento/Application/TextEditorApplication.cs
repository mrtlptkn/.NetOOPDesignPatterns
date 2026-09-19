using DotNetDesignPatternsApp.Behavioral.Memento.Concretes;

namespace DotNetDesignPatternsApp.Behavioral.Memento.Application;

// Not: Memento (Hatýra) tasarým deseni, bir nesnenin iç durumunu (encapsulation'ý bozmadan) dýþarýya
// kaydedip, ihtiyaç duyulduðunda o duruma geri dönebilmeyi saðlar. Genellikle "undo/redo" (geri al/ileri al)
// senaryolarýnda kullanýlýr. Bu örnekte bir metin editörünün yazdýðý her adým geçmiþe (EditorHistory) kaydedilir
// ve istenildiðinde bir önceki duruma geri dönülür.
public class TextEditorApplication
{
    public void SimulateEditing()
    {
        var editor = new TextEditor();
        var history = new EditorHistory();

        editor.Write("Merhaba");
        history.Push(editor.Save());
        Console.WriteLine("Mevcut içerik: " + editor.Content);

        editor.Write(" Dünya");
        history.Push(editor.Save());
        Console.WriteLine("Mevcut içerik: " + editor.Content);

        editor.Write(" !!!");
        Console.WriteLine("Mevcut içerik: " + editor.Content);

        var lastMemento = history.Pop();
        if (lastMemento is not null)
        {
            editor.Restore(lastMemento);
            Console.WriteLine("Geri alýndý, içerik: " + editor.Content);
        }
    }
}
