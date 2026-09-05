namespace UserDetailsApi.Models;

/// <summary>
/// Optional filters accepted by the GET /api/users endpoint.
/// All string filters are case-insensitive substring matches.
/// </summary>
public class UserQueryParameters
{
    public int? Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? Department { get; set; }
    public string? Gender { get; set; }
    public int? MinAge { get; set; }
    public int? MaxAge { get; set; }
    public bool? IsActive { get; set; }
}
