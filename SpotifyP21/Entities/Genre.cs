namespace SpotifyP21.Entities;

public class Genre
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public ICollection<Group> Groups { get; set; }
    public ICollection<Album> Albums { get; set; }
}