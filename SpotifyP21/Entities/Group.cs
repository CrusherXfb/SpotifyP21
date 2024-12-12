namespace SpotifyP21.Entities;

public class Group
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public List<Genre>? Genres { get; set; }
    public List<Album>? Albums { get; set; }
}