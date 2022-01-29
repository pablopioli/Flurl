using Flurl.Http;
using JilSample;

FlurlHttp.Configure(settings => settings.JsonSerializer = new JilSerializer());

var users = await "http://localhost:15117/persons".GetAsync().ReceiveJson<List<User>>();

Console.WriteLine($"Users found: {users.Count}");