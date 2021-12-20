namespace BasicEfCoreUsage;

public class OrderItem : BaseEntity
{
    public Item? Item { get; set; }
}