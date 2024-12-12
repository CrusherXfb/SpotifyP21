using SpotifyP21.Entities;

namespace SpotifyP21.Dto.Group;

public class UpdateGroupDto
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public List<int>? Genres { get; set; }
    public List<int>? Albums { get; set; }
}