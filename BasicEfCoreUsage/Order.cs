namespace BasicEfCoreUsage;

public sealed class Order : BaseEntity
{
    public DateTime Date { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }

    public Order()
    {
        OrderItems = new List<OrderItem>();
    }
}
