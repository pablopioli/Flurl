using Flurl.Http;
using TextJson;

FlurlHttp.Configure(settings => settings.JsonSerializer = new TextJsonSerializer());

var users = await "http://localhost:15117/persons".GetAsync().ReceiveJson<List<User>>();

Console.WriteLine($"Users found: {users.Count}");