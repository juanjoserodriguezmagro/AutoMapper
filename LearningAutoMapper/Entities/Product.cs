using System.Diagnostics.CodeAnalysis;

namespace LearningAutoMapper.Entities;

public class Product {
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required decimal Price { get; set; }
    public string? Description { get; set; }
    public required DateTime CreatedAt { get; set; }

    [SetsRequiredMembers]
    public Product(int id, string name, decimal price, string? description) =>
        (Id, Name, Price, Description, CreatedAt) = (id, name, price, description, DateTime.Now);
}