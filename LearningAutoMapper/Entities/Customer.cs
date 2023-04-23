using System.Diagnostics.CodeAnalysis;

namespace LearningAutoMapper.Entities;

public class Customer {
    public required int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }

    [SetsRequiredMembers]
    public Customer(int id, string firstName, string lastName, string email) =>
        (Id, FirstName, LastName, Email) = (id, firstName, lastName, email);
}