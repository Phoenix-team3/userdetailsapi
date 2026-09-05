using UserDetailsApi.Models;

namespace UserDetailsApi.Data;

/// <summary>
/// In-memory, hardcoded mock user data.
/// </summary>
public static class UserRepository
{
    public static readonly IReadOnlyList<User> Users = new List<User>
    {
        new() { Id = 1, FirstName = "Dhanush", LastName = "Kumar", Email = "dhanush.kumar@example.com", Age = 24, Gender = "Male", City = "Bengaluru", Country = "India", Department = "Engineering", Company = "Acme Corp", IsActive = true },
        new() { Id = 2, FirstName = "Aisha", LastName = "Khan", Email = "aisha.khan@example.com", Age = 29, Gender = "Female", City = "Mumbai", Country = "India", Department = "Marketing", Company = "Globex Inc", IsActive = true },
        new() { Id = 3, FirstName = "John", LastName = "Smith", Email = "john.smith@example.com", Age = 35, Gender = "Male", City = "New York", Country = "USA", Department = "Sales", Company = "Initech", IsActive = false },
        new() { Id = 4, FirstName = "Emily", LastName = "Clark", Email = "emily.clark@example.com", Age = 27, Gender = "Female", City = "London", Country = "UK", Department = "Engineering", Company = "Acme Corp", IsActive = true },
        new() { Id = 5, FirstName = "Ravi", LastName = "Patel", Email = "ravi.patel@example.com", Age = 31, Gender = "Male", City = "Ahmedabad", Country = "India", Department = "Finance", Company = "Umbrella Ltd", IsActive = true },
        new() { Id = 6, FirstName = "Sofia", LastName = "Garcia", Email = "sofia.garcia@example.com", Age = 22, Gender = "Female", City = "Madrid", Country = "Spain", Department = "HR", Company = "Globex Inc", IsActive = false },
        new() { Id = 7, FirstName = "Liam", LastName = "Brown", Email = "liam.brown@example.com", Age = 40, Gender = "Male", City = "Sydney", Country = "Australia", Department = "Engineering", Company = "Stark Industries", IsActive = true },
        new() { Id = 8, FirstName = "Meera", LastName = "Nair", Email = "meera.nair@example.com", Age = 26, Gender = "Female", City = "Chennai", Country = "India", Department = "Marketing", Company = "Acme Corp", IsActive = true },
        new() { Id = 9, FirstName = "Carlos", LastName = "Diaz", Email = "carlos.diaz@example.com", Age = 33, Gender = "Male", City = "Barcelona", Country = "Spain", Department = "Sales", Company = "Umbrella Ltd", IsActive = false },
        new() { Id = 10, FirstName = "Hannah", LastName = "Lee", Email = "hannah.lee@example.com", Age = 28, Gender = "Female", City = "Seoul", Country = "South Korea", Department = "Finance", Company = "Stark Industries", IsActive = true },
    };
}
