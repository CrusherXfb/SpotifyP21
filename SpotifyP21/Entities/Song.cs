namespace SpotifyP21.Entities;

public class Song
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public ICollection<Album> Albums { get; set; }
}