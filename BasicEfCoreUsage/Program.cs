Console.WriteLine("Hello, World!");

using var context = new BasicEfCoreUsageDbContext();

var item = new Item("Hello world Item!");

context.Items.Add(item);
await context.SaveChangesAsync();
Console.WriteLine($"My new items id {item.Id}");