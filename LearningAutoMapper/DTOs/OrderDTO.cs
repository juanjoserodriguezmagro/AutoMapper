namespace LearningAutoMapper.DTOs;

public class OrderDTO {
    public string? ProductName { get; set; }
    public decimal ProductPrice { get; set; }
    public string? CustomerFirstName { get; set; }
    public string? CustomerLastName { get; set; }
    public string? CustomerFullName => $"{CustomerLastName}, {CustomerFirstName}";
    public DateTime OrderedAt { get; set; }
    public DateTime DeliveredAt { get; set; }
    public int Amount { get; set; }
    public decimal Price => ProductPrice * Amount;
}
