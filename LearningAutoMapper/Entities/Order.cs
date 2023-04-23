using System.Diagnostics.CodeAnalysis;

namespace LearningAutoMapper.Entities;

public class Order {
    public required int Id { get; set; }
    public required Product Product { get; set; }
    public required Customer Customer { get; set; }
    public required DateTime OrderedAt { get; set; }
    public DateTime DeliveredAt => OrderedAt.AddDays(10);
    public required int Amount { get; set; }

    [SetsRequiredMembers]
    public Order(int id, Product product, Customer customer, int amount) =>
        (Id, Product, Customer, OrderedAt, Amount) = (id, product, customer, DateTime.Now, amount);
}
