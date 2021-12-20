namespace BasicEfCoreUsage;

public sealed class BasicEfCoreUsageDbContext : DbContext
{
    public DbSet<Item> Items => Set<Item>();
    public DbSet<OrderItem> OrderItems => Set<OrderItem>();
    public DbSet<Order> Orders => Set<Order>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BasicEfCoreUsage;Trusted_Connection=True;");
    }
}