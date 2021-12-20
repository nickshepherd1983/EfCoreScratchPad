namespace BasicEfCoreUsage;

public class Item : BaseEntity
{
    public string Name { get; set; }

    public Item(string name)
    {
        Name = name;
    }
}