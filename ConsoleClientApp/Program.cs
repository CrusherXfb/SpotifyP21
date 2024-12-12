using ConsoleClientApp;

using var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:7009/Group");
using var response = await new HttpClient().SendAsync(request);
Console.WriteLine($"Status: {response.StatusCode}\n");
string content = await response.Content.ReadAsStringAsync();

var groups = GroupDtoDeserializer.Deserialize(content);

if (groups != null)
{
    foreach (var group in groups)
    {
        Console.WriteLine($"Id: {group.Id}, Title: {group.Title}");
    }
}

Console.ReadKey();