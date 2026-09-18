namespace DotNetDesignPatternsApp.Creational.Prototype;

// Java'daki Cloneable karşılığı. (.NET'te ICloneable arayüzü döndürdüğü tip object olduğu ve
// shallow/deep belirsizliği yüzünden önerilmez; bu yüzden türü belli bir Clone() metodu yazdık.)
public class GameCharacter
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }
    public List<string> Inventory { get; private set; }

    public GameCharacter(string name, int health, int level, List<string> inventory)
    {
        Name = name;
        Health = health;
        Level = level;
        Inventory = inventory;
    }

    public GameCharacter Clone()
    {
        // shallow copy: primitive (değer tipi) alanlar kopyalanır, referans tipler aynı nesneyi gösterir.
        var copyObj = (GameCharacter)MemberwiseClone();

        // Inventory yeni bir liste ile kopyalanır (deep copy), böylece g1 ve g2 aynı listeyi paylaşmaz.
        copyObj.Inventory = new List<string>(Inventory);

        return copyObj;
    }
}
