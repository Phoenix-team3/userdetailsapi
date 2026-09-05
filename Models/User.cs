namespace UserDetailsApi.Models;

/// <summary>
/// Represents a user's profile details.
/// </summary>
public record User
{
    public int Id { get; init; }
    public string FirstName { get; init; } = string.Empty;
    public string LastName { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public int Age { get; init; }
    public string Gender { get; init; } = string.Empty;
    public string City { get; init; } = string.Empty;
    public string Country { get; init; } = string.Empty;
    public string Department { get; init; } = string.Empty;
    public string Company { get; init; } = string.Empty;
    public bool IsActive { get; init; }
}
