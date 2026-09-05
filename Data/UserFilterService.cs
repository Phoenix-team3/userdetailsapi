using UserDetailsApi.Models;

namespace UserDetailsApi.Data;

public static class UserFilterService
{
    public static IEnumerable<User> Apply(IEnumerable<User> users, UserQueryParameters filters)
    {
        var query = users;

        if (filters.Id is not null)
            query = query.Where(u => u.Id == filters.Id);

        if (!string.IsNullOrWhiteSpace(filters.FirstName))
            query = query.Where(u => u.FirstName.Contains(filters.FirstName, StringComparison.OrdinalIgnoreCase));

        if (!string.IsNullOrWhiteSpace(filters.LastName))
            query = query.Where(u => u.LastName.Contains(filters.LastName, StringComparison.OrdinalIgnoreCase));

        if (!string.IsNullOrWhiteSpace(filters.Email))
            query = query.Where(u => u.Email.Contains(filters.Email, StringComparison.OrdinalIgnoreCase));

        if (!string.IsNullOrWhiteSpace(filters.City))
            query = query.Where(u => u.City.Contains(filters.City, StringComparison.OrdinalIgnoreCase));

        if (!string.IsNullOrWhiteSpace(filters.Country))
            query = query.Where(u => u.Country.Contains(filters.Country, StringComparison.OrdinalIgnoreCase));

        if (!string.IsNullOrWhiteSpace(filters.Department))
            query = query.Where(u => u.Department.Contains(filters.Department, StringComparison.OrdinalIgnoreCase));

        if (!string.IsNullOrWhiteSpace(filters.Company))
            query = query.Where(u => u.Company.Contains(filters.Company, StringComparison.OrdinalIgnoreCase));

        if (!string.IsNullOrWhiteSpace(filters.Gender))
            query = query.Where(u => u.Gender.Contains(filters.Gender, StringComparison.OrdinalIgnoreCase));

        if (filters.MinAge is not null)
            query = query.Where(u => u.Age >= filters.MinAge);

        if (filters.MaxAge is not null)
            query = query.Where(u => u.Age <= filters.MaxAge);

        if (filters.IsActive is not null)
            query = query.Where(u => u.IsActive == filters.IsActive);

        return query;
    }
}
