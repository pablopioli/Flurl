using AutoBogus;
using WebApi;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/persons", () =>
{
    var users = new List<User>();

    for (int i = 0; i < 10; i++)
    {
        users.Add(AutoFaker.Generate<User>());
    }

    return users;
});

app.Run();
