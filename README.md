# UserDetailsApi

.NET 10 Web API exposing hardcoded mock user data through a filterable GET endpoint, documented with Swagger.

## Run

```
dotnet run
```

Swagger UI: http://localhost:5080/swagger

## Endpoint

`GET /api/users`

Query parameters (all optional, combinable):

| Param       | Type   | Match             |
|-------------|--------|-------------------|
| id          | int    | exact             |
| firstName   | string | contains (ci)     |
| lastName    | string | contains (ci)     |
| email       | string | contains (ci)     |
| city        | string | contains (ci)     |
| country     | string | contains (ci)     |
| department  | string | contains (ci)     |
| gender      | string | contains (ci)     |
| minAge      | int    | >=                |
| maxAge      | int    | <=                |
| isActive    | bool   | exact             |

Example:

```
GET /api/users?country=India&minAge=25&isActive=true
GET /api/users?department=Engineering
```
