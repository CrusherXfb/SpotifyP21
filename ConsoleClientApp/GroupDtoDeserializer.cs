using System.Text.Json;

namespace ConsoleClientApp;

internal class GroupDtoDeserializer
{
    public static List<GroupDto> Deserialize(string json)
    {
        try
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            };

            return JsonSerializer.Deserialize<List<GroupDto>>(json, options);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deserializing JSON: {ex.Message}");
            return null;
        }
    }
}