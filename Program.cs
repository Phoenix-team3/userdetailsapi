using Microsoft.AspNetCore.Mvc;
using UserDetailsApi.Data;
using UserDetailsApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "User Details API",
        Version = "v1",
        Description = "A sample API exposing hardcoded mock user data with filterable query parameters."
    });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "User Details API v1");
});

app.MapGet("/api/users", ([AsParameters] UserQueryParameters filters) =>
{
    var result = UserFilterService.Apply(UserRepository.Users, filters);
    return Results.Ok(result);
})
.WithName("GetUsers")
.WithTags("Users")
.WithSummary("Get user details")
.WithDescription("Returns mock user details. Supports optional filtering by id, firstName, lastName, email, city, country, department, gender, minAge, maxAge and isActive.")
.Produces<IEnumerable<User>>(StatusCodes.Status200OK);

app.Run();
